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

        private Database db = new Database(Program.dbLocation);
        private bool addStudentActive = true;

        private void AutoResizeListViewColumns(System.Windows.Forms.ListView listView) {
            foreach (System.Windows.Forms.ColumnHeader column in listView.Columns) {
                column.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

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
            loadStudentListView();
        }

        private void btnEdit_Click(object sender, System.EventArgs e) {
            if(listViewDisplay.SelectedItems.Count == 1) {
                groupBoxFind_Show(false);
                groupBoxEdit_Show(true);
                txtNameEdit.Text = listViewDisplay.SelectedItems[0].SubItems[1].Text;
                /*String res = listViewDisplay.SelectedItems[0].SubItems[1].Text;
                var classList = db.getAllClasses();
                foreach (var item in classList) {
                    if (item["MaKhoa"].ToString() == getFacultyID(res)) {
                        comboBoxFacultyEdit.Text = item["TenKhoa"].ToString();
                    }
                }*/

            }

        }

        private void btnReturnToFind_Click(object sender, System.EventArgs e) {
            groupBoxEdit_Show(false);
            groupBoxFind_Show(true);
        }

        private void loadAllFaculty() {
            var facultyList = db.getAllFaculties();
            foreach (var faculty in facultyList) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"].ToString());
                comboBoxFacultyEdit.Items.Add(faculty["TenKhoa"].ToString());
                comboLefFaculty.Items.Add(faculty["TenKhoa"].ToString());
            }
        }
        private void loadClassByFaculty(string facultyName) {
            comboBoxClassId.Items.Clear();
            comboBoxClassId.Text = "";
            comboBoxClass.Items.Clear();
            comboBoxClass.Text = "";
            comboBoxClassIdEdit.Items.Clear();
            comboBoxClassIdEdit.Text = "";
            var classList = db.getAllClasses();
            foreach (var item in classList) {
                if (item["MaKhoa"].ToString() == getFacultyID(facultyName)) {
                    if (comboBoxFaculty.SelectedIndex != -1)
                        comboBoxClassId.Items.Add(item["TenLop"].ToString());
                    if (comboBoxFacultyEdit.SelectedIndex != -1) {
                        comboBoxClassIdEdit.Items.Add(item["TenLop"].ToString());
                    }
                    if (comboLefFaculty.SelectedIndex != -1)
                        comboBoxClass.Items.Add(item["TenLop"].ToString());
                }
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

            AutoResizeListViewColumns(listViewDisplay);
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFaculty.SelectedIndex != -1)
                loadClassByFaculty(comboBoxFaculty.SelectedItem.ToString());
        }

        private void clearAllSelected() {
            comboBoxFaculty.SelectedIndex = -1;
            comboBoxClassId.SelectedIndex = -1;
            comboBoxClassId.Items.Clear();
            comboLefFaculty.SelectedIndex = -1;
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Items.Clear();
            comboBoxFacultyEdit.SelectedIndex = -1;
            comboBoxClassIdEdit.SelectedIndex = -1;
            comboBoxClassIdEdit.Items.Clear();
            listViewDisplay.Items.Clear();

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl.SelectedIndex == 0 && !addStudentActive) {
                clearAllSelected();
                addStudentActive = true;
            } else if (tabControl.SelectedIndex == 1 && addStudentActive) {
                clearAllSelected();
                addStudentActive = false;
            }
        }

        private void comboLefFaculty_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboLefFaculty.SelectedIndex != -1)
                loadClassByFaculty(comboLefFaculty.SelectedItem.ToString());
        }

        private string getFacultyID(string facultyName) {
            var result = "";

            var facultyList = db.getAllFaculties();
            foreach (var faculty in facultyList) {
                if (faculty["TenKhoa"].ToString() == facultyName) {
                    result = faculty["MaKhoa"].ToString();
                    break;
                }
            }

            return result;
        }

        private string getClassID(string className) {
            var result = "";

            var classList = db.getAllClasses();
            foreach (var classItem in classList) {
                if (classItem["TenLop"].ToString() == className) {
                    result = classItem["MaLop"].ToString();
                    break;
                }
            }

            return result;
        }

        private void loadStudentListView() {
            listViewDisplay.Items.Clear();
            var studentList = db.getAllStudents();

            if (txtIdFind.Text != "")
                if (radioButtonName.Checked) {
                    for (int i = 0; i < studentList.Count;) {
                        if (studentList[i]["HoTen"].ToString() != txtIdFind.Text) studentList.Remove(studentList[i]);
                        else i++;
                    }
                } else if (radioButtonId.Checked) {
                    var student = db.getStudent(txtIdFind.Text);
                    if (student != null) {
                        var item = new ListViewItem(student["MaSinhVien"].ToString());
                        item.SubItems.Add(student["HoTen"].ToString());
                        item.SubItems.Add(student["NgaySinh"].ToString());
                        item.SubItems.Add(student["GioiTinh"].ToString());
                        item.SubItems.Add(student["MaKhoa"].ToString());
                        item.SubItems.Add(student["MaLop"].ToString());
                        listViewDisplay.Items.Add(item);
                    }
                    AutoResizeListViewColumns(listViewDisplay);
                    return;
                }

            if (comboLefFaculty.SelectedIndex != -1) {
                for (int i = 0; i < studentList.Count;) {
                    if (studentList[i]["MaKhoa"].ToString() != getFacultyID(comboLefFaculty.SelectedItem.ToString())) studentList.Remove(studentList[i]);
                    else i++;
                }
            }

            if (comboBoxClass.SelectedIndex != -1) {
                for (int i = 0; i < studentList.Count;) {
                    if (studentList[i]["MaLop"].ToString() != getClassID(comboBoxClass.SelectedItem.ToString())) studentList.Remove(studentList[i]);
                    else i++;

                }
            }

            foreach (var student in studentList) {
                var item = new ListViewItem(student["MaSinhVien"].ToString());
                item.SubItems.Add(student["HoTen"].ToString());
                item.SubItems.Add(student["NgaySinh"].ToString());
                item.SubItems.Add(student["GioiTinh"].ToString());
                item.SubItems.Add(student["MaKhoa"].ToString());
                item.SubItems.Add(student["MaLop"].ToString());
                listViewDisplay.Items.Add(item);
            }

            AutoResizeListViewColumns(listViewDisplay);
        }

        private void listViewDisplay_SelectedIndexChanged(object sender, EventArgs e) {
            if (listViewDisplay.SelectedItems.Count == 1) {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            } else {
                btnEdit.Enabled = false;
            }
        }

        private void comboBoxFacultyEdit_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFacultyEdit.SelectedIndex != -1)
                loadClassByFaculty(comboBoxFacultyEdit.SelectedItem.ToString());
        }

        private void radioButtonId_CheckedChanged(object sender, EventArgs e) {
            if(radioButtonId.Checked) { 
                comboBoxClass.Enabled = false;
                comboLefFaculty.Enabled = false;
                comboBoxClass.Text = string.Empty;
                comboLefFaculty.Text = string.Empty;
            }
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonName.Checked) {
                comboBoxClass.Enabled = true;
                comboLefFaculty.Enabled = true;
            }
        }

        private void btnUpdates_Click(object sender, EventArgs e) {
            txtNameEdit.Text = listViewDisplay.SelectedItems[1].SubItems[1].ToString();
        }
    }
}
