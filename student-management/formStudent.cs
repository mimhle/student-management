using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace studentManagement {
    public partial class StudentForm : Form {
        public StudentForm() {
            InitializeComponent();
            loadAllFaculty();
            createColumsListViewDisplay();
        }

        private readonly Database _db = new Database(Program.dbLocation);
        private bool _addStudentActive = true;

        private void AutoResizeListViewColumns(ListView listView) {
            foreach (ColumnHeader column in listView.Columns) {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void btnReturn_Click(object sender, EventArgs e) {
            Close();
        }

        private bool isValidStudentId(string studentId) {
            if (studentId == "") return false;

            for (var i = 0; i < studentId.Length; i++) {
                if (studentId[i] == ' ') {
                    return false;
                }
            }

            return true;
        }

        private void btnFind_Click(object sender, EventArgs e) {
            loadStudentListView();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (listViewDisplay.SelectedItems.Count != 1) return;
            groupBoxFind_Show(false);
            groupBoxEdit_Show(true);
            var student = listViewDisplay.SelectedItems[0].SubItems[1].Text;
            txtNameEdit.Text = student;
            var studentList = _db.getAllStudents();
            foreach (var item in studentList) {
                if (item["HoTen"] != student) continue;
                comboBoxClassEdit.Text = item["HoTen"];
                if (item["LopTruong"] == "1")
                    checkBoxClassMonitorEdit.Checked = true;
                try {
                    birthEdit.Text = item["NgaySinh"];
                } catch {
                    MessageBox.Show(@"DateTime Error!");
                }
            }

            var facultyName = listViewDisplay.SelectedItems[0].SubItems[4].Text;
            var facultyList = _db.getAllFaculties();
            foreach (var item in facultyList) {
                if (item["MaKhoa"] == facultyName)
                    comboBoxFacultyEdit.Text = item["TenKhoa"];
            }

            var className = listViewDisplay.SelectedItems[0].SubItems[5].Text;
            var classList = _db.getAllClasses();
            foreach (var item in classList) {
                if (item["MaLop"] == className)
                    comboBoxClassEdit.Text = item["TenLop"];
            }

            var gender = listViewDisplay.SelectedItems[0].SubItems[3].Text;
            if (gender == "Nam") radioMaleEdit.Checked = true;
            else radioFemaleEdit.Checked = true;
        }

        private void btnReturnToFind_Click(object sender, EventArgs e) {
            groupBoxEdit_Show(false);
            groupBoxFind_Show(true);
            btnDelete.Enabled = false;
            clearAllSelected();
        }

        private void loadAllFaculty() {
            var facultyList = _db.getAllFaculties();
            foreach (var faculty in facultyList) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"]);
                comboBoxFacultyEdit.Items.Add(faculty["TenKhoa"]);
                comboLefFaculty.Items.Add(faculty["TenKhoa"]);
            }

            checkBoxClassMonitor.Enabled = false;
        }

        private void loadClassByFaculty(string facultyName) {
            comboBoxClass.Items.Clear();
            comboBoxClass.Text = "";
            comboLefBoxClass.Items.Clear();
            comboLefBoxClass.Text = "";
            comboBoxClassEdit.Items.Clear();
            comboBoxClassEdit.Text = "";
            var classList = _db.getAllClasses();
            foreach (var item in classList) {
                if (item["MaKhoa"] == getFacultyId(facultyName)) {
                    if (comboBoxFaculty.SelectedIndex != -1)
                        comboBoxClass.Items.Add(item["TenLop"]);
                    if (comboBoxFacultyEdit.SelectedIndex != -1) {
                        comboBoxClassEdit.Items.Add(item["TenLop"]);
                    }

                    if (comboLefFaculty.SelectedIndex != -1)
                        comboLefBoxClass.Items.Add(item["TenLop"]);
                }
            }
        }

        private void txtId_Validating(object sender, CancelEventArgs e) {
            if (!isValidStudentId(txtId.Text)) {
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
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Items.Clear();
            comboLefFaculty.SelectedIndex = -1;
            comboLefBoxClass.SelectedIndex = -1;
            comboLefBoxClass.Items.Clear();
            comboBoxFacultyEdit.SelectedIndex = -1;
            comboBoxClassEdit.SelectedIndex = -1;
            comboBoxClassEdit.Items.Clear();
            listViewDisplay.Items.Clear();
            checkBoxClassMonitorEdit.Checked = false;
            checkBoxClassMonitor.Checked = false;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl.SelectedIndex == 0 && !_addStudentActive) {
                clearAllSelected();
                _addStudentActive = true;
            } else if (tabControl.SelectedIndex == 1 && _addStudentActive) {
                clearAllSelected();
                _addStudentActive = false;
                btnDelete.Enabled = false;
                groupBoxEdit_Show(false);
                groupBoxFind_Show(true);
            }
        }

        private void comboLefFaculty_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboLefFaculty.SelectedIndex != -1)
                loadClassByFaculty(comboLefFaculty.SelectedItem.ToString());
        }

        private string getFacultyId(string facultyName) {
            var result = "";

            var facultyList = _db.getAllFaculties();
            foreach (var faculty in facultyList) {
                if (faculty["TenKhoa"] == facultyName) {
                    result = faculty["MaKhoa"];
                    break;
                }
            }

            return result;
        }

        private string getClassId(string className) {
            var result = "";

            var classList = _db.getAllClasses();
            foreach (var classItem in classList) {
                if (classItem["TenLop"] == className) {
                    result = classItem["MaLop"];
                    break;
                }
            }

            return result;
        }

        private void loadStudentListView() {
            listViewDisplay.Items.Clear();
            var studentList = _db.getAllStudents();

            if (txtIdFind.Text != "")
                if (radioButtonName.Checked) {
                    for (var i = 0; i < studentList.Count;) {
                        if (studentList[i]["HoTen"] != txtIdFind.Text) studentList.Remove(studentList[i]);
                        else i++;
                    }
                } else if (radioButtonId.Checked) {
                    var student = _db.getStudent(txtIdFind.Text);
                    if (student != null) {
                        var item = new ListViewItem(student["MaSinhVien"]);
                        item.SubItems.Add(student["HoTen"]);
                        item.SubItems.Add(student["NgaySinh"]);
                        item.SubItems.Add(student["GioiTinh"]);
                        item.SubItems.Add(student["MaKhoa"]);
                        item.SubItems.Add(student["MaLop"]);
                        listViewDisplay.Items.Add(item);
                    }

                    AutoResizeListViewColumns(listViewDisplay);
                    return;
                }

            if (comboLefFaculty.SelectedIndex != -1) {
                for (var i = 0; i < studentList.Count;) {
                    if (studentList[i]["MaKhoa"] != getFacultyId(comboLefFaculty.SelectedItem.ToString()))
                        studentList.Remove(studentList[i]);
                    else i++;
                }
            }

            if (comboLefBoxClass.SelectedIndex != -1) {
                for (var i = 0; i < studentList.Count;) {
                    if (studentList[i]["MaLop"] != getClassId(comboLefBoxClass.SelectedItem.ToString()))
                        studentList.Remove(studentList[i]);
                    else i++;
                }
            }

            foreach (var student in studentList) {
                var item = new ListViewItem(student["MaSinhVien"]);
                item.SubItems.Add(student["HoTen"]);
                item.SubItems.Add(student["NgaySinh"]);
                item.SubItems.Add(student["GioiTinh"]);
                item.SubItems.Add(student["MaKhoa"]);
                item.SubItems.Add(student["MaLop"]);
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
            if (radioButtonId.Checked) {
                comboLefBoxClass.Enabled = false;
                comboLefFaculty.Enabled = false;
                comboLefBoxClass.Text = string.Empty;
                comboLefFaculty.Text = string.Empty;
            }
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonName.Checked) {
                comboLefBoxClass.Enabled = true;
                comboLefFaculty.Enabled = true;
            }
        }

        private void btnUpdates_Click(object sender, EventArgs e) {
            string gender;
            bool classMonitor;

            if (radioFemaleEdit.Checked)
                gender = "Nữ";
            else
                gender = "Nam";

            if (checkBoxClassMonitorEdit.Checked)
                classMonitor = true;
            else
                classMonitor = false;

            var studentId = listViewDisplay.SelectedItems[0].SubItems[0].Text;
            var classId = getClassId(comboBoxClassEdit.Text);
            var facultyId = getFacultyId(comboBoxFacultyEdit.Text);
            if (txtNameEdit.Text != string.Empty && facultyId != string.Empty && classId != string.Empty) {
                if (_db.insertStudent(studentId, txtNameEdit.Text, birthEdit.Text, gender, facultyId, classId,
                        classMonitor)) {
                    MessageBox.Show(@"Thanh cong!");
                }
            } else
                MessageBox.Show(@"Vui long nhap day du thong tin!");
        }

        private bool checkAvaluableStudentId(string studentId) {
            var studentList = _db.getAllStudents();
            foreach (var item in studentList) {
                if (item["MaSinhVien"] == studentId) {
                    return false;
                }
            }

            return true;
        }

        private void btnInput_Click(object sender, EventArgs e) {
            string gender;
            var classMonitor = false;

            gender = radioBtnFemale.Checked ? "Nữ" : "Nam";

            if (checkBoxClassMonitor.Checked)
                classMonitor = true;

            var classId = getClassId(comboBoxClass.Text);
            var facultyId = getFacultyId(comboBoxFaculty.Text);
            if (txtId.Text != string.Empty && txtName.Text != string.Empty && birth.Text != string.Empty &&
                comboBoxClass.SelectedIndex != -1 && comboBoxFaculty.SelectedIndex != -1) {
                if (checkAvaluableStudentId(txtId.Text)) {
                    if (_db.insertStudent(txtId.Text, txtName.Text, birth.Text, gender, facultyId, classId,
                            classMonitor)) {
                        MessageBox.Show(@"Thanh cong!");
                    }
                } else
                    MessageBox.Show(@"Ma sinh vien da ton tai!");
            } else
                MessageBox.Show(@"Vui long nhap day du thong tin");
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                var studentId = listViewDisplay.SelectedItems[0].SubItems[0].Text;
                if (!_db.removeStudent(studentId)) return;
                MessageBox.Show(@"Thanh cong!");
                loadStudentListView();
            } catch {
                MessageBox.Show(@"vui long chon sinh vien de xoa!");
            }
        }

        private bool checkClassMonitor(string classId) {
            var classList = _db.getAllStudents();
            foreach (var item in classList) {
                if (item["MaLop"] == classId && item["LopTruong"] == "1")
                    return true;
            }

            return false;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFaculty.SelectedIndex != -1) {
                if (!checkClassMonitor(getClassId(comboBoxClass.SelectedItem.ToString())))
                    checkBoxClassMonitor.Enabled = true;
                else
                    checkBoxClassMonitor.Enabled = false;
            }
        }

        private void comboBoxClassEdit_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFacultyEdit.SelectedIndex != -1) {
                if (!checkClassMonitor(getClassId(comboBoxClassEdit.SelectedItem.ToString())))
                    checkBoxClassMonitorEdit.Enabled = true;
                else
                    checkBoxClassMonitorEdit.Enabled = false;
                if (checkBoxClassMonitorEdit.Checked)
                    checkBoxClassMonitorEdit.Enabled = true;
            }
        }
    }
}