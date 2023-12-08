using System.ComponentModel;
using System.Windows.Forms;

namespace studentManagement {
    partial class ClassForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.listViewClassList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTimTheoKhoa = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFindClassSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBoxFacultyFClass = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReturnMenuSubjectClass = new System.Windows.Forms.Button();
            this.listViewSubjectClassListFSC = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxFindFacultyFSC = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFindSubjectClassFSC = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxSubjectClassFSC = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteSubjectClass = new System.Windows.Forms.Button();
            this.btnAddSubjectClass = new System.Windows.Forms.Button();
            this.btnEditSubjectClassFSB = new System.Windows.Forms.Button();
            this.btnRefreshFSC = new System.Windows.Forms.Button();
            this.comboBoxFacultyFSC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameSubjectClass = new System.Windows.Forms.TextBox();
            this.txtSubjectClassID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFindStudentID = new System.Windows.Forms.TextBox();
            this.btnAddStudentID = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddAllStudent = new System.Windows.Forms.Button();
            this.btnDeleteAllStudentID = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFindClassID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxFindFaculty = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFindSubjectClass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listViewSubjectClassList = new System.Windows.Forms.ListView();
            this.listViewStudentList = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1172, 910);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.btnReturnMenu);
            this.tabPage1.Controls.Add(this.listViewClassList);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1164, 877);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm Lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // btnReturnMenu
            //
            this.btnReturnMenu.Location = new System.Drawing.Point(4, 54);
            this.btnReturnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(128, 46);
            this.btnReturnMenu.TabIndex = 9;
            this.btnReturnMenu.Text = "Trở về menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            //
            // listViewClassList
            //
            this.listViewClassList.HideSelection = false;
            this.listViewClassList.Location = new System.Drawing.Point(264, 138);
            this.listViewClassList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewClassList.Name = "listViewClassList";
            this.listViewClassList.Size = new System.Drawing.Size(898, 725);
            this.listViewClassList.TabIndex = 9;
            this.listViewClassList.UseCompatibleStateImageBehavior = false;
            this.listViewClassList.SelectedIndexChanged += new System.EventHandler(this.listViewClassList_SelectedIndexChanged);
            //
            // panel1
            //
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbTimTheoKhoa);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFindClassSubject);
            this.panel1.Location = new System.Drawing.Point(264, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 88);
            this.panel1.TabIndex = 8;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm";
            //
            // cbbTimTheoKhoa
            //
            this.cbbTimTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimTheoKhoa.FormattingEnabled = true;
            this.cbbTimTheoKhoa.Location = new System.Drawing.Point(523, 31);
            this.cbbTimTheoKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTimTheoKhoa.Name = "cbbTimTheoKhoa";
            this.cbbTimTheoKhoa.Size = new System.Drawing.Size(196, 33);
            this.cbbTimTheoKhoa.TabIndex = 4;
            this.cbbTimTheoKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheoKhoa_SelectedIndexChanged);
            //
            // label21
            //
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(26, 39);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 25);
            this.label21.TabIndex = 1;
            this.label21.Text = "Mã lớp:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khoa:";
            //
            // txtFindClassSubject
            //
            this.txtFindClassSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindClassSubject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindClassSubject.Location = new System.Drawing.Point(116, 35);
            this.txtFindClassSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindClassSubject.Name = "txtFindClassSubject";
            this.txtFindClassSubject.Size = new System.Drawing.Size(222, 30);
            this.txtFindClassSubject.TabIndex = 0;
            this.txtFindClassSubject.TextChanged += new System.EventHandler(this.txtFindClassSubject_TextChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(457, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý Lớp";
            //
            // panel2
            //
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteClass);
            this.panel2.Controls.Add(this.btnAddClass);
            this.panel2.Controls.Add(this.btnEditClass);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.comboBoxFacultyFClass);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtClassName);
            this.panel2.Controls.Add(this.txtClassID);
            this.panel2.Location = new System.Drawing.Point(4, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 726);
            this.panel2.TabIndex = 5;
            //
            // btnDeleteClass
            //
            this.btnDeleteClass.Enabled = false;
            this.btnDeleteClass.Location = new System.Drawing.Point(66, 504);
            this.btnDeleteClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(128, 56);
            this.btnDeleteClass.TabIndex = 30;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            //
            // btnAddClass
            //
            this.btnAddClass.Location = new System.Drawing.Point(66, 334);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(128, 56);
            this.btnAddClass.TabIndex = 29;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            //
            // btnEditClass
            //
            this.btnEditClass.Enabled = false;
            this.btnEditClass.Location = new System.Drawing.Point(66, 418);
            this.btnEditClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(128, 56);
            this.btnEditClass.TabIndex = 28;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(66, 251);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 56);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // comboBoxFacultyFClass
            //
            this.comboBoxFacultyFClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyFClass.FormattingEnabled = true;
            this.comboBoxFacultyFClass.Location = new System.Drawing.Point(66, 139);
            this.comboBoxFacultyFClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFacultyFClass.Name = "comboBoxFacultyFClass";
            this.comboBoxFacultyFClass.Size = new System.Drawing.Size(188, 33);
            this.comboBoxFacultyFClass.TabIndex = 26;
            //
            // label16
            //
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-1, 149);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Khoa:";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(287, 482);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.TabIndex = 14;
            //
            // label24
            //
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1, 85);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 25);
            this.label24.TabIndex = 2;
            this.label24.Text = "Tên Lớp:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Lớp:";
            //
            // txtClassName
            //
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(89, 81);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(166, 30);
            this.txtClassName.TabIndex = 3;
            //
            // txtClassID
            //
            this.txtClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(89, 25);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(166, 30);
            this.txtClassID.TabIndex = 3;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.btnReturnMenuSubjectClass);
            this.tabPage2.Controls.Add(this.listViewSubjectClassListFSC);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1164, 877);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Thêm Lớp Học Phần";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // btnReturnMenuSubjectClass
            //
            this.btnReturnMenuSubjectClass.Location = new System.Drawing.Point(2, 59);
            this.btnReturnMenuSubjectClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnMenuSubjectClass.Name = "btnReturnMenuSubjectClass";
            this.btnReturnMenuSubjectClass.Size = new System.Drawing.Size(128, 46);
            this.btnReturnMenuSubjectClass.TabIndex = 13;
            this.btnReturnMenuSubjectClass.Text = "Trở về menu";
            this.btnReturnMenuSubjectClass.UseVisualStyleBackColor = true;
            //
            // listViewSubjectClassListFSC
            //
            this.listViewSubjectClassListFSC.HideSelection = false;
            this.listViewSubjectClassListFSC.Location = new System.Drawing.Point(262, 142);
            this.listViewSubjectClassListFSC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewSubjectClassListFSC.Name = "listViewSubjectClassListFSC";
            this.listViewSubjectClassListFSC.Size = new System.Drawing.Size(898, 725);
            this.listViewSubjectClassListFSC.TabIndex = 14;
            this.listViewSubjectClassListFSC.UseCompatibleStateImageBehavior = false;
            this.listViewSubjectClassListFSC.SelectedIndexChanged += new System.EventHandler(this.listViewSubjectClassListFSC_SelectedIndexChanged);
            //
            // panel3
            //
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(262, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 88);
            this.panel3.TabIndex = 12;
            //
            // panel5
            //
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.comboBoxFindFacultyFSC);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.txtFindSubjectClassFSC);
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 88);
            this.panel5.TabIndex = 13;
            //
            // label22
            //
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 39);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 25);
            this.label22.TabIndex = 7;
            this.label22.Text = "Mã lớp học phần";
            //
            // label15
            //
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 30);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tìm kiếm";
            //
            // comboBoxFindFacultyFSC
            //
            this.comboBoxFindFacultyFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindFacultyFSC.FormattingEnabled = true;
            this.comboBoxFindFacultyFSC.Location = new System.Drawing.Point(585, 31);
            this.comboBoxFindFacultyFSC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFindFacultyFSC.Name = "comboBoxFindFacultyFSC";
            this.comboBoxFindFacultyFSC.Size = new System.Drawing.Size(196, 33);
            this.comboBoxFindFacultyFSC.TabIndex = 4;
            this.comboBoxFindFacultyFSC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindFacultyFSC_SelectedIndexChanged);
            //
            // label17
            //
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(508, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Khoa:";
            //
            // txtFindSubjectClassFSC
            //
            this.txtFindSubjectClassFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindSubjectClassFSC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindSubjectClassFSC.Location = new System.Drawing.Point(190, 35);
            this.txtFindSubjectClassFSC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindSubjectClassFSC.Name = "txtFindSubjectClassFSC";
            this.txtFindSubjectClassFSC.Size = new System.Drawing.Size(222, 30);
            this.txtFindSubjectClassFSC.TabIndex = 0;
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(760, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(620, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 56);
            this.button3.TabIndex = 7;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = true;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            //
            // comboBox1
            //
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(385, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 33);
            this.comboBox1.TabIndex = 4;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa:";
            //
            // textBox1
            //
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(42, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "nhập mã lớp";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(390, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(483, 55);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thêm Lớp Học Phần";
            //
            // panel4
            //
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comboBoxSubjectClassFSC);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnDeleteSubjectClass);
            this.panel4.Controls.Add(this.btnAddSubjectClass);
            this.panel4.Controls.Add(this.btnEditSubjectClassFSB);
            this.panel4.Controls.Add(this.btnRefreshFSC);
            this.panel4.Controls.Add(this.comboBoxFacultyFSC);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtNameSubjectClass);
            this.panel4.Controls.Add(this.txtSubjectClassID);
            this.panel4.Location = new System.Drawing.Point(2, 142);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 726);
            this.panel4.TabIndex = 10;
            //
            // comboBoxSubjectClassFSC
            //
            this.comboBoxSubjectClassFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectClassFSC.FormattingEnabled = true;
            this.comboBoxSubjectClassFSC.Location = new System.Drawing.Point(69, 182);
            this.comboBoxSubjectClassFSC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSubjectClassFSC.Name = "comboBoxSubjectClassFSC";
            this.comboBoxSubjectClassFSC.Size = new System.Drawing.Size(186, 33);
            this.comboBoxSubjectClassFSC.TabIndex = 32;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Môn:";
            //
            // btnDeleteSubjectClass
            //
            this.btnDeleteSubjectClass.Enabled = false;
            this.btnDeleteSubjectClass.Location = new System.Drawing.Point(69, 552);
            this.btnDeleteSubjectClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSubjectClass.Name = "btnDeleteSubjectClass";
            this.btnDeleteSubjectClass.Size = new System.Drawing.Size(128, 56);
            this.btnDeleteSubjectClass.TabIndex = 30;
            this.btnDeleteSubjectClass.Text = "Xóa";
            this.btnDeleteSubjectClass.UseVisualStyleBackColor = true;
            this.btnDeleteSubjectClass.Click += new System.EventHandler(this.btnDeleteSubjectClass_Click);
            //
            // btnAddSubjectClass
            //
            this.btnAddSubjectClass.Location = new System.Drawing.Point(69, 365);
            this.btnAddSubjectClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSubjectClass.Name = "btnAddSubjectClass";
            this.btnAddSubjectClass.Size = new System.Drawing.Size(128, 56);
            this.btnAddSubjectClass.TabIndex = 29;
            this.btnAddSubjectClass.Text = "Thêm";
            this.btnAddSubjectClass.UseVisualStyleBackColor = true;
            this.btnAddSubjectClass.Click += new System.EventHandler(this.btnAddSubjectClass_Click);
            //
            // btnEditSubjectClassFSB
            //
            this.btnEditSubjectClassFSB.Enabled = false;
            this.btnEditSubjectClassFSB.Location = new System.Drawing.Point(69, 460);
            this.btnEditSubjectClassFSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSubjectClassFSB.Name = "btnEditSubjectClassFSB";
            this.btnEditSubjectClassFSB.Size = new System.Drawing.Size(128, 56);
            this.btnEditSubjectClassFSB.TabIndex = 28;
            this.btnEditSubjectClassFSB.Text = "Sửa";
            this.btnEditSubjectClassFSB.UseVisualStyleBackColor = true;
            this.btnEditSubjectClassFSB.Click += new System.EventHandler(this.btnEditSubjectClassFSB_Click);
            //
            // btnRefreshFSC
            //
            this.btnRefreshFSC.Location = new System.Drawing.Point(69, 269);
            this.btnRefreshFSC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshFSC.Name = "btnRefreshFSC";
            this.btnRefreshFSC.Size = new System.Drawing.Size(128, 56);
            this.btnRefreshFSC.TabIndex = 27;
            this.btnRefreshFSC.Text = "Làm Mới";
            this.btnRefreshFSC.UseVisualStyleBackColor = true;
            this.btnRefreshFSC.Click += new System.EventHandler(this.btnRefreshFSC_Click);
            //
            // comboBoxFacultyFSC
            //
            this.comboBoxFacultyFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyFSC.FormattingEnabled = true;
            this.comboBoxFacultyFSC.Location = new System.Drawing.Point(66, 129);
            this.comboBoxFacultyFSC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFacultyFSC.Name = "comboBoxFacultyFSC";
            this.comboBoxFacultyFSC.Size = new System.Drawing.Size(188, 33);
            this.comboBoxFacultyFSC.TabIndex = 26;
            this.comboBoxFacultyFSC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultyFSC_SelectedIndexChanged);
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Khoa:";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 482);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 14;
            //
            // label23
            //
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 85);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "Tên lớp:";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Lớp:";
            //
            // txtNameSubjectClass
            //
            this.txtNameSubjectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSubjectClass.Location = new System.Drawing.Point(88, 81);
            this.txtNameSubjectClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameSubjectClass.Name = "txtNameSubjectClass";
            this.txtNameSubjectClass.Size = new System.Drawing.Size(167, 30);
            this.txtNameSubjectClass.TabIndex = 3;
            //
            // txtSubjectClassID
            //
            this.txtSubjectClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectClassID.Location = new System.Drawing.Point(89, 25);
            this.txtSubjectClassID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubjectClassID.Name = "txtSubjectClassID";
            this.txtSubjectClassID.Size = new System.Drawing.Size(166, 30);
            this.txtSubjectClassID.TabIndex = 3;
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.listViewSubjectClassList);
            this.tabPage3.Controls.Add(this.listViewStudentList);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1164, 877);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Thêm Sinh Viên Vào Lớp";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // panel7
            //
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtFindStudentID);
            this.panel7.Controls.Add(this.btnAddStudentID);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnAddAllStudent);
            this.panel7.Controls.Add(this.btnDeleteAllStudentID);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.txtFindClassID);
            this.panel7.Location = new System.Drawing.Point(501, 21);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(656, 158);
            this.panel7.TabIndex = 15;
            //
            // txtFindStudentID
            //
            this.txtFindStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindStudentID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindStudentID.Location = new System.Drawing.Point(163, 92);
            this.txtFindStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindStudentID.Name = "txtFindStudentID";
            this.txtFindStudentID.Size = new System.Drawing.Size(214, 30);
            this.txtFindStudentID.TabIndex = 11;
            //
            // btnAddStudentID
            //
            this.btnAddStudentID.Location = new System.Drawing.Point(425, 82);
            this.btnAddStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStudentID.Name = "btnAddStudentID";
            this.btnAddStudentID.Size = new System.Drawing.Size(104, 56);
            this.btnAddStudentID.TabIndex = 10;
            this.btnAddStudentID.Text = "Thêm sinh viên";
            this.btnAddStudentID.UseVisualStyleBackColor = true;
            this.btnAddStudentID.Click += new System.EventHandler(this.btnAddStudentID_Click);
            //
            // label27
            //
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(24, 96);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(130, 25);
            this.label27.TabIndex = 1;
            this.label27.Text = "Mã Sinh Viên";
            //
            // label26
            //
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(24, 41);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 25);
            this.label26.TabIndex = 1;
            this.label26.Text = "Mã lớp";
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(425, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 56);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnAddAllStudent
            //
            this.btnAddAllStudent.Location = new System.Drawing.Point(536, 82);
            this.btnAddAllStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAllStudent.Name = "btnAddAllStudent";
            this.btnAddAllStudent.Size = new System.Drawing.Size(104, 56);
            this.btnAddAllStudent.TabIndex = 8;
            this.btnAddAllStudent.Text = "Thêm Tất Cả";
            this.btnAddAllStudent.UseVisualStyleBackColor = true;
            this.btnAddAllStudent.Click += new System.EventHandler(this.btnAddAllStudent_Click);
            //
            // btnDeleteAllStudentID
            //
            this.btnDeleteAllStudentID.Location = new System.Drawing.Point(536, 19);
            this.btnDeleteAllStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAllStudentID.Name = "btnDeleteAllStudentID";
            this.btnDeleteAllStudentID.Size = new System.Drawing.Size(104, 56);
            this.btnDeleteAllStudentID.TabIndex = 7;
            this.btnDeleteAllStudentID.Text = "Xóa Tất cả";
            this.btnDeleteAllStudentID.UseVisualStyleBackColor = true;
            this.btnDeleteAllStudentID.Click += new System.EventHandler(this.btnDeleteAllStudentID_Click);
            //
            // label20
            //
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 30);
            this.label20.TabIndex = 6;
            this.label20.Text = "Chọn Sinh Viên";
            //
            // txtFindClassID
            //
            this.txtFindClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindClassID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindClassID.Location = new System.Drawing.Point(163, 38);
            this.txtFindClassID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindClassID.Name = "txtFindClassID";
            this.txtFindClassID.Size = new System.Drawing.Size(214, 30);
            this.txtFindClassID.TabIndex = 0;
            //
            // panel6
            //
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.comboBoxFindFaculty);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.txtFindSubjectClass);
            this.panel6.Location = new System.Drawing.Point(10, 20);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 158);
            this.panel6.TabIndex = 14;
            //
            // label18
            //
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 30);
            this.label18.TabIndex = 6;
            this.label18.Text = "Tìm kiếm";
            //
            // comboBoxFindFaculty
            //
            this.comboBoxFindFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindFaculty.FormattingEnabled = true;
            this.comboBoxFindFaculty.Location = new System.Drawing.Point(82, 96);
            this.comboBoxFindFaculty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFindFaculty.Name = "comboBoxFindFaculty";
            this.comboBoxFindFaculty.Size = new System.Drawing.Size(196, 33);
            this.comboBoxFindFaculty.TabIndex = 4;
            this.comboBoxFindFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindFaculty_SelectedIndexChanged);
            //
            // label25
            //
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 51);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 25);
            this.label25.TabIndex = 1;
            this.label25.Text = "Mã Lớp:";
            //
            // label19
            //
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 104);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "Khoa:";
            //
            // txtFindSubjectClass
            //
            this.txtFindSubjectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindSubjectClass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindSubjectClass.Location = new System.Drawing.Point(82, 44);
            this.txtFindSubjectClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindSubjectClass.Name = "txtFindSubjectClass";
            this.txtFindSubjectClass.Size = new System.Drawing.Size(268, 30);
            this.txtFindSubjectClass.TabIndex = 0;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.Location = new System.Drawing.Point(709, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 29);
            this.label14.TabIndex = 13;
            this.label14.Text = "Danh sách sinh viên";
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(101, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 29);
            this.label13.TabIndex = 12;
            this.label13.Text = "Danh sách lớp học phần";
            //
            // listViewSubjectClassList
            //
            this.listViewSubjectClassList.HideSelection = false;
            this.listViewSubjectClassList.Location = new System.Drawing.Point(-4, 224);
            this.listViewSubjectClassList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewSubjectClassList.Name = "listViewSubjectClassList";
            this.listViewSubjectClassList.Size = new System.Drawing.Size(498, 649);
            this.listViewSubjectClassList.TabIndex = 11;
            this.listViewSubjectClassList.UseCompatibleStateImageBehavior = false;
            this.listViewSubjectClassList.SelectedIndexChanged += new System.EventHandler(this.listViewSubjectClassList_SelectedIndexChanged);
            //
            // listViewStudentList
            //
            this.listViewStudentList.HideSelection = false;
            this.listViewStudentList.Location = new System.Drawing.Point(503, 224);
            this.listViewStudentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewStudentList.Name = "listViewStudentList";
            this.listViewStudentList.Size = new System.Drawing.Size(660, 649);
            this.listViewStudentList.TabIndex = 10;
            this.listViewStudentList.UseCompatibleStateImageBehavior = false;
            //
            // ClassForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 910);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClassForm";
            this.Text = "classForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Panel panel1;
        private ComboBox cbbTimTheoKhoa;
        private Label label3;
        private System.Windows.Forms.TextBox txtFindClassSubject;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBoxFacultyFClass;
        private Label label16;
        private Label label12;
        private Label label5;
        private TextBox txtClassID;
        private TabPage tabPage2;
        private System.Windows.Forms.ListView listViewClassList;
        private Button btnReturnMenu;
        private Button btnDeleteClass;
        private Button btnAddClass;
        private Button btnEditClass;
        private Button btnRefresh;
        private Button btnReturnMenuSubjectClass;
        private ListView listViewSubjectClassListFSC;
        private Panel panel3;
        private Button button2;
        private Button button3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Panel panel4;
        private Button btnDeleteSubjectClass;
        private Button btnAddSubjectClass;
        private Button btnEditSubjectClassFSB;
        private Button btnRefreshFSC;
        private ComboBox comboBoxFacultyFSC;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtSubjectClassID;
        private ComboBox comboBoxSubjectClassFSC;
        private Label label11;
        private TabPage tabPage3;
        private Label label13;
        private ListView listViewSubjectClassList;
        private ListView listViewStudentList;
        private Label label14;
        private Panel panel5;
        private Label label15;
        private ComboBox comboBoxFindFacultyFSC;
        private Label label17;
        private TextBox txtFindSubjectClassFSC;
        private Panel panel6;
        private Label label18;
        private ComboBox comboBoxFindFaculty;
        private Label label19;
        private TextBox txtFindSubjectClass;
        private Panel panel7;
        private Button btnAddAllStudent;
        private Button btnDeleteAllStudentID;
        private Label label20;
        private TextBox txtFindClassID;
        private Button btnAddStudentID;
        private Button btnDelete;
        private TextBox txtFindStudentID;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtNameSubjectClass;
        private Label label24;
        private TextBox txtClassName;
        private Label label25;
        private Label label26;
        private Label label27;
    }
}