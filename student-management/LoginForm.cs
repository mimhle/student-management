using System;
using System.Windows.Forms;

namespace student {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();

            // test code for Database.cs
            var db = new Database("Data Source=ltwin_test.db");
            db.insertStudent("SV02", "Nguyen Van A", "1999-01-01", "Nam", "CNTT");
            db.insertStudent("SV03", "Nguyen Van B", "1999", "Nam", "CNTT");
            db.updatePassword("SV03", "12345");
            db.insertClass("CNTT01", "CNTT01", "CNTT", "LTWIN");
            db.insertFaculty("CNTT", "Cong nghe thong tin");
            db.insertSubject("LTWIN", "Lap trinh Windows");
            db.insertClassStudent("CNTT01", "SV02");
            db.insertScore("SV02", "LTWIN", 10);

            Console.WriteLine(db.updatePassword("SV02", "123456"));
            Console.WriteLine(db.checkLogin("SV02", "SV02"));
            Console.WriteLine(db.checkLogin("SV02", "123456"));
        }
        //all form display
        //if it iNum == 1 return show or else hide
        private void loginForm(int iNum) {
            if (iNum == 1) {
                gbLogin.Show();
                txtPassWord.Clear();
                txtUserName.Clear();
            }
            else gbLogin.Hide();
        }

        private void menuForm(int iNum) {
            if(iNum == 1) {
                gbMenu.Show();
                btnLogout.Show() ;
            }
            else {
                gbMenu.Hide();
                btnLogout.Hide();
            }
        }
        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            menuForm(0);
            loginForm(1);
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            menuForm(1);
            loginForm(0);
        }
    }
}