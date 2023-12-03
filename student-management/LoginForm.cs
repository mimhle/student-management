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
            db.insertClass("48.CNTT.A", "Cong nghe thong tin A", "CNTT");

            db.insertSubjectClass("LTWIN001", "HCMUE_LTWin_HK1.2023-2024_901", "CNTT", "LTWIN");
            db.insertSubject("LTWIN", "Lap trinh Windows");
            db.insertSubjectClassStudent("SV02", "LTWIN001");
            db.insertScore("SV02", "LTWIN", 10);

            db.removeStudent("SV01");
            db.removeStudent("SV04");
            Console.WriteLine(db.updatePassword("SV02", "123456"));
            Console.WriteLine(db.checkLogin("SV02", "SV02"));
            Console.WriteLine(db.checkLogin("SV02", "123456"));
        }
    }
}