using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Tools
{
    /// <summary>
    /// メインクラス
    /// </summary>
    public partial class FileCreateForm : Form
    {
        //
        // Fields
        // - - - - - - - - - - - - - - - - - - - -

        // タスクキャンセル用
        private CancellationTokenSource cts;

        //
        // Props
        // - - - - - - - - - - - - - - - - - - - -

        /// <summary>
        /// ファイル出力先フォルダを取得します。
        /// </summary>
        private string destDir => this.textBoxDestFolder.Text;

        /// <summary>
        /// 出力するファイル名を取得します。
        /// </summary>
        private string fileName => this.textBoxFileName.Text;

        /// <summary>
        /// 生成するファイル数を取得します。
        /// </summary>
        private uint fileCount => (uint)this.numericUpDownFileCount.Value;

        /// <summary>
        /// 生成するファイルサイズを取得します。
        /// </summary>
        private uint fileSize => (uint)this.numericUpDownFileSize.Value;

        /// <summary>
        /// 生成するファイルサイズの単位を取得します。
        /// </summary>
        private SizeUnit sizeUnit => (SizeUnit)this.comboBoxUnit.SelectedIndex;

        /// <summary>
        /// バイト換算した生成ファイルサイズを取得します。
        /// </summary>
        private uint totalFileSizeForByte => (uint)(this.fileSize * Math.Pow(1024, (double)this.sizeUnit));

        //
        // ctor
        // - - - - - - - - - - - - - - - - - - - -

        /// <summary>
        /// 既定の初期値を使用してオブジェクトを初期化します。
        /// </summary>
        public FileCreateForm()
        {
            this.InitializeComponent();

            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); // 初期位置
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastPath))
            {
                path = Properties.Settings.Default.LastPath;
            }

            this.textBoxDestFolder.Text = path;
            this.folderBrowserDialog.SelectedPath = this.textBoxDestFolder.Text;
        }

        //
        // Methods
        // - - - - - - - - - - - - - - - - - - - -

        /// <summary>
        /// フォルダ選択ボタン押下時のイベントハンドラ
        /// </summary>
        private void button_SelectFolder_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.folderBrowserDialog.ShowDialog())
            {
                this.textBoxDestFolder.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// 終了メニュー - Cliek : フォームを閉じます。
        /// </summary>
        private void toolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// ファイル生成ボタン - Click : ファイルを生成します。
        /// </summary>
        private async void button_createFile_Click(object sender, EventArgs e)
        {
            this.button_createFile.Enabled = false;
            this.button_Cancel.Enabled = true;
            this.toolStripProgressBar.Value = 0;

            this.cts = new CancellationTokenSource();
            var progress = new Progress<double>(this.onProgressUpdate);

            if (this.fileCount == 1)
            {
                await DummyFileUtil.CreateFile(Path.Combine(this.destDir, this.fileName), this.totalFileSizeForByte, 255, progress, this.cts.Token);
                // 255はzip圧縮すると1バイトも圧縮できない
            }
            else
            {
                await DummyFileUtil.CreateFiles(this.destDir, this.fileName, this.fileCount, this.totalFileSizeForByte, 255, progress, this.cts.Token);
            }

            Properties.Settings.Default.LastPath = this.destDir;
            Properties.Settings.Default.Save();

            MessageBox.Show("ファイルの作成が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.toolStripProgressBar.Value = 0;
            this.button_createFile.Enabled = true;
            this.button_Cancel.Enabled = false;
            if (this.checkBoxOpenExplorer.Checked) { Process.Start("EXPLORER.EXE", this.textBoxDestFolder.Text); }
        }

        /// <summary>
        /// 進捗通知が来たときのプログレスの更新
        /// </summary>
        private void onProgressUpdate(double progress) => this.toolStripProgressBar.Value = (int)(progress * 100.0);

        /// <summary>
        /// キャンセルボタン押したとき
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e) => this.cts.Cancel();
    }
}