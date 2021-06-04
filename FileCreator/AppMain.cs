using System;
using System.Windows.Forms;

namespace Tools
{
    /// <summary>
    /// メインクラス
    /// </summary>
    internal static class AppMain
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new FileCreateForm();

            Application.Run(form);
        }
    }
}