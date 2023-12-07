using System;
using System.Windows.Forms;

namespace studentManagement {
    static class Program {
        public static string dbLocation = "Data Source=ltwin.db";

        public static Database db = new Database(dbLocation);
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