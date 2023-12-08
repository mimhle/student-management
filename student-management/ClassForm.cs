using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace studentManagement {
    public partial class ClassForm : Form {

        public ClassForm() {
            InitializeComponent();
            _loadAllFaculty();
            _createColumsListViewClassList();
            _createColumsListViewStudentList();
            _createColumsListViewSubjectClassList();
            _createColumnsListViewSubjectClassListFSC();
            _loadListViewClassList(_db.getAllClasses());
        }

        private readonly Database _db = Program.db;


        private static void _autoResizeListViewColumns(ListView listView) {
            foreach (ColumnHeader column in listView.Columns) {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void _loadAllFaculty() {
            var facultyList = _db.getAllFaculties();
            foreach (var faculty in facultyList) {
                comboBoxFacultyFClass.Items.Add(faculty["TenKhoa"]);
                cbbTimTheoKhoa.Items.Add(faculty["TenKhoa"]);
                comboBoxFacultyFSC.Items.Add(faculty["TenKhoa"]);
                comboBoxFindFacultyFSC.Items.Add(faculty["TenKhoa"]);
                comboBoxFindFaculty.Items.Add(faculty["TenKhoa"]);
            }
        }

        private void _loadComboBoxSubjectClass() {
            var subjectClassList = _db.getAllSubject();
            foreach (var subjectClass in subjectClassList) {
                comboBoxSubjectClassFSC.Items.Add(subjectClass["TenMonHoc"]);
            }
        }


        private void _createColumsListViewClassList() {
            listViewClassList.View = View.Details;
            listViewClassList.FullRowSelect = true;
            listViewClassList.GridLines = true;
            listViewClassList.Columns.Add("Mã lớp", 100);
            listViewClassList.Columns.Add("Tên lớp", 200);
            listViewClassList.Columns.Add("Mã khoa", 100);

            _autoResizeListViewColumns(listViewClassList);
        }

        private void _createColumsListViewStudentList() {
            listViewStudentList.View = View.Details;
            listViewStudentList.FullRowSelect = true;
            listViewStudentList.GridLines = true;
            listViewStudentList.Columns.Add("Mã sinh viên", 100);
            listViewStudentList.Columns.Add("Họ tên", 200);
            listViewStudentList.Columns.Add("Mã Khoa", 200);
            listViewStudentList.Columns.Add("Mã lớp", 100);

            _autoResizeListViewColumns(listViewStudentList);
        }

        private void _createColumsListViewSubjectClassList() {
            listViewSubjectClassList.View = View.Details;
            listViewSubjectClassList.FullRowSelect = true;
            listViewSubjectClassList.GridLines = true;
            listViewSubjectClassList.Columns.Add("Mã lớp học phần", 100);
            listViewSubjectClassList.Columns.Add("Tên lớp học phần", 200);
            listViewSubjectClassList.Columns.Add("Mã khoa", 100);
            listViewSubjectClassList.Columns.Add("Mã môn học", 100);
            listViewSubjectClassList.Columns.Add("Tên môn học", 200);
            listViewSubjectClassList.Columns.Add("Số lượng", 100);

            _autoResizeListViewColumns(listViewSubjectClassList);
        }

        private void _createColumnsListViewSubjectClassListFSC() {
            listViewSubjectClassListFSC.View = View.Details;
            listViewSubjectClassListFSC.FullRowSelect = true;
            listViewSubjectClassListFSC.GridLines = true;
            listViewSubjectClassListFSC.Columns.Add("Mã lớp học phần", 100);
            listViewSubjectClassListFSC.Columns.Add("Tên lớp học phần", 200);
            listViewSubjectClassListFSC.Columns.Add("Mã môn học", 100);
            listViewSubjectClassListFSC.Columns.Add("Tên môn học", 200);
            listViewSubjectClassListFSC.Columns.Add("Số lượng", 100);

            _autoResizeListViewColumns(listViewSubjectClassListFSC);
        }

        private void _loadListViewStudentList(List<Dictionary<string, string>> studentList) {
            listViewStudentList.Items.Clear();

            foreach (var student in studentList) {
                var item = new ListViewItem(student["MaSinhVien"]);
                item.SubItems.Add(student["HoTen"]);
                //item.SubItems.Add(Student["GioiTinh"]);
                //item.SubItems.Add(Student["NgaySinh"]);
                item.SubItems.Add(student["MaKhoa"]);
                item.SubItems.Add(student["MaLop"]);
                listViewStudentList.Items.Add(item);
            }

            _autoResizeListViewColumns(listViewStudentList);
        }

        private void _loadListViewClassList(List<Dictionary<string, string>> classList) {
            listViewClassList.Items.Clear();

            foreach (var class_ in classList) {
                var item = new ListViewItem(class_["MaLop"]);
                item.SubItems.Add(class_["TenLop"]);
                item.SubItems.Add(class_["MaKhoa"]);
                listViewClassList.Items.Add(item);
            }

            _autoResizeListViewColumns(listViewClassList);
        }

        private void _loadListViewSubjectClassList(List<Dictionary<string, string>> subjectClassList) {
            listViewSubjectClassList.Items.Clear();

            foreach (var subjectClass in subjectClassList) {
                var item = new ListViewItem(subjectClass["MaLopHocPhan"]);
                item.SubItems.Add(subjectClass["TenLopHocPhan"]);
                item.SubItems.Add(subjectClass["MaKhoa"]);
                item.SubItems.Add(subjectClass["MaMonHoc"]);
                item.SubItems.Add(_db.getSubject(subjectClass["MaMonHoc"])["TenMonHoc"]);
                item.SubItems.Add(_getCountStudentSubjectClass(subjectClass["MaLopHocPhan"]));
                listViewSubjectClassList.Items.Add(item);
            }

            _autoResizeListViewColumns(listViewSubjectClassList);
        }

        private void _loadListViewSubjectClassListFSC(List<Dictionary<string, string>> subjectClassListFsc) {
            listViewSubjectClassListFSC.Items.Clear();

            foreach (var subjectClassFsc in subjectClassListFsc) {
                var item = new ListViewItem(subjectClassFsc["MaLopHocPhan"]);
                item.SubItems.Add(subjectClassFsc["TenLopHocPhan"]);
                item.SubItems.Add(subjectClassFsc["MaMonHoc"]);
                item.SubItems.Add(_db.getSubject(subjectClassFsc["MaMonHoc"])["TenMonHoc"]);
                item.SubItems.Add(_getCountStudentSubjectClass(subjectClassFsc["MaLopHocPhan"]));
                listViewSubjectClassListFSC.Items.Add(item);
            }

            _autoResizeListViewColumns(listViewSubjectClassListFSC);
        }

        private string _getFacultyID(string facultyName) {
            var facultyList = _db.getAllFaculties();
            foreach (var faculty in facultyList) {
                if (faculty["TenKhoa"] == facultyName) {
                    return faculty["MaKhoa"];
                }
            }

            return "";
        }

        private string _getSubjectID(string subjectName) {
            var subjectList = _db.getAllSubject();
            foreach (var subject in subjectList) {
                if (subject["TenMonHoc"] == subjectName) {
                    return subject["MaMonHoc"];
                }
            }

            return "";
        }

        private string _getClassID(string className) {
            var classList = _db.getAllClasses();
            foreach (var class_ in classList) {
                if (class_["TenLop"] == className) {
                    return class_["MaLop"];
                }
            }

            return "";
        }

        private string _getSubjectClassID(string subjectClassName) {
            var subjectClassList = _db.getAllSubjectClass();
            foreach (var subjectClass in subjectClassList) {
                if (subjectClass["TenLopHocPhan"] == subjectClassName) {
                    return subjectClass["MaLopHocPhan"];
                }
            }

            return "";
        }

        private string _getCountStudentClass(string classID) {
            var count = 0;
            foreach (var student in _db.getAllStudents()) {
                if (student["MaLop"] == classID) {
                    count++;
                }
            }

            return count.ToString();
        }

        private string _getCountStudentSubjectClass(string subjectClassId) {
            var count = 0;

            foreach (var subjectClass in _db.getAllSubjectClassStudents()) {
                if (subjectClass["MaLopHocPhan"] == subjectClassId) {
                    count++;
                }
            }

            return count.ToString();
        }

        private void btnAddClass_Click(object sender, EventArgs e) {
            if (txtClassID.Text != "" && txtClassName.Text != "" && comboBoxFacultyFClass.SelectedIndex != -1) {
                if (_db.getClass(txtClassID.Text) == null)
                    _ = _db.insertClass(txtClassID.Text, txtClassName.Text, _getFacultyID(comboBoxFacultyFClass.Text));
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 0) {
                _loadListViewClassList(_db.getAllClasses());
            } else if (tabControl1.SelectedIndex == 1) {
                _loadListViewSubjectClassListFSC(_db.getAllSubjectClass());
            } else if (tabControl1.SelectedIndex == 2) {
                _loadListViewSubjectClassList(_db.getAllSubjectClass());
            }
        }

        private void comboBoxFindFacultyFSC_SelectedIndexChanged(object sender, EventArgs e) {
            var subjectClassList = _db.getAllSubjectClass();

            var result = new List<Dictionary<string, string>>();

            foreach (var subjectClass in subjectClassList) {
                if (subjectClass["MaKhoa"] == _getFacultyID(comboBoxFindFacultyFSC.Text)) {
                    result.Add(subjectClass);
                }
            }

            _loadListViewSubjectClassListFSC(result);
        }

        private void comboBoxFacultyFSC_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxFacultyFSC.SelectedIndex != -1) {
                _loadComboBoxSubjectClass();
            }
        }

        private void btnAddSubjectClass_Click(object sender, EventArgs e) {
            if (txtSubjectClassID.Text != "" && comboBoxSubjectClassFSC.SelectedIndex != -1) {
                if (_db.getSubjectClass(txtSubjectClassID.Text) == null)
                    _ = _db.insertSubjectClass(txtSubjectClassID.Text, txtNameSubjectClass.Text, _getFacultyID(comboBoxFacultyFSC.Text), _getSubjectID(comboBoxSubjectClassFSC.Text));
            }
        }

        private void listViewSubjectClassListFSC_SelectedIndexChanged(object sender, EventArgs e) {
            btnDeleteSubjectClass.Enabled = true;
            if (listViewSubjectClassListFSC.SelectedItems.Count == 1) {
                btnEditSubjectClassFSB.Enabled = true;
                txtSubjectClassID.Text = listViewSubjectClassListFSC.SelectedItems[0].SubItems[0].Text;
                txtNameSubjectClass.Text = listViewSubjectClassListFSC.SelectedItems[0].SubItems[1].Text;
                foreach (var faculty in comboBoxFacultyFSC.Items) {
                    if (faculty.ToString() == _db.getFaculty(_db.getSubject(listViewSubjectClassListFSC.SelectedItems[0].SubItems[2].Text)["MaKhoa"])["TenKhoa"]) {
                        comboBoxFacultyFSC.SelectedItem = faculty;
                    }
                }
                foreach (var subject in comboBoxSubjectClassFSC.Items) {
                    if (subject.ToString() == _db.getSubject(listViewSubjectClassListFSC.SelectedItems[0].SubItems[2].Text)["TenMonHoc"]) {
                        comboBoxSubjectClassFSC.SelectedItem = subject;
                    }
                }
            } else {
                btnEditSubjectClassFSB.Enabled = true;

            }
        }

        private void btnEditSubjectClassFSB_Click(object sender, EventArgs e) {
            if (txtSubjectClassID.Text != "" && comboBoxSubjectClassFSC.SelectedIndex != -1) {
                _ = _db.insertSubjectClass(txtSubjectClassID.Text, txtNameSubjectClass.Text, _getFacultyID(comboBoxFacultyFSC.Text), _getSubjectID(comboBoxSubjectClassFSC.Text));
            }

            txtSubjectClassID.Text = "";
            txtNameSubjectClass.Text = "";
            comboBoxFacultyFSC.SelectedIndex = -1;
            comboBoxSubjectClassFSC.SelectedIndex = -1;
        }

        private void btnDeleteSubjectClass_Click(object sender, EventArgs e) {
            if (listViewSubjectClassListFSC.SelectedItems.Count == 1) {
                _ = _db.removeSubjectClass(listViewSubjectClassListFSC.SelectedItems[0].SubItems[0].Text);
            } else if (listViewSubjectClassListFSC.SelectedItems.Count > 1) {
                foreach (ListViewItem item in listViewSubjectClassListFSC.SelectedItems) {
                    _ = _db.removeSubjectClass(listViewSubjectClassListFSC.SelectedItems[0].SubItems[0].Text);
                }
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e) {
            if (txtClassID.Text != "" && txtClassName.Text != "" && comboBoxFacultyFClass.SelectedIndex != -1) {
                _ = _db.insertClass(txtClassID.Text, txtClassName.Text, _getFacultyID(comboBoxFacultyFClass.Text));
            }

            txtClassID.Text = "";
            txtClassName.Text = "";
            comboBoxFacultyFClass.SelectedIndex = -1;
        }

        private void btnDeleteClass_Click(object sender, EventArgs e) {
            if (listViewClassList.SelectedItems.Count == 1) {
                _ = _db.removeClass(listViewClassList.SelectedItems[0].SubItems[0].Text);
            } else if (listViewClassList.SelectedItems.Count > 1) {
                foreach (ListViewItem item in listViewClassList.SelectedItems) {
                    _ = _db.removeClass(listViewClassList.SelectedItems[0].SubItems[0].Text);
                }
            }
        }

        private void listViewClassList_SelectedIndexChanged(object sender, EventArgs e) {
            btnDeleteClass.Enabled = true;
            if (listViewClassList.SelectedItems.Count == 1) {
                btnEditClass.Enabled = true;
                txtClassID.Text = listViewClassList.SelectedItems[0].SubItems[0].Text;
                txtClassName.Text = listViewClassList.SelectedItems[0].SubItems[1].Text;
                foreach (var faculty in comboBoxFacultyFClass.Items) {
                    if (faculty.ToString() == _db.getFaculty(listViewClassList.SelectedItems[0].SubItems[2].Text)["TenKhoa"]) {
                        comboBoxFacultyFClass.SelectedItem = faculty;
                    }
                }
            } else {
                btnEditClass.Enabled = false;
            }
        }

        private void comboBoxFindFaculty_SelectedIndexChanged(object sender, EventArgs e) {

            var result = new List<Dictionary<string, string>>();
            foreach (var subjectClass in _db.getAllSubjectClass()) {
                if (subjectClass["MaKhoa"] == _getFacultyID(comboBoxFindFaculty.Text)) {
                    result.Add(subjectClass);
                }
            }

            _loadListViewSubjectClassList(result);
        }

        private void listViewSubjectClassList_SelectedIndexChanged(object sender, EventArgs e) {
            if (listViewSubjectClassList.SelectedItems.Count == 1) {
                var result = new List<Dictionary<string, string>>();
                foreach (var subjectClass in _db.getAllSubjectClassStudents()) {
                    if (subjectClass["MaLopHocPhan"] == listViewSubjectClassList.SelectedItems[0].SubItems[0].Text) {
                        result.Add(_db.getStudent(subjectClass["MaSinhVien"]));
                    }
                }


                _loadListViewStudentList(result);
            }
        }

        private void btnAddStudentID_Click(object sender, EventArgs e) {
            if (txtFindStudentID.Text != "" && listViewSubjectClassList.SelectedItems.Count == 1) {
                if (_db.getStudent(txtFindStudentID.Text) != null) {
                    _ = _db.insertSubjectClassStudent(txtFindStudentID.Text, listViewSubjectClassList.SelectedItems[0].Text);
                }
            }

            var result = new List<Dictionary<string, string>>();
            foreach (var subjectClass in _db.getAllSubjectClassStudents()) {
                if (subjectClass["MaLopHocPhan"] == listViewSubjectClassList.SelectedItems[0].SubItems[0].Text) {
                    result.Add(_db.getStudent(subjectClass["MaSinhVien"]));
                }
            }

            _loadListViewStudentList(result);

        }

        private void btnAddAllStudent_Click(object sender, EventArgs e) {
            if (txtFindClassID.Text != "") {
                //them tat ca sinh vien vao lop hoc phan
                foreach (var student in _db.getAllStudents()) {
                    if (student["MaLop"] == txtFindClassID.Text) {
                        _ = _db.insertSubjectClassStudent(student["MaSinhVien"], listViewSubjectClassList.SelectedItems[0].Text);
                    }
                }
            }

            var result = new List<Dictionary<string, string>>();
            foreach (var subjectClass in _db.getAllSubjectClassStudents()) {
                if (subjectClass["MaLopHocPhan"] == listViewSubjectClassList.SelectedItems[0].SubItems[0].Text) {
                    result.Add(_db.getStudent(subjectClass["MaSinhVien"]));
                }
            }
            _loadListViewStudentList(result);
        }

        private void btnDeleteAllStudentID_Click(object sender, EventArgs e) {
            if (txtFindClassID.Text != "") {
                foreach(var subjectClassStudent in _db.getAllSubjectClassStudents()) {
                    if (subjectClassStudent["MaLopHocPhan"] == listViewSubjectClassList.SelectedItems[0].SubItems[0].Text) {
                        _ = _db.removeSubjectClassStudent(subjectClassStudent["MaSinhVien"], subjectClassStudent["MaLopHocPhan"]);
                    }
                }
            }

            var result = new List<Dictionary<string, string>>();
            foreach (var subjectClass in _db.getAllSubjectClassStudents()) {
                if (subjectClass["MaLopHocPhan"] == listViewSubjectClassList.SelectedItems[0].SubItems[0].Text) {
                    result.Add(_db.getStudent(subjectClass["MaSinhVien"]));
                }
            }

            _loadListViewStudentList(result);
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _loadListViewClassList(_db.getAllClasses());
        }

        private void btnReturnMenu_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnRefreshFSC_Click(object sender, EventArgs e) {
            _loadListViewSubjectClassListFSC(_db.getAllSubjectClass());
        }

        private void cbbTimTheoKhoa_SelectedIndexChanged(object sender, EventArgs e) {
            var result = new List<Dictionary<string, string>>();

            foreach (var itemClass in _db.getAllClasses()) {
                if (itemClass["MaKhoa"] == _getFacultyID(cbbTimTheoKhoa.Text)) {
                    result.Add(itemClass);
                }
            }

            _loadListViewClassList(result);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (listViewStudentList.SelectedItems.Count == 1) {
                _ = _db.removeSubjectClassStudent(txtFindStudentID.Text, listViewSubjectClassList.SelectedItems[0].Text);


                //Lay danh sach sinh vin trong lop hoc phan
                var result = new List<Dictionary<string, string>>();
                foreach (var subjectClass in _db.getAllSubjectClassStudents()) {
                    if (subjectClass["MaLopHocPhan"] == listViewSubjectClassList.SelectedItems[0].SubItems[0].Text) {
                        result.Add(_db.getStudent(subjectClass["MaSinhVien"]));
                    }
                }

                _loadListViewStudentList(result);
            }
        }
    }
}