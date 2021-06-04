using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Tools
{
    /// <summary>
    /// ダミーファイル作成に関する機能を提供します。
    /// </summary>
    public class DummyFileUtil
    {
        /// <summary>
        /// 指定したサイズのファイルを1つ作成します。
        /// </summary>
        /// <param name="filePath">ファイルの作成先のパス</param>
        /// <param name="fileSize">作成するファイルサイズをバイト単位で指定します。</param>
        /// <param name="complexity">
        /// 複雑さの度合いを指定します。1～255までが指定可能です。
        /// 例えば2を指定した場合2種類の値でファイルが作成されます。
        /// </param>
        /// <param name="ct">タスク操作でキャンセルが必要な場合に指定します。</param>
        /// <returns>非同期処理用の <see cref="Task"/></returns>
        public static async Task CreateFile(string filePath, uint fileSize, byte complexity = byte.MaxValue, IProgress<double> progress = null, CancellationToken ct = default)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath))) 
                throw new DirectoryNotFoundException($"親フォルダが存在しない。 path={filePath}");

            await createFileCore(filePath, fileSize, 0, complexity, progress, ct);
        }

        // AsciiCodeのみで実行する, 0x20(SP)～0x7F(~)でcomplexity=94に相当
        public static async Task CreateFileAscii(string filePath, uint fileSize, IProgress<double> progress = null, CancellationToken ct = default)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                throw new DirectoryNotFoundException($"親フォルダが存在しない。 path={filePath}");

            await createFileCore(filePath, fileSize, 0x20, 0x7F, progress, ct);
        }

        /// <summary>
        /// 指定したサイズのファイルを複数個フォルダに作成します。
        /// </summary>
        /// <param name="dir">ファイルを生成するフォルダパス</param>
        /// <param name="fileName">生成する基本ファイル名</param>
        /// <param name="fileCount">ファイル数</param>
        /// <param name="fileSize">作成するファイルサイズをバイト単位で指定します。</param>
        /// <param name="complexity">
        /// 複雑さの度合いを指定します。1～255までが指定可能です。
        /// 例えば2を指定した場合2種類の値でファイルが作成されます。
        /// </param>
        /// <param name="ct">タスク操作でキャンセルが必要な場合に指定します。</param>
        /// <returns>非同期処理用の <see cref="Task"/></returns>
        public static async Task CreateFiles(string dir, string fileName, uint fileCount, uint fileSize, byte complexity = byte.MaxValue, IProgress<double> progress = null, CancellationToken ct = default)
        {
            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException($"フォルダが存在しない。 path={dir}");

            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < fileCount; i++)
                    {
                        // ex)
                        //   dir      = X:\
                        //   fileName = hoge.bin
                        //     -> X:\hoge\hoge_1.bin
                        string filePath = Path.Combine(dir, $"{Path.GetFileNameWithoutExtension(fileName)}_{i + 1}{Path.GetExtension(fileName)}");
                        await createFileCore(filePath, fileSize, 0, complexity, null, ct);

                        Trace.WriteLine($"[{i}]='{filePath}'");

                        ct.ThrowIfCancellationRequested();

                        if (progress != null)
                        {
                            progress.Report((i + 1) / (double)fileCount);
                        }
                    }
                }
                catch (OperationCanceledException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"{ex}, dir='{dir}'");
                }
            });
        }

        // 上記のAsciiCode版
        public static async Task CreateFilesAscii(string dir, string fileName, uint fileCount, uint fileSize, IProgress<double> progress = null, CancellationToken ct = default)
        {
            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException($"フォルダが存在しない。 path={dir}");

            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < fileCount; i++)
                    {
                        string filePath = Path.Combine(dir, $"{Path.GetFileNameWithoutExtension(fileName)}_{i + 1}{Path.GetExtension(fileName)}");
                        await createFileCore(filePath, fileSize, 0x20, 0x7F, null, ct);

                        ct.ThrowIfCancellationRequested();

                        if (progress != null)
                        {
                            progress.Report((i + 1) / (double)fileCount);
                        }
                    }
                }
                catch (OperationCanceledException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"{ex}, dir='{dir}'");
                }
            });
        }

        private static async Task createFileCore(string filePath, uint fileSize, byte min, byte max, IProgress<double> progress, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    var r = new Random(); // 高速で並列実行起動を想定しない
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        for (long i = 0; i < fileSize; i++)
                        {
                            ct.ThrowIfCancellationRequested();

                            if (i % 1024 == 0)
                            {
                                fs.WriteByte((byte)'\n'); // 間違ってテキストで開くと大変なことになるので適当に改行
                            }
                            else
                            {
                                fs.WriteByte((byte)r.Next(min, max));
                            }

                            if (progress != null && i % 1024 == 0)
                            {
                                double value = (i + 1) / (double)fileSize;
                                progress.Report(value);
                            }
                        }
                    }
                }
                catch (OperationCanceledException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"{ex}, path='{filePath}'");
                    if (File.Exists(filePath)) File.Delete(filePath);
                }
            });
        }
    }
}