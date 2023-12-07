using System;
using System.Linq;
using System.Windows.Forms;

namespace studentManagement {
    public partial class subjectForm : Form {
        public subjectForm() {
            InitializeComponent();
            LoadAllFaculty();
            CreateColumsListViewAddScore();
            CreateColumsListViewDisplaySubject();
        }

        private readonly Database db = Program.db;

        //private Database db = new Database(Program.dbLocation);
        private bool isEditing = false; // Add a class-level variable to keep track of the state

        private bool IsSubject = true;

        private void AutoResizeListViewColumns(System.Windows.Forms.ListView listView) {
            foreach (ColumnHeader column in listView.Columns) {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                //column.Width = -1;
                //column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        static bool IsValidID(string studentID) {
            char[] validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.".ToCharArray();

            return studentID.All(c => validChars.Contains(c));
        }

        private void addAndEditForm(bool bCheck) {
            isEditing = bCheck;
            if (isEditing) {
                gbAddSubject.Text = "Chỉnh Sửa Môn Học";
                btnAddSubject.Text = "Lưu Chỉnh Sửa";
                labelDeleteSubject.Text = "Chọn Môn Học";
                btnEditSubject.Text = "Thêm Môn Học";
                btnDeleteSubject.Text = "Chọn";
                bCheck = false;
            } else {
                gbAddSubject.Text = "Thêm Môn Học";
                btnAddSubject.Text = "Thêm";
                labelDeleteSubject.Text = "Xóa Môn Học";
                btnEditSubject.Text = "Chỉnh Sửa Môn Học";
                btnDeleteSubject.Text = "Xóa";
                bCheck = true;
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
            addAndEditForm(!isEditing);
            ClearSelectedComboBoxAndListView();
        }

        private void btnAddSubjectAddScore_Click(object sender, EventArgs e) {
            addSubjectForm(0);
            addScoreForm(1);
            ClearSelectedComboBoxAndListView();
            IsSubject = true;
        }

        private void btnAddScore_Click(object sender, EventArgs e) {
            addScoreForm(0);
            addSubjectForm(1);
            ClearSelectedComboBoxAndListView();
            IsSubject = false;
        }

        //lay DS diem mon hoc
        private void LoadAllFaculty() {
            var faculties = db.getAllFaculties();
            foreach (var faculty in faculties) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"]);
                comboBox1.Items.Add(faculty["TenKhoa"]);
                comboBox2.Items.Add(faculty["TenKhoa"]);
            }
        }

        private void LoadSubject() {
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Text = "";
            comboBoxSubject.Refresh();
            comboBoxSubject.SelectedIndex = -1;
            listViewDisplaySubject.Items.Clear();

            var subject = db.getAllSubject();

            foreach (var row in subject) {
                var temp = db.getFaculty(row["MaKhoa"].ToString()); ;
                if (temp != null) {
                    if (comboBoxFaculty.SelectedIndex != -1 && comboBoxFaculty.SelectedItem.ToString() == temp["TenKhoa"].ToString()) {
                        comboBoxSubject.Items.Add(row["TenMonHoc"]);
                    }
                }
                AutoResizeListViewColumns(listViewDisplaySubject);
            }
            comboBoxClass.Items.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Text = "";
            listViewAddScore.Items.Clear();
        }

        private void LoadSubjectClass() {
            comboBoxClass.Items.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBoxClass.Text = "";
            listViewAddScore.Items.Clear();

            var subjectClass = db.getAllSubjectClass();
            if (comboBoxSubject.SelectedIndex != -1)
                foreach (var row in subjectClass) {
                    var temp = db.getSubject(row["MaMonHoc"].ToString());
                    if (comboBoxSubject.SelectedItem.ToString() == temp["TenMonHoc"].ToString())
                        comboBoxClass.Items.Add(row["TenLopHocPhan"]);
                }
        }

        private void CreateColumsListViewAddScore() {
            listViewAddScore.View = View.Details;
            listViewAddScore.FullRowSelect = true;
            listViewAddScore.GridLines = true;
            listViewAddScore.Columns.Add("Mã Sinh Viên", 100);
            listViewAddScore.Columns.Add("Họ Tên", 100);
            listViewAddScore.Columns.Add("Mã Lớp", 100);
            listViewAddScore.Columns.Add("Điểm", 100);

            AutoResizeListViewColumns(listViewAddScore);
        }

        private void CreateColumsListViewDisplaySubject() {
            listViewDisplaySubject.View = View.Details;
            listViewDisplaySubject.FullRowSelect = true;
            listViewDisplaySubject.GridLines = true;
            listViewDisplaySubject.Columns.Add("Mã Môn Học", 100);
            listViewDisplaySubject.Columns.Add("Tên Môn Học", 100);
            listViewDisplaySubject.Columns.Add("Số Tín Chỉ", 100);

            AutoResizeListViewColumns(listViewDisplaySubject);
        }

        private void LoadListViewAddScore() {
            listViewAddScore.Items.Clear();

            var maLop = GetSubjectClassID(comboBoxClass.SelectedItem.ToString());

            var subClass = db.getSubjectClass(maLop);

            var subjectClassStudentList = db.getAllSubjectClassStudents();

            foreach (var row in subjectClassStudentList) {
                if (row["MaLopHocPhan"].ToString() == maLop) {
                    var student = db.getStudent(row["MaSinhVien"].ToString());
                    var item = new ListViewItem(student["MaSinhVien"].ToString());
                    item.SubItems.Add(student["HoTen"].ToString());
                    item.SubItems.Add(row["MaLopHocPhan"].ToString());
                    if (subClass != null) {
                        var score = db.getScore(row["MaSinhVien"].ToString(), subClass["MaMonHoc"]);
                        if (score != null) {
                            item.SubItems.Add(score["Diem"].ToString());
                        } else {
                            item.SubItems.Add("");
                        }
                    } else {
                        item.SubItems.Add("");
                    }
                    listViewAddScore.Items.Add(item);
                }
            }

            AutoResizeListViewColumns(listViewAddScore);
        }

        private string GetFacultyID(string facultyName) {
            var result = "";

            var faculties = db.getAllFaculties();
            foreach (var faculty in faculties) {
                if (facultyName == faculty["TenKhoa"].ToString()) {
                    result = faculty["MaKhoa"].ToString();
                    break;
                }
            }

            return result;
        }

        private string GetSubjectID(string subjectName) {
            var result = "";

            var subjects = db.getAllSubject();
            foreach (var subject in subjects) {
                if (subjectName == subject["TenMonHoc"].ToString()) {
                    result = subject["MaMonHoc"].ToString();
                    break;
                }
            }

            return result;
        }

        private string GetSubjectClassID(string subjectClassName) {
            var result = "";

            var subjectClasses = db.getAllSubjectClass();
            foreach (var subjectClass in subjectClasses) {
                if (subjectClassName == subjectClass["TenLopHocPhan"].ToString()) {
                    result = subjectClass["MaLopHocPhan"].ToString();
                    break;
                }
            }

            return result;
        }

        private void LoadListViewDisplaySubject(string MaKhoa) {
            listViewDisplaySubject.Items.Clear();

            var subject = db.getAllSubject();
            foreach (var row in subject) {
                if (row["MaKhoa"].ToString() == MaKhoa) {
                    var item = new ListViewItem(row["MaMonHoc"].ToString());
                    item.SubItems.Add(row["TenMonHoc"].ToString());
                    item.SubItems.Add(row["SoTinChi"].ToString());
                    listViewDisplaySubject.Items.Add(item);
                }
            }

            AutoResizeListViewColumns(listViewDisplaySubject);
        }

        private void ComboBoxSubject_SelectedIndexChanged(object sender, EventArgs e) {
            LoadSubjectClass();
        }

        private void ComboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e) {
            LoadSubject();
        }

        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxClass.SelectedIndex != -1)
                LoadListViewAddScore();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            listViewDisplaySubject.Items.Clear();
            var faculties = db.getAllFaculties();
            if (comboBox2.SelectedIndex != -1)
                foreach (var faculty in faculties) {
                    if (comboBox2.SelectedItem.ToString() == faculty["TenKhoa"].ToString()) {
                        LoadListViewDisplaySubject(faculty["MaKhoa"].ToString());
                    }
                }
        }

        private void ClearSelectedComboBoxAndListView() {
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

        private void BtnDeleteSubject_Click(object sender, EventArgs e) {
            if (isEditing && listViewDisplaySubject.SelectedItems.Count == 1) {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox1.Text = listViewDisplaySubject.SelectedItems[0].SubItems[1].Text;
                textBox1.Focus();
                textBox2.Text = listViewDisplaySubject.SelectedItems[0].SubItems[0].Text;
                txtCredit.Text = listViewDisplaySubject.SelectedItems[0].SubItems[2].Text;
                comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            } else if(!isEditing) {
                if(listViewDisplaySubject.SelectedItems.Count == 1) {
                    var subject = db.removeSubject(listViewDisplaySubject.SelectedItems[0].SubItems[0].Text);
                    var subjectList = db.getAllSubject();
                    Console.WriteLine(subject);
                    Console.WriteLine(subjectList.Count);
                    LoadListViewDisplaySubject(GetFacultyID(comboBox2.SelectedItem.ToString()));
                } else if(listViewDisplaySubject.SelectedItems.Count > 1) {
                    for (int i = 0; i < listViewDisplaySubject.SelectedItems.Count; i++) {
                        var _subject = db.removeSubject(GetSubjectID(listViewDisplaySubject.SelectedItems[i].SubItems[0].Text));
                    }
                }
            }
        }

        private void BtnConfirmStudent_Click(object sender, EventArgs e) {
            if (listViewAddScore.SelectedItems.Count == 1) {
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
        }

        private void BtnAddScore_Click_1(object sender, EventArgs e) {
            if (textBox3.Enabled == true) {
                Console.WriteLine(txtMssvAddScore.Text);
                Console.WriteLine(GetSubjectID(comboBoxSubject.SelectedItem.ToString()));
                Console.WriteLine(float.Parse(textBox3.Text));
                var insertScore = db.insertScore(txtMssvAddScore.Text, GetSubjectID(comboBoxSubject.SelectedItem.ToString()), float.Parse(textBox3.Text));
                Console.WriteLine(insertScore);
                LoadListViewAddScore();
            }
        }

        private void BtnAddSubject_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex != -1 && IsValidID(textBox2.Text) && textBox1.Text != "" && txtCredit.Text.All(char.IsDigit)) {
                var subject = db.insertSubject(textBox2.Text, textBox1.Text, GetFacultyID(comboBox1.SelectedItem.ToString()), int.Parse(txtCredit.Text));
                LoadListViewDisplaySubject(GetFacultyID(comboBox1.SelectedItem.ToString()));
                if (subject) {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    txtCredit.Text = "";
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        private void TextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if(textBox1.Text == "") {
                errorProviderSubjectName.SetError(textBox1, "Không được để trống");
            } else {
                errorProviderSubjectName.SetError(textBox1, null);
            }
        }

        private void TextBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if(textBox2.Text == "") {
                errorProviderSubjectID.SetError(textBox2, "Không được để trống");
            } else if(!IsValidID(textBox2.Text)) {
                errorProviderSubjectID.SetError(textBox2, "Mã môn học không hợp lệ");
            } else {
                errorProviderSubjectID.SetError(textBox2, null);
            }
        }

        private void ComboBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if(comboBox1.SelectedIndex == -1) {
                errorProviderFacultySelected.SetError(comboBox1, "Không được để trống");
            } else {
                errorProviderFacultySelected.SetError(comboBox1, null);
            }
        }

        private void TxtCredit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if(txtCredit.Text == "") {
                errorProviderCredit.SetError(txtCredit, "Không được để trống");
            } else if(!txtCredit.Text.All(char.IsDigit)) {
                errorProviderCredit.SetError(txtCredit, "Số tín chỉ phải là số");
            } else {
                errorProviderCredit.SetError(txtCredit, null);
            }
        }
    }
}
