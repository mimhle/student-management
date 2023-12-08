using System;
using System.Windows.Forms;

namespace studentManagement {
    public partial class LoginForm : Form {
        private readonly Database _db = Program.db;
        public LoginForm() {
            InitializeComponent();

            // test code for Database.cs
            //var db = new Database(Program.dbLocation);
            _db.insertStudent("SV01", "Nguyen Van A", "1999-01-01", "Nam", "CNTT", "48.CNTT.A");
            _db.insertStudent("SV02", "Nguyen Van A", "1999-01-01", "Nam", "CNTT", "48.CNTT.A");
            _db.insertStudent("SV03", "Nguyen Van B", "1999", "Nam", "CNTT", "48.CNTT.A", true);
            _db.insertStudent("SV04", "Nguyen Van C", "1999", "Nam", "CNTT", "48.CNTT.B", true);
            _db.updatePassword("SV03", "12345");

            _db.insertFaculty("CNTT", "Cong nghe thong tin");
            _db.insertFaculty("QTKD", "Quan tri kinh doanh");
            _db.insertClass("48.CNTT.A", "Cong nghe thong tin A", "CNTT");
            _db.insertClass("48.CNTT.B", "Cong nghe thong tin B", "CNTT");

            _db.insertSubjectClass("LTWIN001", "HCMUE_LTWin_HK1.2023-2024_901", "CNTT", "LTWIN");
            _db.insertSubjectClass("XSTK001", "HCMUE_XSTK_HK1.2023-2024_701", "CNTT", "XSTK");
            _db.insertSubject("LTWIN", "Lap trinh Windows", "CNTT", 2);
            _db.insertSubject("XSTK", "Xac suat thong ke", "CNTT", 3);
            _db.insertSubjectClassStudent("SV01", "LTWIN001");
            _db.insertSubjectClassStudent("SV02", "LTWIN001");
            _db.insertSubjectClassStudent("SV03", "XSTK001");
            _db.insertScore("SV02", "LTWIN", 10);
            _db.insertScore("SV03", "XSTK", 9);
            
            //db.removeStudent("SV01");
            //db.removeStudent("SV04");
            Console.WriteLine(_db.updatePassword("SV02", "123456"));
            Console.WriteLine(_db.checkLogin("SV02", "SV02"));
            Console.WriteLine(_db.checkLogin("SV02", "123456"));
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
            // menuForm(1);
            // loginForm(0);
            if (_db.checkLogin(txtUserName.Text, txtPassWord.Text)) {
                menuForm(1);
                loginForm(0);
            }
            else {
                MessageBox.Show(@"Sai tên đăng nhập hoặc mật khẩu", @"Lỗi đăng nhập", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e) {
            var studentForm = new StudentForm();
            studentForm.ShowDialog();
            studentForm.Close();
            Show();
        }

        private void btnAddClass_Click(object sender, EventArgs e) {
            var start = new ClassForm();
            start.ShowDialog();
            start.Close();
            Show();
        }

        private void btnSubject_Click(object sender, EventArgs e) {
            var start = new SubjectForm();
            start.ShowDialog();
            start.Close();
            Show();
        }
    }
}