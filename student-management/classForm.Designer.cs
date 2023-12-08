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
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplayAllClass = new System.Windows.Forms.Button();
            this.btnFindClass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTimTheoKhoa = new System.Windows.Forms.ComboBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReturnMenuSubjectClass = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFindAllSubjecClass = new System.Windows.Forms.Button();
            this.btnFindSubjecClass = new System.Windows.Forms.Button();
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
            this.btnDeletaSubjectClass = new System.Windows.Forms.Button();
            this.btnAddSubjectClass = new System.Windows.Forms.Button();
            this.btnEditSubjectClassFSB = new System.Windows.Forms.Button();
            this.btnRefreshFSC = new System.Windows.Forms.Button();
            this.comboBoxFacultyFSC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubjectClassID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFindStudentID = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFindClassID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxFindFaculty = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFindSubjectClass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReturnMenu);
            this.tabPage1.Controls.Add(this.listView1);
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
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(235, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 581);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDisplayAllClass);
            this.panel1.Controls.Add(this.btnFindClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbTimTheoKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFindClassSubject);
            this.panel1.Location = new System.Drawing.Point(235, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 71);
            this.panel1.TabIndex = 8;
            // 
            // btnDisplayAllClass
            // 
            this.btnDisplayAllClass.Location = new System.Drawing.Point(676, 16);
            this.btnDisplayAllClass.Name = "btnDisplayAllClass";
            this.btnDisplayAllClass.Size = new System.Drawing.Size(114, 45);
            this.btnDisplayAllClass.TabIndex = 8;
            this.btnDisplayAllClass.Text = "Tất cả";
            this.btnDisplayAllClass.UseVisualStyleBackColor = true;
            // 
            // btnFindClass
            // 
            this.btnFindClass.Location = new System.Drawing.Point(551, 17);
            this.btnFindClass.Name = "btnFindClass";
            this.btnFindClass.Size = new System.Drawing.Size(119, 45);
            this.btnFindClass.TabIndex = 7;
            this.btnFindClass.Text = "Tìm";
            this.btnFindClass.UseVisualStyleBackColor = true;
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
            this.cbbTimTheoKhoa.Location = new System.Drawing.Point(342, 25);
            this.cbbTimTheoKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTimTheoKhoa.Name = "cbbTimTheoKhoa";
            this.cbbTimTheoKhoa.Size = new System.Drawing.Size(175, 28);
            this.cbbTimTheoKhoa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 31);
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
            this.txtFindClassSubject.Location = new System.Drawing.Point(37, 28);
            this.txtFindClassSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindClassSubject.Name = "txtFindClassSubject";
            this.txtFindClassSubject.Size = new System.Drawing.Size(198, 26);
            this.txtFindClassSubject.TabIndex = 0;
            this.txtFindClassSubject.Text = "nhập mã lớp";
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
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtClassID);
            this.panel2.Location = new System.Drawing.Point(4, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 581);
            this.panel2.TabIndex = 5;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(113, 317);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(114, 45);
            this.btnDeleteClass.TabIndex = 30;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(-2, 317);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(114, 45);
            this.btnAddClass.TabIndex = 29;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(113, 266);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(114, 45);
            this.btnEditClass.TabIndex = 28;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(-2, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 45);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // comboBoxFacultyFClass
            // 
            this.comboBoxFacultyFClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyFClass.FormattingEnabled = true;
            this.comboBoxFacultyFClass.Location = new System.Drawing.Point(59, 73);
            this.comboBoxFacultyFClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFacultyFClass.Name = "comboBoxFacultyFClass";
            this.comboBoxFacultyFClass.Size = new System.Drawing.Size(168, 28);
            this.comboBoxFacultyFClass.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-1, 81);
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
            // txtClassID
            // 
            this.txtClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(70, 20);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(157, 26);
            this.txtClassID.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReturnMenuSubjectClass);
            this.tabPage2.Controls.Add(this.listView2);
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
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(233, 114);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(799, 581);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
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
            this.panel5.Controls.Add(this.btnFindAllSubjecClass);
            this.panel5.Controls.Add(this.btnFindSubjecClass);
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
            // btnFindAllSubjecClass
            // 
            this.btnFindAllSubjecClass.Location = new System.Drawing.Point(676, 16);
            this.btnFindAllSubjecClass.Name = "btnFindAllSubjecClass";
            this.btnFindAllSubjecClass.Size = new System.Drawing.Size(114, 45);
            this.btnFindAllSubjecClass.TabIndex = 8;
            this.btnFindAllSubjecClass.Text = "Tất Cả";
            this.btnFindAllSubjecClass.UseVisualStyleBackColor = true;
            // 
            // btnFindSubjecClass
            // 
            this.btnFindSubjecClass.Location = new System.Drawing.Point(551, 17);
            this.btnFindSubjecClass.Name = "btnFindSubjecClass";
            this.btnFindSubjecClass.Size = new System.Drawing.Size(119, 45);
            this.btnFindSubjecClass.TabIndex = 7;
            this.btnFindSubjecClass.Text = "Tìm";
            this.btnFindSubjecClass.UseVisualStyleBackColor = true;
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
            this.comboBoxFindFacultyFSC.Location = new System.Drawing.Point(342, 25);
            this.comboBoxFindFacultyFSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFindFacultyFSC.Name = "comboBoxFindFacultyFSC";
            this.comboBoxFindFacultyFSC.Size = new System.Drawing.Size(175, 28);
            this.comboBoxFindFacultyFSC.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(274, 31);
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
            this.txtFindSubjectClassFSC.Location = new System.Drawing.Point(37, 28);
            this.txtFindSubjectClassFSC.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindSubjectClassFSC.Name = "txtFindSubjectClassFSC";
            this.txtFindSubjectClassFSC.Size = new System.Drawing.Size(198, 26);
            this.txtFindSubjectClassFSC.TabIndex = 0;
            this.txtFindSubjectClassFSC.Text = "nhập mã lớp";
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
            this.panel4.Controls.Add(this.btnDeletaSubjectClass);
            this.panel4.Controls.Add(this.btnAddSubjectClass);
            this.panel4.Controls.Add(this.btnEditSubjectClassFSB);
            this.panel4.Controls.Add(this.btnRefreshFSC);
            this.panel4.Controls.Add(this.comboBoxFacultyFSC);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
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
            this.comboBoxSubjectClassFSC.Location = new System.Drawing.Point(61, 116);
            this.comboBoxSubjectClassFSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSubjectClassFSC.Name = "comboBoxSubjectClassFSC";
            this.comboBoxSubjectClassFSC.Size = new System.Drawing.Size(166, 28);
            this.comboBoxSubjectClassFSC.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Môn:";
            // 
            // btnDeletaSubjectClass
            // 
            this.btnDeletaSubjectClass.Location = new System.Drawing.Point(113, 317);
            this.btnDeletaSubjectClass.Name = "btnDeletaSubjectClass";
            this.btnDeletaSubjectClass.Size = new System.Drawing.Size(114, 45);
            this.btnDeletaSubjectClass.TabIndex = 30;
            this.btnDeletaSubjectClass.Text = "Xóa";
            this.btnDeletaSubjectClass.UseVisualStyleBackColor = true;
            // 
            // btnAddSubjectClass
            // 
            this.btnAddSubjectClass.Location = new System.Drawing.Point(-2, 317);
            this.btnAddSubjectClass.Name = "btnAddSubjectClass";
            this.btnAddSubjectClass.Size = new System.Drawing.Size(114, 45);
            this.btnAddSubjectClass.TabIndex = 29;
            this.btnAddSubjectClass.Text = "Thêm";
            this.btnAddSubjectClass.UseVisualStyleBackColor = true;
            // 
            // btnEditSubjectClassFSB
            // 
            this.btnEditSubjectClassFSB.Location = new System.Drawing.Point(113, 266);
            this.btnEditSubjectClassFSB.Name = "btnEditSubjectClassFSB";
            this.btnEditSubjectClassFSB.Size = new System.Drawing.Size(114, 45);
            this.btnEditSubjectClassFSB.TabIndex = 28;
            this.btnEditSubjectClassFSB.Text = "Sửa";
            this.btnEditSubjectClassFSB.UseVisualStyleBackColor = true;
            // 
            // btnRefreshFSC
            // 
            this.btnRefreshFSC.Location = new System.Drawing.Point(-2, 266);
            this.btnRefreshFSC.Name = "btnRefreshFSC";
            this.btnRefreshFSC.Size = new System.Drawing.Size(114, 45);
            this.btnRefreshFSC.TabIndex = 27;
            this.btnRefreshFSC.Text = "Làm Mới";
            this.btnRefreshFSC.UseVisualStyleBackColor = true;
            // 
            // comboBoxFacultyFSC
            // 
            this.comboBoxFacultyFSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyFSC.FormattingEnabled = true;
            this.comboBoxFacultyFSC.Location = new System.Drawing.Point(59, 73);
            this.comboBoxFacultyFSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFacultyFSC.Name = "comboBoxFacultyFSC";
            this.comboBoxFacultyFSC.Size = new System.Drawing.Size(168, 28);
            this.comboBoxFacultyFSC.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 81);
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
            // txtSubjectClassID
            // 
            this.txtSubjectClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectClassID.Location = new System.Drawing.Point(70, 20);
            this.txtSubjectClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectClassID.Name = "txtSubjectClassID";
            this.txtSubjectClassID.Size = new System.Drawing.Size(157, 26);
            this.txtSubjectClassID.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.listView4);
            this.tabPage3.Controls.Add(this.listView3);
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
            this.panel7.Controls.Add(this.button14);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.button12);
            this.panel7.Controls.Add(this.button13);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.txtFindClassID);
            this.panel7.Location = new System.Drawing.Point(524, 17);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(506, 127);
            this.panel7.TabIndex = 15;
            // 
            // txtFindStudentID
            // 
            this.txtFindStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindStudentID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFindStudentID.Location = new System.Drawing.Point(9, 82);
            this.txtFindStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindStudentID.Name = "txtFindStudentID";
            this.txtFindStudentID.Size = new System.Drawing.Size(239, 26);
            this.txtFindStudentID.TabIndex = 11;
            this.txtFindStudentID.Text = "nhập mssv";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(267, 66);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(114, 45);
            this.button14.TabIndex = 10;
            this.button14.Text = "Thêm sinh viên";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(387, 66);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(114, 45);
            this.button12.TabIndex = 8;
            this.button12.Text = "Thêm Tất Cả";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(387, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(114, 45);
            this.button13.TabIndex = 7;
            this.button13.Text = "Xóa Tất cả";
            this.button13.UseVisualStyleBackColor = true;
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
            this.txtFindClassID.Location = new System.Drawing.Point(9, 30);
            this.txtFindClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindClassID.Name = "txtFindClassID";
            this.txtFindClassID.Size = new System.Drawing.Size(239, 26);
            this.txtFindClassID.TabIndex = 0;
            this.txtFindClassID.Text = "nhập mã lớp";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.comboBoxFindFaculty);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.txtFindSubjectClass);
            this.panel6.Location = new System.Drawing.Point(9, 16);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(499, 127);
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
            this.txtFindSubjectClass.Location = new System.Drawing.Point(9, 37);
            this.txtFindSubjectClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindSubjectClass.Name = "txtFindSubjectClass";
            this.txtFindSubjectClass.Size = new System.Drawing.Size(239, 26);
            this.txtFindSubjectClass.TabIndex = 0;
            this.txtFindSubjectClass.Text = "nhập mã lớp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.Location = new System.Drawing.Point(689, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Danh sách sinh viên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(135, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Danh sách lớp học phần";
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(-4, 179);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(512, 520);
            this.listView4.TabIndex = 11;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(524, 179);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(510, 520);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnDisplayAllClass;
        private System.Windows.Forms.Button btnFindClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReturnMenuSubjectClass;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeletaSubjectClass;
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
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFindAllSubjecClass;
        private System.Windows.Forms.Button btnFindSubjecClass;
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
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFindClassID;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFindStudentID;
    }
}