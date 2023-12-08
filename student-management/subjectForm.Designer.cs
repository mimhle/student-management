namespace studentManagement {
    partial class SubjectForm {
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
            this.components = new System.ComponentModel.Container();
            this.gbAddSubject = new System.Windows.Forms.GroupBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.labelDeleteSubject = new System.Windows.Forms.Label();
            this.labelFacultyDelete = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelIdSubject = new System.Windows.Forms.Label();
            this.labelNameSubject = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.listViewDisplaySubject = new System.Windows.Forms.ListView();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.gbOptionAddSubject = new System.Windows.Forms.GroupBox();
            this.btnReturnMenuAddSubject = new System.Windows.Forms.Button();
            this.btnAddScoreAddSubject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbAddScore = new System.Windows.Forms.GroupBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMssvAddScore = new System.Windows.Forms.Label();
            this.txtMssvAddScore = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnConfirmStudent = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.labelClassAddScore = new System.Windows.Forms.Label();
            this.labelSubjectAddScore = new System.Windows.Forms.Label();
            this.labelFacultyAddScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.listViewAddScore = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReturnMenuAddScore = new System.Windows.Forms.Button();
            this.btnAddSubjectAddScore = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.errorProviderSubjectID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSubjectName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCredit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFacultySelected = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddSubject.SuspendLayout();
            this.gbOptionAddSubject.SuspendLayout();
            this.gbAddScore.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjectID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultySelected)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddSubject
            // 
            this.gbAddSubject.Controls.Add(this.labelCredit);
            this.gbAddSubject.Controls.Add(this.txtCredit);
            this.gbAddSubject.Controls.Add(this.labelDeleteSubject);
            this.gbAddSubject.Controls.Add(this.labelFacultyDelete);
            this.gbAddSubject.Controls.Add(this.labelFaculty);
            this.gbAddSubject.Controls.Add(this.labelIdSubject);
            this.gbAddSubject.Controls.Add(this.labelNameSubject);
            this.gbAddSubject.Controls.Add(this.comboBox2);
            this.gbAddSubject.Controls.Add(this.btnEditSubject);
            this.gbAddSubject.Controls.Add(this.btnDeleteSubject);
            this.gbAddSubject.Controls.Add(this.listViewDisplaySubject);
            this.gbAddSubject.Controls.Add(this.btnAddSubject);
            this.gbAddSubject.Controls.Add(this.gbOptionAddSubject);
            this.gbAddSubject.Controls.Add(this.comboBox1);
            this.gbAddSubject.Controls.Add(this.textBox2);
            this.gbAddSubject.Controls.Add(this.textBox1);
            this.gbAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbAddSubject.Location = new System.Drawing.Point(12, 12);
            this.gbAddSubject.Name = "gbAddSubject";
            this.gbAddSubject.Size = new System.Drawing.Size(1018, 704);
            this.gbAddSubject.TabIndex = 0;
            this.gbAddSubject.TabStop = false;
            this.gbAddSubject.Text = "Thêm Môn Học";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(410, 157);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(107, 29);
            this.labelCredit.TabIndex = 18;
            this.labelCredit.Text = "Tính Chỉ";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(523, 150);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(247, 36);
            this.txtCredit.TabIndex = 17;
            this.txtCredit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCredit_Validating);
            // 
            // labelDeleteSubject
            // 
            this.labelDeleteSubject.AutoSize = true;
            this.labelDeleteSubject.Location = new System.Drawing.Point(9, 159);
            this.labelDeleteSubject.Name = "labelDeleteSubject";
            this.labelDeleteSubject.Size = new System.Drawing.Size(166, 29);
            this.labelDeleteSubject.TabIndex = 16;
            this.labelDeleteSubject.Text = "Xóa Môn Học";
            // 
            // labelFacultyDelete
            // 
            this.labelFacultyDelete.AutoSize = true;
            this.labelFacultyDelete.Location = new System.Drawing.Point(9, 202);
            this.labelFacultyDelete.Name = "labelFacultyDelete";
            this.labelFacultyDelete.Size = new System.Drawing.Size(72, 29);
            this.labelFacultyDelete.TabIndex = 14;
            this.labelFacultyDelete.Text = "Khoa";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(518, 47);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(149, 29);
            this.labelFaculty.TabIndex = 13;
            this.labelFaculty.Text = "Thuộc Khoa";
            // 
            // labelIdSubject
            // 
            this.labelIdSubject.AutoSize = true;
            this.labelIdSubject.Location = new System.Drawing.Point(263, 47);
            this.labelIdSubject.Name = "labelIdSubject";
            this.labelIdSubject.Size = new System.Drawing.Size(156, 29);
            this.labelIdSubject.TabIndex = 12;
            this.labelIdSubject.Text = "Mã Môn Học";
            // 
            // labelNameSubject
            // 
            this.labelNameSubject.AutoSize = true;
            this.labelNameSubject.Location = new System.Drawing.Point(9, 49);
            this.labelNameSubject.Name = "labelNameSubject";
            this.labelNameSubject.Size = new System.Drawing.Size(164, 29);
            this.labelNameSubject.TabIndex = 11;
            this.labelNameSubject.Text = "Tên Môn Học";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(355, 37);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.Location = new System.Drawing.Point(794, 157);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(218, 80);
            this.btnEditSubject.TabIndex = 8;
            this.btnEditSubject.Text = "Chỉnh Sửa Môn Học";
            this.btnEditSubject.UseVisualStyleBackColor = true;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(500, 224);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(218, 54);
            this.btnDeleteSubject.TabIndex = 7;
            this.btnDeleteSubject.Text = "Xóa";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // listViewDisplaySubject
            // 
            this.listViewDisplaySubject.HideSelection = false;
            this.listViewDisplaySubject.Location = new System.Drawing.Point(6, 287);
            this.listViewDisplaySubject.Name = "listViewDisplaySubject";
            this.listViewDisplaySubject.Size = new System.Drawing.Size(712, 410);
            this.listViewDisplaySubject.TabIndex = 6;
            this.listViewDisplaySubject.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(794, 19);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(218, 132);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Thêm";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // gbOptionAddSubject
            // 
            this.gbOptionAddSubject.Controls.Add(this.btnReturnMenuAddSubject);
            this.gbOptionAddSubject.Controls.Add(this.btnAddScoreAddSubject);
            this.gbOptionAddSubject.Location = new System.Drawing.Point(724, 281);
            this.gbOptionAddSubject.Name = "gbOptionAddSubject";
            this.gbOptionAddSubject.Size = new System.Drawing.Size(288, 417);
            this.gbOptionAddSubject.TabIndex = 3;
            this.gbOptionAddSubject.TabStop = false;
            this.gbOptionAddSubject.Text = "Các Chức Năng";
            // 
            // btnReturnMenuAddSubject
            // 
            this.btnReturnMenuAddSubject.Location = new System.Drawing.Point(6, 222);
            this.btnReturnMenuAddSubject.Name = "btnReturnMenuAddSubject";
            this.btnReturnMenuAddSubject.Size = new System.Drawing.Size(276, 183);
            this.btnReturnMenuAddSubject.TabIndex = 10;
            this.btnReturnMenuAddSubject.Text = "Trở về Menu";
            this.btnReturnMenuAddSubject.UseVisualStyleBackColor = true;
            this.btnReturnMenuAddSubject.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnAddScoreAddSubject
            // 
            this.btnAddScoreAddSubject.Location = new System.Drawing.Point(6, 35);
            this.btnAddScoreAddSubject.Name = "btnAddScoreAddSubject";
            this.btnAddScoreAddSubject.Size = new System.Drawing.Size(276, 181);
            this.btnAddScoreAddSubject.TabIndex = 9;
            this.btnAddScoreAddSubject.Text = "Nhập Điểm Cho Môn Học";
            this.btnAddScoreAddSubject.UseVisualStyleBackColor = true;
            this.btnAddScoreAddSubject.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 37);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // gbAddScore
            // 
            this.gbAddScore.Controls.Add(this.labelScore);
            this.gbAddScore.Controls.Add(this.textBox3);
            this.gbAddScore.Controls.Add(this.labelMssvAddScore);
            this.gbAddScore.Controls.Add(this.txtMssvAddScore);
            this.gbAddScore.Controls.Add(this.btnAddScore);
            this.gbAddScore.Controls.Add(this.btnConfirmStudent);
            this.gbAddScore.Controls.Add(this.comboBoxClass);
            this.gbAddScore.Controls.Add(this.comboBoxSubject);
            this.gbAddScore.Controls.Add(this.comboBoxFaculty);
            this.gbAddScore.Controls.Add(this.labelClassAddScore);
            this.gbAddScore.Controls.Add(this.labelSubjectAddScore);
            this.gbAddScore.Controls.Add(this.labelFacultyAddScore);
            this.gbAddScore.Controls.Add(this.label1);
            this.gbAddScore.Controls.Add(this.txtStudentName);
            this.gbAddScore.Controls.Add(this.listViewAddScore);
            this.gbAddScore.Controls.Add(this.groupBox2);
            this.gbAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbAddScore.Location = new System.Drawing.Point(12, 12);
            this.gbAddScore.Name = "gbAddScore";
            this.gbAddScore.Size = new System.Drawing.Size(1018, 704);
            this.gbAddScore.TabIndex = 1;
            this.gbAddScore.TabStop = false;
            this.gbAddScore.Text = "Thêm Điểm Môn Học";
            this.gbAddScore.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(532, 183);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 29);
            this.labelScore.TabIndex = 19;
            this.labelScore.Text = "Điểm";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(537, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 36);
            this.textBox3.TabIndex = 18;
            // 
            // labelMssvAddScore
            // 
            this.labelMssvAddScore.AutoSize = true;
            this.labelMssvAddScore.Location = new System.Drawing.Point(276, 183);
            this.labelMssvAddScore.Name = "labelMssvAddScore";
            this.labelMssvAddScore.Size = new System.Drawing.Size(202, 29);
            this.labelMssvAddScore.TabIndex = 17;
            this.labelMssvAddScore.Text = "Mã Số Sinh Viên";
            // 
            // txtMssvAddScore
            // 
            this.txtMssvAddScore.Enabled = false;
            this.txtMssvAddScore.Location = new System.Drawing.Point(268, 226);
            this.txtMssvAddScore.Name = "txtMssvAddScore";
            this.txtMssvAddScore.ReadOnly = true;
            this.txtMssvAddScore.Size = new System.Drawing.Size(224, 36);
            this.txtMssvAddScore.TabIndex = 16;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(794, 19);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(218, 132);
            this.btnAddScore.TabIndex = 15;
            this.btnAddScore.Text = "Nhập Điểm";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click_1);
            // 
            // btnConfirmStudent
            // 
            this.btnConfirmStudent.Location = new System.Drawing.Point(794, 157);
            this.btnConfirmStudent.Name = "btnConfirmStudent";
            this.btnConfirmStudent.Size = new System.Drawing.Size(218, 80);
            this.btnConfirmStudent.TabIndex = 14;
            this.btnConfirmStudent.Text = "Chọn";
            this.btnConfirmStudent.UseVisualStyleBackColor = true;
            this.btnConfirmStudent.Click += new System.EventHandler(this.btnConfirmStudent_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(537, 93);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(224, 37);
            this.comboBoxClass.TabIndex = 13;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(268, 89);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(224, 37);
            this.comboBoxSubject.TabIndex = 12;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(14, 89);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(224, 37);
            this.comboBoxFaculty.TabIndex = 11;
            this.comboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaculty_SelectedIndexChanged);
            // 
            // labelClassAddScore
            // 
            this.labelClassAddScore.AutoSize = true;
            this.labelClassAddScore.Location = new System.Drawing.Point(532, 49);
            this.labelClassAddScore.Name = "labelClassAddScore";
            this.labelClassAddScore.Size = new System.Drawing.Size(55, 29);
            this.labelClassAddScore.TabIndex = 10;
            this.labelClassAddScore.Text = "Lớp";
            // 
            // labelSubjectAddScore
            // 
            this.labelSubjectAddScore.AutoSize = true;
            this.labelSubjectAddScore.Location = new System.Drawing.Point(263, 49);
            this.labelSubjectAddScore.Name = "labelSubjectAddScore";
            this.labelSubjectAddScore.Size = new System.Drawing.Size(62, 29);
            this.labelSubjectAddScore.TabIndex = 9;
            this.labelSubjectAddScore.Text = "Môn";
            // 
            // labelFacultyAddScore
            // 
            this.labelFacultyAddScore.AutoSize = true;
            this.labelFacultyAddScore.Location = new System.Drawing.Point(9, 49);
            this.labelFacultyAddScore.Name = "labelFacultyAddScore";
            this.labelFacultyAddScore.Size = new System.Drawing.Size(72, 29);
            this.labelFacultyAddScore.TabIndex = 8;
            this.labelFacultyAddScore.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(8, 226);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(239, 36);
            this.txtStudentName.TabIndex = 6;
            // 
            // listViewAddScore
            // 
            this.listViewAddScore.HideSelection = false;
            this.listViewAddScore.Location = new System.Drawing.Point(8, 287);
            this.listViewAddScore.Name = "listViewAddScore";
            this.listViewAddScore.Size = new System.Drawing.Size(710, 410);
            this.listViewAddScore.TabIndex = 5;
            this.listViewAddScore.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReturnMenuAddScore);
            this.groupBox2.Controls.Add(this.btnAddSubjectAddScore);
            this.groupBox2.Location = new System.Drawing.Point(724, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 411);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Chức Năng";
            // 
            // btnReturnMenuAddScore
            // 
            this.btnReturnMenuAddScore.Location = new System.Drawing.Point(6, 222);
            this.btnReturnMenuAddScore.Name = "btnReturnMenuAddScore";
            this.btnReturnMenuAddScore.Size = new System.Drawing.Size(276, 183);
            this.btnReturnMenuAddScore.TabIndex = 10;
            this.btnReturnMenuAddScore.Text = "Trở về Menu";
            this.btnReturnMenuAddScore.UseVisualStyleBackColor = true;
            this.btnReturnMenuAddScore.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnAddSubjectAddScore
            // 
            this.btnAddSubjectAddScore.Location = new System.Drawing.Point(6, 35);
            this.btnAddSubjectAddScore.Name = "btnAddSubjectAddScore";
            this.btnAddSubjectAddScore.Size = new System.Drawing.Size(276, 181);
            this.btnAddSubjectAddScore.TabIndex = 9;
            this.btnAddSubjectAddScore.Text = "Tìm Kiếm Môn Học";
            this.btnAddSubjectAddScore.UseVisualStyleBackColor = true;
            this.btnAddSubjectAddScore.Click += new System.EventHandler(this.btnAddSubjectAddScore_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // errorProviderSubjectID
            // 
            this.errorProviderSubjectID.ContainerControl = this;
            // 
            // errorProviderSubjectName
            // 
            this.errorProviderSubjectName.ContainerControl = this;
            // 
            // errorProviderCredit
            // 
            this.errorProviderCredit.ContainerControl = this;
            // 
            // errorProviderFacultySelected
            // 
            this.errorProviderFacultySelected.ContainerControl = this;
            // 
            // subjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.gbAddScore);
            this.Controls.Add(this.gbAddSubject);
            this.Name = "SubjectForm";
            this.Text = "Điểm";
            this.gbAddSubject.ResumeLayout(false);
            this.gbAddSubject.PerformLayout();
            this.gbOptionAddSubject.ResumeLayout(false);
            this.gbAddScore.ResumeLayout(false);
            this.gbAddScore.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjectID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultySelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddSubject;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listViewDisplaySubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.GroupBox gbOptionAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnReturnMenuAddSubject;
        private System.Windows.Forms.Button btnAddScoreAddSubject;
        private System.Windows.Forms.Label labelDeleteSubject;
        private System.Windows.Forms.Label labelFacultyDelete;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelIdSubject;
        private System.Windows.Forms.Label labelNameSubject;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gbAddScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReturnMenuAddScore;
        private System.Windows.Forms.Button btnAddSubjectAddScore;
        private System.Windows.Forms.ListView listViewAddScore;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labelClassAddScore;
        private System.Windows.Forms.Label labelSubjectAddScore;
        private System.Windows.Forms.Label labelFacultyAddScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnConfirmStudent;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label labelMssvAddScore;
        private System.Windows.Forms.TextBox txtMssvAddScore;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.ErrorProvider errorProviderSubjectID;
        private System.Windows.Forms.ErrorProvider errorProviderSubjectName;
        private System.Windows.Forms.ErrorProvider errorProviderCredit;
        private System.Windows.Forms.ErrorProvider errorProviderFacultySelected;
    }
}