using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace studentManagement {
    public partial class SubjectForm : Form {
        public SubjectForm() {
            InitializeComponent();
            _loadAllFaculty();
            _createColumnsListViewAddScore();
            _createColumnsListViewDisplaySubject();
        }

        private readonly Database _db = Program.db;

        //private Database db = new Database(Program.dbLocation);
        private bool _isEditing; // Add a class-level variable to keep track of the state

        private static void _autoResizeListViewColumns(ListView listView) {
            foreach (ColumnHeader column in listView.Columns) {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                //column.Width = -1;
                //column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private static bool _isValidID(string studentId) {
            var validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.".ToCharArray();

            return studentId.All(c => validChars.Contains(c));
        }

        private void addAndEditForm(bool bCheck) {
            _isEditing = bCheck;
            if (_isEditing) {
                gbAddSubject.Text = @"Chỉnh Sửa Môn Học";
                btnAddSubject.Text = @"Lưu Chỉnh Sửa";
                labelDeleteSubject.Text = @"Chọn Môn Học";
                btnEditSubject.Text = @"Thêm Môn Học";
                btnDeleteSubject.Text = @"Chọn";
            } else {
                gbAddSubject.Text = @"Thêm Môn Học";
                btnAddSubject.Text = @"Thêm";
                labelDeleteSubject.Text = @"Xóa Môn Học";
                btnEditSubject.Text = @"Chỉnh Sửa Môn Học";
                btnDeleteSubject.Text = @"Xóa";
            }
        }

        private void addSubjectForm(int iNum) {
            if (iNum == 0) gbAddSubject.Show();
            else gbAddSubject.Hide();
        }

        private void addScoreForm(int iNum) {
            if (iNum == 0) gbAddScore.Show();
            else gbAddScore.Hide();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnEditSubject_Click(object sender, EventArgs e) {
            addAndEditForm(!_isEditing);
            _clearSelectedComboBoxAndListView();
        }

        private void btnAddSubjectAddScore_Click(object sender, EventArgs e) {
            addSubjectForm(0);
            addScoreForm(1);
            _clearSelectedComboBoxAndListView();
        }

        private void btnAddScore_Click(object sender, EventArgs e) {
            addScoreForm(0);
            addSubjectForm(1);
            _clearSelectedComboBoxAndListView();
        }

        //lay DS diem mon hoc
        private void _loadAllFaculty() {
            var faculties = _db.getAllFaculties();
            foreach (var faculty in faculties) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"]);
                comboBox1.Items.Add(faculty["TenKhoa"]);
                comboBox2.Items.Add(faculty["TenKhoa"]);
            }
        }

        private void _loadSubject() {
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Text = "";
            comboBoxSubject.Refresh();
            comboBoxSubject.SelectedIndex = -1;
            listViewDisplaySubject.Items.Clear();

            var subject = _db.getAllSubject();

            foreach (var row in subject) {
                var temp = _db.getFaculty(row["MaKhoa"]);
                if (temp != null) {
                    if (comboBoxFaculty.SelectedIndex != -1 &&
                        comboBoxFaculty.SelectedItem.ToString() == temp["TenKhoa"]) {
                        comboBoxSubject.Items.Add(row["TenMonHoc"]);
                    }
                }

                _autoResizeListViewColumns(listViewDisplaySubject);
            }

            comboBoxClass.Items.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Text = "";
            listViewAddScore.Items.Clear();
        }

        private void _loadSubjectClass() {
            comboBoxClass.Items.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Text = "";
            listViewAddScore.Items.Clear();

            var subjectClass = _db.getAllSubjectClass();
            if (comboBoxSubject.SelectedIndex == -1) return;
            foreach (var row in subjectClass) {
                var temp = _db.getSubject(row["MaMonHoc"]);
                if (comboBoxSubject.SelectedItem.ToString() == temp["TenMonHoc"])
                    comboBoxClass.Items.Add(row["TenLopHocPhan"]);
            }
        }

        private void _createColumnsListViewAddScore() {
            listViewAddScore.View = View.Details;
            listViewAddScore.FullRowSelect = true;
            listViewAddScore.GridLines = true;
            listViewAddScore.Columns.Add("Mã Sinh Viên", 100);
            listViewAddScore.Columns.Add("Họ Tên", 100);
            listViewAddScore.Columns.Add("Mã Lớp", 100);
            listViewAddScore.Columns.Add("Điểm", 100);

            _autoResizeListViewColumns(listViewAddScore);
        }

        private void _createColumnsListViewDisplaySubject() {
            listViewDisplaySubject.View = View.Details;
            listViewDisplaySubject.FullRowSelect = true;
            listViewDisplaySubject.GridLines = true;
            listViewDisplaySubject.Columns.Add("Mã Môn Học", 100);
            listViewDisplaySubject.Columns.Add("Tên Môn Học", 100);
            listViewDisplaySubject.Columns.Add("Số Tín Chỉ", 100);

            _autoResizeListViewColumns(listViewDisplaySubject);
        }

        private void _loadListViewAddScore() {
            listViewAddScore.Items.Clear();

            var maLop = _getSubjectClassID(comboBoxClass.SelectedItem.ToString());

            var subClass = _db.getSubjectClass(maLop);

            var subjectClassStudentList = _db.getAllSubjectClassStudents();

            foreach (var row in subjectClassStudentList) {
                if (row["MaLopHocPhan"] != maLop) continue;
                var student = _db.getStudent(row["MaSinhVien"]);
                var item = new ListViewItem(student["MaSinhVien"]);
                item.SubItems.Add(student["HoTen"]);
                item.SubItems.Add(row["MaLopHocPhan"]);
                if (subClass != null) {
                    var score = _db.getScore(row["MaSinhVien"], subClass["MaMonHoc"]);
                    item.SubItems.Add(score != null ? score["Diem"] : "");
                } else {
                    item.SubItems.Add("");
                }

                listViewAddScore.Items.Add(item);
            }

            _autoResizeListViewColumns(listViewAddScore);
        }

        private string _getFacultyID(string facultyName) {
            var result = "";

            var faculties = _db.getAllFaculties();
            foreach (var faculty in faculties) {
                if (facultyName != faculty["TenKhoa"]) continue;
                result = faculty["MaKhoa"];
                break;
            }

            return result;
        }

        private string _getSubjectID(string subjectName) {
            var result = "";

            var subjects = _db.getAllSubject();
            foreach (var subject in subjects) {
                if (subjectName != subject["TenMonHoc"]) continue;
                result = subject["MaMonHoc"];
                break;
            }

            return result;
        }

        private string _getSubjectClassID(string subjectClassName) {
            var result = "";

            var subjectClasses = _db.getAllSubjectClass();
            foreach (var subjectClass in subjectClasses) {
                if (subjectClassName != subjectClass["TenLopHocPhan"]) continue;
                result = subjectClass["MaLopHocPhan"];
                break;
            }

            return result;
        }

        private void _loadListViewDisplaySubject(string maKhoa) {
            listViewDisplaySubject.Items.Clear();

            var subject = _db.getAllSubject();
            foreach (var row in subject) {
                if (row["MaKhoa"] != maKhoa) continue;
                var item = new ListViewItem(row["MaMonHoc"]);
                item.SubItems.Add(row["TenMonHoc"]);
                item.SubItems.Add(row["SoTinChi"]);
                listViewDisplaySubject.Items.Add(item);
            }

            _autoResizeListViewColumns(listViewDisplaySubject);
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e) {
            _loadSubjectClass();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e) {
            _loadSubject();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxClass.SelectedIndex != -1) _loadListViewAddScore();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            listViewDisplaySubject.Items.Clear();
            var faculties = _db.getAllFaculties();
            if (comboBox2.SelectedIndex == -1) return;
            foreach (var faculty in faculties) {
                if (comboBox2.SelectedItem.ToString() != faculty["TenKhoa"]) continue;
                _loadListViewDisplaySubject(faculty["MaKhoa"]);
            }
        }

        private void _clearSelectedComboBoxAndListView() {
            comboBoxFaculty.SelectedIndex = -1;
            comboBoxSubject.Items.Clear();
            comboBoxSubject.SelectedIndex = -1;
            comboBoxSubject.Text = "";
            comboBoxClass.Items.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            listViewAddScore.Items.Clear();
            listViewDisplaySubject.Items.Clear();
            txtMssvAddScore.Clear();
            txtStudentName.Clear();
            txtCredit.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e) {
            if (_isEditing && listViewDisplaySubject.SelectedItems.Count == 1) {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox1.Text = listViewDisplaySubject.SelectedItems[0].SubItems[1].Text;
                textBox1.Focus();
                textBox2.Text = listViewDisplaySubject.SelectedItems[0].SubItems[0].Text;
                txtCredit.Text = listViewDisplaySubject.SelectedItems[0].SubItems[2].Text;
                comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            } else if (!_isEditing) {
                if (listViewDisplaySubject.SelectedItems.Count == 1) {
                    var subject = _db.removeSubject(listViewDisplaySubject.SelectedItems[0].SubItems[0].Text);
                    var subjectList = _db.getAllSubject();
                    Console.WriteLine(subject);
                    Console.WriteLine(subjectList.Count);
                    _loadListViewDisplaySubject(_getFacultyID(comboBox2.SelectedItem.ToString()));
                } else if (listViewDisplaySubject.SelectedItems.Count > 1) {
                    for (var i = 0; i < listViewDisplaySubject.SelectedItems.Count; i++) {
                        _db.removeSubject(_getSubjectID(listViewDisplaySubject.SelectedItems[i].SubItems[0].Text));
                    }
                }
            }
        }

        private void btnConfirmStudent_Click(object sender, EventArgs e) {
            if (listViewAddScore.SelectedItems.Count != 1) return;
            txtStudentName.Text = listViewAddScore.SelectedItems[0].SubItems[1].Text;
            txtMssvAddScore.Text = listViewAddScore.SelectedItems[0].SubItems[0].Text;
            if (listViewAddScore.SelectedItems[0].SubItems[3].Text != "") {
                textBox3.Text = listViewAddScore.SelectedItems[0].SubItems[3].Text;
                textBox3.Enabled = false;
            } else {
                textBox3.Text = "";
                textBox3.Enabled = true;
            }
        }

        private void btnAddScore_Click_1(object sender, EventArgs e) {
            if (!textBox3.Enabled) return;
            Console.WriteLine(txtMssvAddScore.Text);
            Console.WriteLine(_getSubjectID(comboBoxSubject.SelectedItem.ToString()));
            Console.WriteLine(float.Parse(textBox3.Text));
            var insertScore = _db.insertScore(txtMssvAddScore.Text,
                _getSubjectID(comboBoxSubject.SelectedItem.ToString()), float.Parse(textBox3.Text));
            Console.WriteLine(insertScore);
            _loadListViewAddScore();
        }

        private void btnAddSubject_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex != -1 && _isValidID(textBox2.Text) && textBox1.Text != "" &&
                txtCredit.Text.All(char.IsDigit)) {
                var subject = _db.insertSubject(textBox2.Text, textBox1.Text,
                    _getFacultyID(comboBox1.SelectedItem.ToString()), int.Parse(txtCredit.Text));
                _loadListViewDisplaySubject(_getFacultyID(comboBox1.SelectedItem.ToString()));
                if (!subject) return;
                textBox1.Text = "";
                textBox2.Text = "";
                txtCredit.Text = "";
                comboBox1.SelectedIndex = -1;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e) {
            errorProviderSubjectName.SetError(textBox1, textBox1.Text == "" ? "Không được để trống" : null);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e) {
            if (textBox2.Text == "") {
                errorProviderSubjectID.SetError(textBox2, "Không được để trống");
            } else if (!_isValidID(textBox2.Text)) {
                errorProviderSubjectID.SetError(textBox2, "Mã môn học không hợp lệ");
            } else {
                errorProviderSubjectID.SetError(textBox2, null);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e) {
            errorProviderFacultySelected.SetError(comboBox1,
                comboBox1.SelectedIndex == -1 ? "Không được để trống" : null);
        }

        private void txtCredit_Validating(object sender, CancelEventArgs e) {
            if (txtCredit.Text == "") {
                errorProviderCredit.SetError(txtCredit, "Không được để trống");
            } else if (!txtCredit.Text.All(char.IsDigit)) {
                errorProviderCredit.SetError(txtCredit, "Số tín chỉ phải là số");
            } else {
                errorProviderCredit.SetError(txtCredit, null);
            }
        }
    }
}