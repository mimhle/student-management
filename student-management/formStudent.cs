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
            if (listViewDisplay.SelectedItems.Count == 1) {
                groupBoxFind_Show(false);
                groupBoxEdit_Show(true);
                var student = listViewDisplay.SelectedItems[0].SubItems[1].Text;
                txtNameEdit.Text = student;
                var studentList = db.getAllStudents();
                foreach (var item in studentList) {
                    if (item["HoTen"] != student) continue;
                    comboBoxClassEdit.Text = item["HoTen"].ToString();
                    if (item["LopTruong"] == "1")
                        checkBoxClassMonitorEdit.Checked = true;
                    try {
                        birthEdit.Text = item["NgaySinh"].ToString();
                    } catch {
                        MessageBox.Show("DateTime Error!");
                    }
                }

                String facultyName = listViewDisplay.SelectedItems[0].SubItems[4].Text;
                var facultyList = db.getAllFaculties();
                foreach (var item in facultyList) {
                    if (item["MaKhoa"].ToString() == facultyName)
                        comboBoxFacultyEdit.Text = item["TenKhoa"].ToString();
                }

                String className = listViewDisplay.SelectedItems[0].SubItems[5].Text;
                var classList = db.getAllClasses();
                foreach (var item in classList) {
                    if (item["MaLop"].ToString() == className)
                        comboBoxClassEdit.Text = item["TenLop"].ToString();
                }

                string gender = listViewDisplay.SelectedItems[0].SubItems[3].Text;
                if (gender == "Nam") radioMaleEdit.Checked = true;
                else radioFemaleEdit.Checked = true;
            }
        }

        private void btnReturnToFind_Click(object sender, System.EventArgs e) {
            groupBoxEdit_Show(false);
            groupBoxFind_Show(true);
            btnDelete.Enabled = false;
            clearAllSelected();
        }

        private void loadAllFaculty() {
            var facultyList = db.getAllFaculties();
            foreach (var faculty in facultyList) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"].ToString());
                comboBoxFacultyEdit.Items.Add(faculty["TenKhoa"].ToString());
                comboLefFaculty.Items.Add(faculty["TenKhoa"].ToString());
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
            var classList = db.getAllClasses();
            foreach (var item in classList) {
                if (item["MaKhoa"].ToString() == getFacultyID(facultyName)) {
                    if (comboBoxFaculty.SelectedIndex != -1)
                        comboBoxClass.Items.Add(item["TenLop"].ToString());
                    if (comboBoxFacultyEdit.SelectedIndex != -1) {
                        comboBoxClassEdit.Items.Add(item["TenLop"].ToString());
                    }

                    if (comboLefFaculty.SelectedIndex != -1)
                        comboLefBoxClass.Items.Add(item["TenLop"].ToString());
                }
            }
        }

        private void txtId_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!isValidStudentID(txtId.Text)) {
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
            if (tabControl.SelectedIndex == 0 && !addStudentActive) {
                clearAllSelected();
                addStudentActive = true;
            } else if (tabControl.SelectedIndex == 1 && addStudentActive) {
                clearAllSelected();
                addStudentActive = false;
                btnDelete.Enabled = false;
                groupBoxEdit_Show(false);
                groupBoxFind_Show(true);
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
                    if (studentList[i]["MaKhoa"].ToString() != getFacultyID(comboLefFaculty.SelectedItem.ToString()))
                        studentList.Remove(studentList[i]);
                    else i++;
                }
            }

            if (comboLefBoxClass.SelectedIndex != -1) {
                for (int i = 0; i < studentList.Count;) {
                    if (studentList[i]["MaLop"].ToString() != getClassID(comboLefBoxClass.SelectedItem.ToString()))
                        studentList.Remove(studentList[i]);
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

            string studentId = listViewDisplay.SelectedItems[0].SubItems[0].Text;
            string classId = getClassID(comboBoxClassEdit.Text);
            string facultyId = getFacultyID(comboBoxFacultyEdit.Text);
            if (txtNameEdit.Text != string.Empty && facultyId != string.Empty && classId != string.Empty) {
                if (db.insertStudent(studentId, txtNameEdit.Text, birthEdit.Text, gender, facultyId, classId,
                        classMonitor)) {
                    MessageBox.Show("Thanh cong!");
                }
            } else
                MessageBox.Show("Vui long nhap day du thong tin!");
        }

        private bool checkAvaluableStudentID(string studentID) {
            var studentList = db.getAllStudents();
            foreach (var item in studentList) {
                if (item["MaSinhVien"].ToString() == studentID) {
                    return false;
                }
            }

            return true;
        }

        private void btnInput_Click(object sender, EventArgs e) {
            string gender;
            bool classMonitor = false;

            if (radioBtnFemale.Checked)
                gender = "Nữ";
            else
                gender = "Nam";

            if (checkBoxClassMonitor.Checked)
                classMonitor = true;

            string classId = getClassID(comboBoxClass.Text);
            string facultyId = getFacultyID(comboBoxFaculty.Text);
            if (txtId.Text != string.Empty && txtName.Text != string.Empty && birth.Text != string.Empty &&
                comboBoxClass.SelectedIndex != -1 && comboBoxFaculty.SelectedIndex != -1) {
                if (checkAvaluableStudentID(txtId.Text)) {
                    if (db.insertStudent(txtId.Text, txtName.Text, birth.Text, gender, facultyId, classId,
                            classMonitor)) {
                        MessageBox.Show("Thanh cong!");
                    }
                } else
                    MessageBox.Show("Ma sinh vien da ton tai!");
            } else
                MessageBox.Show("Vui long nhap day du thong tin");
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                string studentId = listViewDisplay.SelectedItems[0].SubItems[0].Text;
                if (db.removeStudent(studentId)) {
                    MessageBox.Show("Thanh cong!");
                    loadStudentListView();
                }
            } catch {
                MessageBox.Show("vui long chon sinh vien de xoa!");
            }
        }

        private bool checkClassMonitor(string classID) {
            var classList = db.getAllStudents();
            foreach (var item in classList) {
                if (item["MaLop"].ToString() == classID && item["LopTruong"].ToString() == "1")
                    return true;
            }

            return false;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFaculty.SelectedIndex != -1) {
                if (!checkClassMonitor(getClassID(comboBoxClass.SelectedItem.ToString())))
                    checkBoxClassMonitor.Enabled = true;
                else
                    checkBoxClassMonitor.Enabled = false;
            }
        }

        private void comboBoxClassEdit_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFacultyEdit.SelectedIndex != -1) {
                if (!checkClassMonitor(getClassID(comboBoxClassEdit.SelectedItem.ToString())))
                    checkBoxClassMonitorEdit.Enabled = true;
                else
                    checkBoxClassMonitorEdit.Enabled = false;
                if (checkBoxClassMonitorEdit.Checked)
                    checkBoxClassMonitorEdit.Enabled = true;
            }
        }
    }
}