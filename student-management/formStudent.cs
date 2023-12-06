using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace studentManagement {
    public partial class StudentForm : Form {
        public StudentForm() {
            InitializeComponent();
            loadAllFaculty();
            createColumsListViewDisplay();
        }

        private Database db = new Database("Data Source=ltwin_test.db");

        private void groupBoxFind_Show(bool check) {
            if (check) groupBoxFind.Show();
            else groupBoxFind.Hide();
        }
        private void groupBoxEdit_Show(bool check) {
            if (check) groupBoxEdit.Show();
            else groupBoxEdit.Hide();
        }
        private void btnReturn_Click(object sender, System.EventArgs e) {
            Close();
        }

        private bool isValidStudentID(string studentID) {

            if (studentID == "") return false;

            for (int i = 0; i < studentID.Length; i++) {
                if (studentID[i] == ' ') {
                    return false;
                }
            }

            return true;
        }

        private void btnFind_Click(object sender, System.EventArgs e) {
            if (isValidStudentID(txtIdFind.Text)) {
                var student = db.getStudent(txtIdFind.Text);
                if (student != null) {
                    Console.WriteLine(student["HoTen"].ToString());
                    Console.WriteLine(student["NgaySinh"]);
                    Console.WriteLine(student["GioiTinh"]);
                    Console.WriteLine(student["MaKhoa"]);
                    Console.WriteLine(student["MaLop"]);
                } else {
                    MessageBox.Show("Student not found");
                    clearAllSelectedComboBoxAndListView();
                }
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e) {
            groupBoxEdit_Show(true);
            groupBoxFind_Show(false);
        }

        private void btnReturnToFind_Click(object sender, System.EventArgs e) {
            groupBoxEdit_Show(false);
            groupBoxFind_Show(true);
        }

        private void loadAllFaculty() {
            var facultyList = db.getAllFaculties();
            foreach (var faculty in facultyList) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"].ToString());
            }
        }

        private void clearAllSelectedComboBoxAndListView() {
            comboBoxFaculty.SelectedItem = -1;
        }

        private void txtIdFind_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!isValidStudentID(txtIdFind.Text)) {
                errorProviderTxtFind.SetError(txtIdFind, "Please enter a valid student ID");
            } else {
                errorProviderTxtFind.SetError(txtIdFind, null);
            }
        }

        private void txtId_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!isValidStudentID(txtIdFind.Text)) {
                errorProvider1.SetError(txtId, "Please enter a valid student ID");
            } else {
                errorProvider1.SetError(txtId, null);
            }
        }

        private void createColumsListViewDisplay() {
            listViewDisplay.View = View.Details;
            listViewDisplay.FullRowSelect = true;
            listViewDisplay.GridLines = true;
            listViewDisplay.Columns.Add("Ma Sinh Vien", 100);
            listViewDisplay.Columns.Add("Ho Ten", 100);
            listViewDisplay.Columns.Add("Ngay Sinh", 100);
            listViewDisplay.Columns.Add("Gioi Tinh", 100);
            listViewDisplay.Columns.Add("Ma Khoa", 100);
            listViewDisplay.Columns.Add("Ma Lop", 100);
        }
    }
}
