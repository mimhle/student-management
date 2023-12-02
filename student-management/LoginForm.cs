using System;
using System.Windows.Forms;

namespace student {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();

            // test code for Database.cs
            var db = new Database("Data Source=ltwin_test.db");
            db.insertStudent("SV01", "Nguyen Van A", "1999-01-01", "Nam", "CNTT");
            db.insertStudent("SV02", "Nguyen Van A", "1999-01-01", "Nam", "CNTT");
            db.insertStudent("SV03", "Nguyen Van B", "1999", "Nam", "CNTT");
            db.updatePassword("SV03", "12345");
            db.insertClass("CNTT01", "CNTT01", "CNTT", "LTWIN");
            db.insertFaculty("CNTT", "Cong nghe thong tin");
            db.insertSubject("LTWIN", "Lap trinh Windows");
            db.insertClassStudent("CNTT01", "SV02");
            db.insertScore("SV02", "LTWIN", 10);

            db.removeStudent("SV01");
            db.removeStudent("SV04");
            Console.WriteLine(db.updatePassword("SV02", "123456"));
            Console.WriteLine(db.checkLogin("SV02", "SV02"));
            Console.WriteLine(db.checkLogin("SV02", "123456"));
        }
    }
}