using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace studentManagement {
    public partial class subjectForm : Form {
        public subjectForm() {
            InitializeComponent();
            loadAllFaculty();
            createColumsListViewAddScore();
            createColumsListViewDisplaySubject();
        }

        private Database db = new Database("Data Source=ltwin_test.db");
        private bool isEditing = false; // Add a class-level variable to keep track of the state

        private bool isSubjectAndSubjectClass = true;

        private void AutoResizeListViewColumns(System.Windows.Forms.ListView listView) {
            foreach (System.Windows.Forms.ColumnHeader column in listView.Columns) {
                column.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
                //column.Width = -1;
                //column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
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
            }
            else {
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
            clearSelectedComboBoxAndListView();
            isSubjectAndSubjectClass = false;
        }

        private void btnAddSubjectAddScore_Click(object sender, EventArgs e) {
            addSubjectForm(0);
            addScoreForm(1);
            clearSelectedComboBoxAndListView();
            isSubjectAndSubjectClass = true;
        }

        private void btnAddScore_Click(object sender, EventArgs e) {
            addScoreForm(0);
            addSubjectForm(1);
        }

        //lay DS diem mon hoc
        private void loadAllFaculty() {
            var faculties = db.getAllFaculties();
            foreach (var faculty in faculties) {
                comboBoxFaculty.Items.Add(faculty["TenKhoa"]);
                comboBox1.Items.Add(faculty["TenKhoa"]);
                comboBox2.Items.Add(faculty["TenKhoa"]);
            }
        }

        private void loadSubject() {
            comboBoxSubject.Items.Clear();
            var subject = db.getAllSubject();

            foreach (var row in subject) {
                foreach( var faculty in row) {
                    Console.WriteLine(faculty);
                }
                //if (comboBoxFaculty.SelectedItem.ToString() == row["TenKhoa"].ToString()) {
                    //comboBoxSubject.Items.Add(row["MaMonHoc"]);
                   // listViewDisplaySubject.Items.Add(new ListViewItem(new[] { row["MaMonHoc"].ToString(), row["TenMonHoc"].ToString() }));
               // }
            }
            comboBoxClass.Items.Clear();
        }

        private void loadSubjectClass() {
            var subjectClass = db.getAllSubjectClass();

            foreach (var row in subjectClass) {
                if (comboBoxSubject.SelectedItem.ToString() == row["MaMonHoc"]) {
                    comboBoxClass.Items.Add(row["TenLopHocPhan"]);
                }
            }
        }

        private void createColumsListViewAddScore() {
            listViewAddScore.View = View.Details;
            listViewAddScore.FullRowSelect = true;
            listViewAddScore.GridLines = true;
            listViewAddScore.Columns.Add("Mã Sinh Viên", 100);
            listViewAddScore.Columns.Add("Họ Tên", 100);
            listViewAddScore.Columns.Add("Mã Lớp", 100);
            listViewAddScore.Columns.Add("Điểm", 100);
        }

        private void createColumsListViewDisplaySubject() {
            listViewDisplaySubject.View = View.Details;
            listViewDisplaySubject.FullRowSelect = true;
            listViewDisplaySubject.GridLines = true;
            listViewDisplaySubject.Columns.Add("Mã Môn Học", 100);
            listViewDisplaySubject.Columns.Add("Tên Môn Học", 100);
        }

        private void loadListViewAddScore() {
            listViewAddScore.Items.Clear();

            var students = db.getAllStudentClasses();
            foreach (var row in students) {
                var item = new ListViewItem(row["MaSinhVien"].ToString());
                var student = db.getStudent(row["MaSinhVien"].ToString());
                item.SubItems.Add(student["HoTen"].ToString());
                item.SubItems.Add(student["MaLop"].ToString());
                listViewAddScore.Items.Add(item);
            }
            AutoResizeListViewColumns(listViewAddScore);
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e) {
            comboBoxClass.Items.Clear();
            loadSubjectClass();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e) {
            loadSubject();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            loadListViewAddScore();
        }

        private void listViewAddScore_SelectedIndexChanged(object sender, EventArgs e) {
            txtStudentName.Text = listViewAddScore.SelectedItems[0].SubItems[1].Text;
            txtMssvAddScore.Text = listViewAddScore.SelectedItems[0].SubItems[0].Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            listViewDisplaySubject.Items.Clear();
            loadSubject();
        }

        private void clearSelectedComboBoxAndListView() {
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
        }
    }
}
