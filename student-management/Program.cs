using System;
using System.Windows.Forms;

namespace studentManagement {
    static class Program {
        public static readonly Database db = new Database("Data Source=ltwin.db");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}