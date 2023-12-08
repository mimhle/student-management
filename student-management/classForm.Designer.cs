using System.Data;
namespace studentManagement {
    partial class ClassForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 728);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1034, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm Lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(4, 43);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(114, 37);
            this.btnReturnMenu.TabIndex = 9;
            this.btnReturnMenu.Text = "Trở về menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // listViewClassList
            // 
            this.listViewClassList.HideSelection = false;
            this.listViewClassList.Location = new System.Drawing.Point(235, 110);
            this.listViewClassList.Name = "listViewClassList";
            this.listViewClassList.Size = new System.Drawing.Size(799, 581);
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
            this.panel1.Location = new System.Drawing.Point(235, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 71);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm";
            // 
            // cbbTimTheoKhoa
            // 
            this.cbbTimTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimTheoKhoa.FormattingEnabled = true;
            this.cbbTimTheoKhoa.Location = new System.Drawing.Point(465, 25);
            this.cbbTimTheoKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTimTheoKhoa.Name = "cbbTimTheoKhoa";
            this.cbbTimTheoKhoa.Size = new System.Drawing.Size(175, 28);
            this.cbbTimTheoKhoa.TabIndex = 4;
            this.cbbTimTheoKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheoKhoa_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 31);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khoa:";
            // 
            // txtFindClassSubject
            // 
            this.txtFindClassSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindClassSubject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindClassSubject.Location = new System.Drawing.Point(103, 28);
            this.txtFindClassSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindClassSubject.Name = "txtFindClassSubject";
            this.txtFindClassSubject.Size = new System.Drawing.Size(198, 26);
            this.txtFindClassSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(406, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
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
            this.panel2.Location = new System.Drawing.Point(4, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 581);
            this.panel2.TabIndex = 5;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Enabled = false;
            this.btnDeleteClass.Location = new System.Drawing.Point(59, 403);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(114, 45);
            this.btnDeleteClass.TabIndex = 30;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(59, 267);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(114, 45);
            this.btnAddClass.TabIndex = 29;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Enabled = false;
            this.btnEditClass.Location = new System.Drawing.Point(59, 334);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(114, 45);
            this.btnEditClass.TabIndex = 28;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(59, 201);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 45);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboBoxFacultyFClass
            // 
            this.comboBoxFacultyFClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyFClass.FormattingEnabled = true;
            this.comboBoxFacultyFClass.Location = new System.Drawing.Point(59, 111);
            this.comboBoxFacultyFClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFacultyFClass.Name = "comboBoxFacultyFClass";
            this.comboBoxFacultyFClass.Size = new System.Drawing.Size(168, 28);
            this.comboBoxFacultyFClass.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-1, 119);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Khoa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(255, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1, 68);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 20);
            this.label24.TabIndex = 2;
            this.label24.Text = "Tên Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Lớp:";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(79, 65);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(148, 26);
            this.txtClassName.TabIndex = 3;
            // 
            // txtClassID
            // 
            this.txtClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(79, 20);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(148, 26);
            this.txtClassID.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReturnMenuSubjectClass);
            this.tabPage2.Controls.Add(this.listViewSubjectClassListFSC);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1034, 699);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Thêm Lớp Học Phần";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReturnMenuSubjectClass
            // 
            this.btnReturnMenuSubjectClass.Location = new System.Drawing.Point(2, 47);
            this.btnReturnMenuSubjectClass.Name = "btnReturnMenuSubjectClass";
            this.btnReturnMenuSubjectClass.Size = new System.Drawing.Size(114, 37);
            this.btnReturnMenuSubjectClass.TabIndex = 13;
            this.btnReturnMenuSubjectClass.Text = "Trở về menu";
            this.btnReturnMenuSubjectClass.UseVisualStyleBackColor = true;
            // 
            // listViewSubjectClassListFSC
            // 
            this.listViewSubjectClassListFSC.HideSelection = false;
            this.listViewSubjectClassListFSC.Location = new System.Drawing.Point(233, 114);
            this.listViewSubjectClassListFSC.Name = "listViewSubjectClassListFSC";
            this.listViewSubjectClassListFSC.Size = new System.Drawing.Size(799, 581);
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
            this.panel3.Location = new System.Drawing.Point(233, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 71);
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
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(799, 71);
            this.panel5.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(17, 31);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 20);
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
            this.label15.Size = new System.Drawing.Size(101, 26);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tìm kiếm";
            // 
            // comboBoxFindFacultyFSC
            // 
            this.comboBoxFindFacultyFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindFacultyFSC.FormattingEnabled = true;
            this.comboBoxFindFacultyFSC.Location = new System.Drawing.Point(520, 25);
            this.comboBoxFindFacultyFSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFindFacultyFSC.Name = "comboBoxFindFacultyFSC";
            this.comboBoxFindFacultyFSC.Size = new System.Drawing.Size(175, 28);
            this.comboBoxFindFacultyFSC.TabIndex = 4;
            this.comboBoxFindFacultyFSC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindFacultyFSC_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(452, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Khoa:";
            // 
            // txtFindSubjectClassFSC
            // 
            this.txtFindSubjectClassFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindSubjectClassFSC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindSubjectClassFSC.Location = new System.Drawing.Point(169, 28);
            this.txtFindSubjectClassFSC.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindSubjectClassFSC.Name = "txtFindSubjectClassFSC";
            this.txtFindSubjectClassFSC.Size = new System.Drawing.Size(198, 26);
            this.txtFindSubjectClassFSC.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 45);
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
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(37, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "nhập mã lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(347, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(404, 46);
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
            this.panel4.Location = new System.Drawing.Point(2, 114);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 581);
            this.panel4.TabIndex = 10;
            // 
            // comboBoxSubjectClassFSC
            // 
            this.comboBoxSubjectClassFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectClassFSC.FormattingEnabled = true;
            this.comboBoxSubjectClassFSC.Location = new System.Drawing.Point(61, 146);
            this.comboBoxSubjectClassFSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSubjectClassFSC.Name = "comboBoxSubjectClassFSC";
            this.comboBoxSubjectClassFSC.Size = new System.Drawing.Size(166, 28);
            this.comboBoxSubjectClassFSC.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Môn:";
            // 
            // btnDeleteSubjectClass
            // 
            this.btnDeleteSubjectClass.Enabled = false;
            this.btnDeleteSubjectClass.Location = new System.Drawing.Point(61, 442);
            this.btnDeleteSubjectClass.Name = "btnDeleteSubjectClass";
            this.btnDeleteSubjectClass.Size = new System.Drawing.Size(114, 45);
            this.btnDeleteSubjectClass.TabIndex = 30;
            this.btnDeleteSubjectClass.Text = "Xóa";
            this.btnDeleteSubjectClass.UseVisualStyleBackColor = true;
            this.btnDeleteSubjectClass.Click += new System.EventHandler(this.btnDeleteSubjectClass_Click);
            // 
            // btnAddSubjectClass
            // 
            this.btnAddSubjectClass.Location = new System.Drawing.Point(61, 292);
            this.btnAddSubjectClass.Name = "btnAddSubjectClass";
            this.btnAddSubjectClass.Size = new System.Drawing.Size(114, 45);
            this.btnAddSubjectClass.TabIndex = 29;
            this.btnAddSubjectClass.Text = "Thêm";
            this.btnAddSubjectClass.UseVisualStyleBackColor = true;
            this.btnAddSubjectClass.Click += new System.EventHandler(this.btnAddSubjectClass_Click);
            // 
            // btnEditSubjectClassFSB
            // 
            this.btnEditSubjectClassFSB.Enabled = false;
            this.btnEditSubjectClassFSB.Location = new System.Drawing.Point(61, 368);
            this.btnEditSubjectClassFSB.Name = "btnEditSubjectClassFSB";
            this.btnEditSubjectClassFSB.Size = new System.Drawing.Size(114, 45);
            this.btnEditSubjectClassFSB.TabIndex = 28;
            this.btnEditSubjectClassFSB.Text = "Sửa";
            this.btnEditSubjectClassFSB.UseVisualStyleBackColor = true;
            this.btnEditSubjectClassFSB.Click += new System.EventHandler(this.btnEditSubjectClassFSB_Click);
            // 
            // btnRefreshFSC
            // 
            this.btnRefreshFSC.Location = new System.Drawing.Point(61, 215);
            this.btnRefreshFSC.Name = "btnRefreshFSC";
            this.btnRefreshFSC.Size = new System.Drawing.Size(114, 45);
            this.btnRefreshFSC.TabIndex = 27;
            this.btnRefreshFSC.Text = "Làm Mới";
            this.btnRefreshFSC.UseVisualStyleBackColor = true;
            this.btnRefreshFSC.Click += new System.EventHandler(this.btnRefreshFSC_Click);
            // 
            // comboBoxFacultyFSC
            // 
            this.comboBoxFacultyFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyFSC.FormattingEnabled = true;
            this.comboBoxFacultyFSC.Location = new System.Drawing.Point(59, 103);
            this.comboBoxFacultyFSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFacultyFSC.Name = "comboBoxFacultyFSC";
            this.comboBoxFacultyFSC.Size = new System.Drawing.Size(168, 28);
            this.comboBoxFacultyFSC.TabIndex = 26;
            this.comboBoxFacultyFSC.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultyFSC_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Khoa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 68);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "Tên lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Lớp:";
            // 
            // txtNameSubjectClass
            // 
            this.txtNameSubjectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSubjectClass.Location = new System.Drawing.Point(78, 65);
            this.txtNameSubjectClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSubjectClass.Name = "txtNameSubjectClass";
            this.txtNameSubjectClass.Size = new System.Drawing.Size(149, 26);
            this.txtNameSubjectClass.TabIndex = 3;
            // 
            // txtSubjectClassID
            // 
            this.txtSubjectClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectClassID.Location = new System.Drawing.Point(79, 20);
            this.txtSubjectClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectClassID.Name = "txtSubjectClassID";
            this.txtSubjectClassID.Size = new System.Drawing.Size(148, 26);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1034, 699);
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
            this.panel7.Location = new System.Drawing.Point(445, 17);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(583, 127);
            this.panel7.TabIndex = 15;
            // 
            // txtFindStudentID
            // 
            this.txtFindStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindStudentID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindStudentID.Location = new System.Drawing.Point(145, 74);
            this.txtFindStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindStudentID.Name = "txtFindStudentID";
            this.txtFindStudentID.Size = new System.Drawing.Size(191, 26);
            this.txtFindStudentID.TabIndex = 11;
            // 
            // btnAddStudentID
            // 
            this.btnAddStudentID.Location = new System.Drawing.Point(378, 66);
            this.btnAddStudentID.Name = "btnAddStudentID";
            this.btnAddStudentID.Size = new System.Drawing.Size(92, 45);
            this.btnAddStudentID.TabIndex = 10;
            this.btnAddStudentID.Text = "Thêm sinh viên";
            this.btnAddStudentID.UseVisualStyleBackColor = true;
            this.btnAddStudentID.Click += new System.EventHandler(this.btnAddStudentID_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(21, 77);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 20);
            this.label27.TabIndex = 1;
            this.label27.Text = "Mã Sinh Viên";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(21, 33);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Mã lớp";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddAllStudent
            // 
            this.btnAddAllStudent.Location = new System.Drawing.Point(476, 66);
            this.btnAddAllStudent.Name = "btnAddAllStudent";
            this.btnAddAllStudent.Size = new System.Drawing.Size(92, 45);
            this.btnAddAllStudent.TabIndex = 8;
            this.btnAddAllStudent.Text = "Thêm Tất Cả";
            this.btnAddAllStudent.UseVisualStyleBackColor = true;
            this.btnAddAllStudent.Click += new System.EventHandler(this.btnAddAllStudent_Click);
            // 
            // btnDeleteAllStudentID
            // 
            this.btnDeleteAllStudentID.Location = new System.Drawing.Point(476, 15);
            this.btnDeleteAllStudentID.Name = "btnDeleteAllStudentID";
            this.btnDeleteAllStudentID.Size = new System.Drawing.Size(92, 45);
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
            this.label20.Size = new System.Drawing.Size(164, 26);
            this.label20.TabIndex = 6;
            this.label20.Text = "Chọn Sinh Viên";
            // 
            // txtFindClassID
            // 
            this.txtFindClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindClassID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindClassID.Location = new System.Drawing.Point(145, 30);
            this.txtFindClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindClassID.Name = "txtFindClassID";
            this.txtFindClassID.Size = new System.Drawing.Size(191, 26);
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
            this.panel6.Location = new System.Drawing.Point(9, 16);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 127);
            this.panel6.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 26);
            this.label18.TabIndex = 6;
            this.label18.Text = "Tìm kiếm";
            // 
            // comboBoxFindFaculty
            // 
            this.comboBoxFindFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindFaculty.FormattingEnabled = true;
            this.comboBoxFindFaculty.Location = new System.Drawing.Point(73, 77);
            this.comboBoxFindFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFindFaculty.Name = "comboBoxFindFaculty";
            this.comboBoxFindFaculty.Size = new System.Drawing.Size(175, 28);
            this.comboBoxFindFaculty.TabIndex = 4;
            this.comboBoxFindFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindFaculty_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(5, 41);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 20);
            this.label25.TabIndex = 1;
            this.label25.Text = "Mã Lớp:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 83);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Khoa:";
            // 
            // txtFindSubjectClass
            // 
            this.txtFindSubjectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindSubjectClass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindSubjectClass.Location = new System.Drawing.Point(73, 35);
            this.txtFindSubjectClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindSubjectClass.Name = "txtFindSubjectClass";
            this.txtFindSubjectClass.Size = new System.Drawing.Size(239, 26);
            this.txtFindSubjectClass.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.Location = new System.Drawing.Point(630, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Danh sách sinh viên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(90, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Danh sách lớp học phần";
            // 
            // listViewSubjectClassList
            // 
            this.listViewSubjectClassList.HideSelection = false;
            this.listViewSubjectClassList.Location = new System.Drawing.Point(-4, 179);
            this.listViewSubjectClassList.Name = "listViewSubjectClassList";
            this.listViewSubjectClassList.Size = new System.Drawing.Size(443, 520);
            this.listViewSubjectClassList.TabIndex = 11;
            this.listViewSubjectClassList.UseCompatibleStateImageBehavior = false;
            this.listViewSubjectClassList.SelectedIndexChanged += new System.EventHandler(this.listViewSubjectClassList_SelectedIndexChanged);
            // 
            // listViewStudentList
            // 
            this.listViewStudentList.HideSelection = false;
            this.listViewStudentList.Location = new System.Drawing.Point(447, 179);
            this.listViewStudentList.Name = "listViewStudentList";
            this.listViewStudentList.Size = new System.Drawing.Size(587, 520);
            this.listViewStudentList.TabIndex = 10;
            this.listViewStudentList.UseCompatibleStateImageBehavior = false;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTimTheoKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFindClassSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxFacultyFClass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewClassList;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReturnMenuSubjectClass;
        private System.Windows.Forms.ListView listViewSubjectClassListFSC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteSubjectClass;
        private System.Windows.Forms.Button btnAddSubjectClass;
        private System.Windows.Forms.Button btnEditSubjectClassFSB;
        private System.Windows.Forms.Button btnRefreshFSC;
        private System.Windows.Forms.ComboBox comboBoxFacultyFSC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubjectClassID;
        private System.Windows.Forms.ComboBox comboBoxSubjectClassFSC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listViewSubjectClassList;
        private System.Windows.Forms.ListView listViewStudentList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxFindFacultyFSC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFindSubjectClassFSC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxFindFaculty;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFindSubjectClass;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddAllStudent;
        private System.Windows.Forms.Button btnDeleteAllStudentID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFindClassID;
        private System.Windows.Forms.Button btnAddStudentID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFindStudentID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNameSubjectClass;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
    }
}