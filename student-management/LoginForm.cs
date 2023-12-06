using System;
using System.Windows.Forms;

namespace studentManagement {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();

            // test code for Database.cs
            var db = new Database("Data Source=ltwin_test.db");
            db.insertStudent("SV01", "Nguyen Van A", "1999-01-01", "Nam", "CNTT", "48.CNTT.A");
            db.insertStudent("SV02", "Nguyen Van A", "1999-01-01", "Nam", "CNTT", "48.CNTT.A");
            db.insertStudent("SV03", "Nguyen Van B", "1999", "Nam", "CNTT", "48.CNTT.A", true);
            db.updatePassword("SV03", "12345");

            db.insertFaculty("CNTT", "Cong nghe thong tin");
            db.insertFaculty("QTKD", "Quan tri kinh doanh");
            db.insertClass("48.CNTT.A", "Cong nghe thong tin A", "CNTT");

            db.insertSubjectClass("LTWIN001", "HCMUE_LTWin_HK1.2023-2024_901", "CNTT", "LTWIN");
            db.insertSubjectClass("XSTK001", "HCMUE_XSTK_HK1.2023-2024_701", "CNTT", "XSTK");
            db.insertSubject("LTWIN", "Lap trinh Windows", "CNTT", 2);
            db.insertSubject("XSTK", "Xac suat thong ke", "CNTT", 3);
            db.insertSubjectClassStudent("SV02", "LTWIN001");
            db.insertSubjectClassStudent("SV03", "XSTK001");
            db.insertScore("SV02", "LTWIN", 10);
            db.insertScore("SV03", "XSTK", 9);

            db.removeStudent("SV01");
            db.removeStudent("SV04");
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

        private void btnAddStudent_Click(object sender, EventArgs e) {
            var studentForm = new StudentForm();
            studentForm.ShowDialog();
            studentForm.Close();
            Show();
        }

        private void btnAddClass_Click(object sender, EventArgs e) {
            var start = new classForm();
            start.ShowDialog();
            start.Close();
            Show();
        }

        private void btnSubject_Click(object sender, EventArgs e) {
            var start = new subjectForm();
            start.ShowDialog();
            start.Close();
            Show();
        }
    }
}