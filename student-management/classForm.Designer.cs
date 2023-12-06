namespace studentManagement {
    partial class classForm {
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
            this.gbAddClass = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.labelSubjectAdd = new System.Windows.Forms.Label();
            this.labelFacultyAdd = new System.Windows.Forms.Label();
            this.labelNameAddAdd = new System.Windows.Forms.Label();
            this.labelNameAdd = new System.Windows.Forms.Label();
            this.gbOtherOptionAdd = new System.Windows.Forms.GroupBox();
            this.btnReturnMenuAdd = new System.Windows.Forms.Button();
            this.btnDeleteClassAdd = new System.Windows.Forms.Button();
            this.btnAddNormalClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtIdClassAdd = new System.Windows.Forms.TextBox();
            this.comboBoxFacultyAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxSubjectAdd = new System.Windows.Forms.ComboBox();
            this.txtNameClassAdd = new System.Windows.Forms.TextBox();
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.gbChangeClass = new System.Windows.Forms.GroupBox();
            this.labelIdFind = new System.Windows.Forms.Label();
            this.txtIdFInd = new System.Windows.Forms.TextBox();
            this.btnFindClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.gbOptionChange = new System.Windows.Forms.GroupBox();
            this.btnReturnMenuChange = new System.Windows.Forms.Button();
            this.btnAddClassChange = new System.Windows.Forms.Button();
            this.labelSubjectChange = new System.Windows.Forms.Label();
            this.labelFacultyChange = new System.Windows.Forms.Label();
            this.labelIdChange = new System.Windows.Forms.Label();
            this.labelNameChange = new System.Windows.Forms.Label();
            this.txtIdChange = new System.Windows.Forms.TextBox();
            this.comboBoxFacultyChange = new System.Windows.Forms.ComboBox();
            this.comboBoxSubjectChange = new System.Windows.Forms.ComboBox();
            this.txtNameChange = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbAddClass.SuspendLayout();
            this.gbOtherOptionAdd.SuspendLayout();
            this.groupBoxAddStudent.SuspendLayout();
            this.gbChangeClass.SuspendLayout();
            this.gbOptionChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddClass
            // 
            this.gbAddClass.Controls.Add(this.listView2);
            this.gbAddClass.Controls.Add(this.labelSubjectAdd);
            this.gbAddClass.Controls.Add(this.labelFacultyAdd);
            this.gbAddClass.Controls.Add(this.labelNameAddAdd);
            this.gbAddClass.Controls.Add(this.labelNameAdd);
            this.gbAddClass.Controls.Add(this.btnAddNormalClass);
            this.gbAddClass.Controls.Add(this.btnAddClass);
            this.gbAddClass.Controls.Add(this.txtIdClassAdd);
            this.gbAddClass.Controls.Add(this.comboBoxFacultyAdd);
            this.gbAddClass.Controls.Add(this.comboBoxSubjectAdd);
            this.gbAddClass.Controls.Add(this.txtNameClassAdd);
            this.gbAddClass.Controls.Add(this.groupBoxAddStudent);
            this.gbAddClass.Controls.Add(this.gbOtherOptionAdd);
            this.gbAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbAddClass.Location = new System.Drawing.Point(10, 8);
            this.gbAddClass.Name = "gbAddClass";
            this.gbAddClass.Size = new System.Drawing.Size(1020, 704);
            this.gbAddClass.TabIndex = 0;
            this.gbAddClass.TabStop = false;
            this.gbAddClass.Text = "Thêm Lớp Học";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 318);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(712, 380);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // labelSubjectAdd
            // 
            this.labelSubjectAdd.AutoSize = true;
            this.labelSubjectAdd.Location = new System.Drawing.Point(284, 131);
            this.labelSubjectAdd.Name = "labelSubjectAdd";
            this.labelSubjectAdd.Size = new System.Drawing.Size(272, 29);
            this.labelSubjectAdd.TabIndex = 10;
            this.labelSubjectAdd.Text = "Chọn Môn Thuộc Khoa";
            // 
            // labelFacultyAdd
            // 
            this.labelFacultyAdd.AutoSize = true;
            this.labelFacultyAdd.Location = new System.Drawing.Point(12, 131);
            this.labelFacultyAdd.Name = "labelFacultyAdd";
            this.labelFacultyAdd.Size = new System.Drawing.Size(139, 29);
            this.labelFacultyAdd.TabIndex = 9;
            this.labelFacultyAdd.Text = "Chọn Khoa";
            // 
            // labelNameAddAdd
            // 
            this.labelNameAddAdd.AutoSize = true;
            this.labelNameAddAdd.Location = new System.Drawing.Point(284, 29);
            this.labelNameAddAdd.Name = "labelNameAddAdd";
            this.labelNameAddAdd.Size = new System.Drawing.Size(149, 29);
            this.labelNameAddAdd.TabIndex = 8;
            this.labelNameAddAdd.Text = "Mã Lớp Học";
            // 
            // labelNameAdd
            // 
            this.labelNameAdd.AutoSize = true;
            this.labelNameAdd.Location = new System.Drawing.Point(11, 32);
            this.labelNameAdd.Name = "labelNameAdd";
            this.labelNameAdd.Size = new System.Drawing.Size(157, 29);
            this.labelNameAdd.TabIndex = 7;
            this.labelNameAdd.Text = "Tên Lớp Học";
            // 
            // gbOtherOptionAdd
            // 
            this.gbOtherOptionAdd.Controls.Add(this.btnReturnMenuAdd);
            this.gbOtherOptionAdd.Controls.Add(this.btnDeleteClassAdd);
            this.gbOtherOptionAdd.Location = new System.Drawing.Point(724, 304);
            this.gbOtherOptionAdd.Name = "gbOtherOptionAdd";
            this.gbOtherOptionAdd.Size = new System.Drawing.Size(288, 394);
            this.gbOtherOptionAdd.TabIndex = 6;
            this.gbOtherOptionAdd.TabStop = false;
            this.gbOtherOptionAdd.Text = "Các Chức Năng ";
            // 
            // btnReturnMenuAdd
            // 
            this.btnReturnMenuAdd.Location = new System.Drawing.Point(6, 222);
            this.btnReturnMenuAdd.Name = "btnReturnMenuAdd";
            this.btnReturnMenuAdd.Size = new System.Drawing.Size(276, 166);
            this.btnReturnMenuAdd.TabIndex = 2;
            this.btnReturnMenuAdd.Text = "Trở Về Menu";
            this.btnReturnMenuAdd.UseVisualStyleBackColor = true;
            this.btnReturnMenuAdd.Click += new System.EventHandler(this.btnReturnMenuAdd_Click);
            // 
            // btnDeleteClassAdd
            // 
            this.btnDeleteClassAdd.Location = new System.Drawing.Point(6, 35);
            this.btnDeleteClassAdd.Name = "btnDeleteClassAdd";
            this.btnDeleteClassAdd.Size = new System.Drawing.Size(276, 181);
            this.btnDeleteClassAdd.TabIndex = 0;
            this.btnDeleteClassAdd.Text = "Chỉnh sửa Lớp Học";
            this.btnDeleteClassAdd.UseVisualStyleBackColor = true;
            this.btnDeleteClassAdd.Click += new System.EventHandler(this.btnDeleteClassAdd_Click);
            // 
            // btnAddNormalClass
            // 
            this.btnAddNormalClass.Location = new System.Drawing.Point(291, 237);
            this.btnAddNormalClass.Name = "btnAddNormalClass";
            this.btnAddNormalClass.Size = new System.Drawing.Size(249, 71);
            this.btnAddNormalClass.TabIndex = 5;
            this.btnAddNormalClass.Text = "Thêm Lớp Học \nPhần";
            this.btnAddNormalClass.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(12, 237);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(254, 71);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // txtIdClassAdd
            // 
            this.txtIdClassAdd.Location = new System.Drawing.Point(289, 71);
            this.txtIdClassAdd.Name = "txtIdClassAdd";
            this.txtIdClassAdd.Size = new System.Drawing.Size(249, 36);
            this.txtIdClassAdd.TabIndex = 3;
            // 
            // comboBoxFacultyAdd
            // 
            this.comboBoxFacultyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBoxFacultyAdd.FormattingEnabled = true;
            this.comboBoxFacultyAdd.Location = new System.Drawing.Point(16, 169);
            this.comboBoxFacultyAdd.Name = "comboBoxFacultyAdd";
            this.comboBoxFacultyAdd.Size = new System.Drawing.Size(250, 37);
            this.comboBoxFacultyAdd.TabIndex = 2;
            // 
            // comboBoxSubjectAdd
            // 
            this.comboBoxSubjectAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBoxSubjectAdd.FormattingEnabled = true;
            this.comboBoxSubjectAdd.Location = new System.Drawing.Point(291, 166);
            this.comboBoxSubjectAdd.Name = "comboBoxSubjectAdd";
            this.comboBoxSubjectAdd.Size = new System.Drawing.Size(247, 37);
            this.comboBoxSubjectAdd.TabIndex = 1;
            // 
            // txtNameClassAdd
            // 
            this.txtNameClassAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtNameClassAdd.Location = new System.Drawing.Point(14, 74);
            this.txtNameClassAdd.Name = "txtNameClassAdd";
            this.txtNameClassAdd.Size = new System.Drawing.Size(252, 36);
            this.txtNameClassAdd.TabIndex = 0;
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Controls.Add(this.label4);
            this.groupBoxAddStudent.Controls.Add(this.label3);
            this.groupBoxAddStudent.Controls.Add(this.label2);
            this.groupBoxAddStudent.Controls.Add(this.label1);
            this.groupBoxAddStudent.Controls.Add(this.comboBoxFaculty);
            this.groupBoxAddStudent.Controls.Add(this.btnAddStudent);
            this.groupBoxAddStudent.Controls.Add(this.btnDeleteStudent);
            this.groupBoxAddStudent.Controls.Add(this.txtIdStudent);
            this.groupBoxAddStudent.Location = new System.Drawing.Point(549, 32);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(465, 276);
            this.groupBoxAddStudent.TabIndex = 12;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "Thêm Sinh Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhập MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chọn Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sinh Viên trong bảng để thêm Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vui Lòng Chọn 1 trong 2 ô dưới và chọn";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(10, 158);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(217, 37);
            this.comboBoxFaculty.TabIndex = 14;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(10, 199);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(218, 67);
            this.btnAddStudent.TabIndex = 13;
            this.btnAddStudent.Text = "Thêm Sinh Viên";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(234, 199);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(224, 67);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Xóa Sinh Viên";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(234, 157);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(224, 36);
            this.txtIdStudent.TabIndex = 11;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // gbChangeClass
            // 
            this.gbChangeClass.Controls.Add(this.labelIdFind);
            this.gbChangeClass.Controls.Add(this.txtIdFInd);
            this.gbChangeClass.Controls.Add(this.btnFindClass);
            this.gbChangeClass.Controls.Add(this.btnEditClass);
            this.gbChangeClass.Controls.Add(this.btnDeleteClass);
            this.gbChangeClass.Controls.Add(this.gbOptionChange);
            this.gbChangeClass.Controls.Add(this.labelSubjectChange);
            this.gbChangeClass.Controls.Add(this.labelFacultyChange);
            this.gbChangeClass.Controls.Add(this.labelIdChange);
            this.gbChangeClass.Controls.Add(this.labelNameChange);
            this.gbChangeClass.Controls.Add(this.txtIdChange);
            this.gbChangeClass.Controls.Add(this.comboBoxFacultyChange);
            this.gbChangeClass.Controls.Add(this.comboBoxSubjectChange);
            this.gbChangeClass.Controls.Add(this.txtNameChange);
            this.gbChangeClass.Controls.Add(this.listView1);
            this.gbChangeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbChangeClass.Location = new System.Drawing.Point(10, 8);
            this.gbChangeClass.Name = "gbChangeClass";
            this.gbChangeClass.Size = new System.Drawing.Size(1020, 704);
            this.gbChangeClass.TabIndex = 1;
            this.gbChangeClass.TabStop = false;
            this.gbChangeClass.Text = "Chỉnh Sửa Thông Tin";
            this.gbChangeClass.Visible = false;
            // 
            // labelIdFind
            // 
            this.labelIdFind.AutoSize = true;
            this.labelIdFind.Location = new System.Drawing.Point(795, 25);
            this.labelIdFind.Name = "labelIdFind";
            this.labelIdFind.Size = new System.Drawing.Size(149, 29);
            this.labelIdFind.TabIndex = 24;
            this.labelIdFind.Text = "Mã Lớp Học";
            // 
            // txtIdFInd
            // 
            this.txtIdFInd.Location = new System.Drawing.Point(789, 66);
            this.txtIdFInd.Name = "txtIdFInd";
            this.txtIdFInd.Size = new System.Drawing.Size(212, 36);
            this.txtIdFInd.TabIndex = 23;
            // 
            // btnFindClass
            // 
            this.btnFindClass.Location = new System.Drawing.Point(789, 123);
            this.btnFindClass.Name = "btnFindClass";
            this.btnFindClass.Size = new System.Drawing.Size(212, 122);
            this.btnFindClass.TabIndex = 22;
            this.btnFindClass.Text = "Hiển Thị Thông Tin Lớp";
            this.btnFindClass.UseVisualStyleBackColor = true;
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(528, 167);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(212, 135);
            this.btnEditClass.TabIndex = 21;
            this.btnEditClass.Text = "Chỉnh Sửa Lớp";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(528, 27);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(212, 133);
            this.btnDeleteClass.TabIndex = 20;
            this.btnDeleteClass.Text = "Xóa Lớp";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // gbOptionChange
            // 
            this.gbOptionChange.Controls.Add(this.btnReturnMenuChange);
            this.gbOptionChange.Controls.Add(this.btnAddClassChange);
            this.gbOptionChange.Location = new System.Drawing.Point(724, 304);
            this.gbOptionChange.Name = "gbOptionChange";
            this.gbOptionChange.Size = new System.Drawing.Size(290, 398);
            this.gbOptionChange.TabIndex = 19;
            this.gbOptionChange.TabStop = false;
            this.gbOptionChange.Text = "Các Chức Năng ";
            // 
            // btnReturnMenuChange
            // 
            this.btnReturnMenuChange.Location = new System.Drawing.Point(6, 222);
            this.btnReturnMenuChange.Name = "btnReturnMenuChange";
            this.btnReturnMenuChange.Size = new System.Drawing.Size(277, 166);
            this.btnReturnMenuChange.TabIndex = 2;
            this.btnReturnMenuChange.Text = "Trở Về Menu";
            this.btnReturnMenuChange.UseVisualStyleBackColor = true;
            this.btnReturnMenuChange.Click += new System.EventHandler(this.btnReturnMenuAdd_Click);
            // 
            // btnAddClassChange
            // 
            this.btnAddClassChange.Location = new System.Drawing.Point(6, 35);
            this.btnAddClassChange.Name = "btnAddClassChange";
            this.btnAddClassChange.Size = new System.Drawing.Size(276, 181);
            this.btnAddClassChange.TabIndex = 0;
            this.btnAddClassChange.Text = "Thêm Lớp Học";
            this.btnAddClassChange.UseVisualStyleBackColor = true;
            this.btnAddClassChange.Click += new System.EventHandler(this.btnAddClassChange_Click);
            // 
            // labelSubjectChange
            // 
            this.labelSubjectChange.AutoSize = true;
            this.labelSubjectChange.Location = new System.Drawing.Point(235, 192);
            this.labelSubjectChange.Name = "labelSubjectChange";
            this.labelSubjectChange.Size = new System.Drawing.Size(272, 29);
            this.labelSubjectChange.TabIndex = 18;
            this.labelSubjectChange.Text = "Chọn Môn Thuộc Khoa";
            // 
            // labelFacultyChange
            // 
            this.labelFacultyChange.AutoSize = true;
            this.labelFacultyChange.Location = new System.Drawing.Point(3, 192);
            this.labelFacultyChange.Name = "labelFacultyChange";
            this.labelFacultyChange.Size = new System.Drawing.Size(139, 29);
            this.labelFacultyChange.TabIndex = 17;
            this.labelFacultyChange.Text = "Chọn Khoa";
            // 
            // labelIdChange
            // 
            this.labelIdChange.AutoSize = true;
            this.labelIdChange.Location = new System.Drawing.Point(264, 61);
            this.labelIdChange.Name = "labelIdChange";
            this.labelIdChange.Size = new System.Drawing.Size(149, 29);
            this.labelIdChange.TabIndex = 16;
            this.labelIdChange.Text = "Mã Lớp Học";
            // 
            // labelNameChange
            // 
            this.labelNameChange.AutoSize = true;
            this.labelNameChange.Location = new System.Drawing.Point(6, 61);
            this.labelNameChange.Name = "labelNameChange";
            this.labelNameChange.Size = new System.Drawing.Size(157, 29);
            this.labelNameChange.TabIndex = 15;
            this.labelNameChange.Text = "Tên Lớp Học";
            // 
            // txtIdChange
            // 
            this.txtIdChange.Location = new System.Drawing.Point(260, 121);
            this.txtIdChange.Name = "txtIdChange";
            this.txtIdChange.Size = new System.Drawing.Size(237, 36);
            this.txtIdChange.TabIndex = 14;
            // 
            // comboBoxFacultyChange
            // 
            this.comboBoxFacultyChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBoxFacultyChange.FormattingEnabled = true;
            this.comboBoxFacultyChange.Location = new System.Drawing.Point(8, 260);
            this.comboBoxFacultyChange.Name = "comboBoxFacultyChange";
            this.comboBoxFacultyChange.Size = new System.Drawing.Size(237, 37);
            this.comboBoxFacultyChange.TabIndex = 13;
            // 
            // comboBoxSubjectChange
            // 
            this.comboBoxSubjectChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBoxSubjectChange.FormattingEnabled = true;
            this.comboBoxSubjectChange.Location = new System.Drawing.Point(261, 260);
            this.comboBoxSubjectChange.Name = "comboBoxSubjectChange";
            this.comboBoxSubjectChange.Size = new System.Drawing.Size(235, 37);
            this.comboBoxSubjectChange.TabIndex = 12;
            // 
            // txtNameChange
            // 
            this.txtNameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtNameChange.Location = new System.Drawing.Point(7, 121);
            this.txtNameChange.Name = "txtNameChange";
            this.txtNameChange.Size = new System.Drawing.Size(237, 36);
            this.txtNameChange.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 318);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // classForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.gbChangeClass);
            this.Controls.Add(this.gbAddClass);
            this.Name = "classForm";
            this.Text = "classForm";
            this.Load += new System.EventHandler(this.classForm_Load);
            this.gbAddClass.ResumeLayout(false);
            this.gbAddClass.PerformLayout();
            this.gbOtherOptionAdd.ResumeLayout(false);
            this.groupBoxAddStudent.ResumeLayout(false);
            this.groupBoxAddStudent.PerformLayout();
            this.gbChangeClass.ResumeLayout(false);
            this.gbChangeClass.PerformLayout();
            this.gbOptionChange.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddClass;
        private System.Windows.Forms.TextBox txtNameClassAdd;
        private System.Windows.Forms.ComboBox comboBoxSubjectAdd;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox comboBoxFacultyAdd;
        private System.Windows.Forms.GroupBox gbOtherOptionAdd;
        private System.Windows.Forms.Button btnReturnMenuAdd;
        private System.Windows.Forms.Button btnDeleteClassAdd;
        private System.Windows.Forms.Button btnAddNormalClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtIdClassAdd;
        private System.Windows.Forms.Label labelSubjectAdd;
        private System.Windows.Forms.Label labelFacultyAdd;
        private System.Windows.Forms.Label labelNameAddAdd;
        private System.Windows.Forms.Label labelNameAdd;
        private System.Windows.Forms.GroupBox gbChangeClass;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelSubjectChange;
        private System.Windows.Forms.Label labelFacultyChange;
        private System.Windows.Forms.Label labelIdChange;
        private System.Windows.Forms.Label labelNameChange;
        private System.Windows.Forms.TextBox txtIdChange;
        private System.Windows.Forms.ComboBox comboBoxFacultyChange;
        private System.Windows.Forms.ComboBox comboBoxSubjectChange;
        private System.Windows.Forms.TextBox txtNameChange;
        private System.Windows.Forms.Button btnFindClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Label labelIdFind;
        private System.Windows.Forms.TextBox txtIdFInd;
        private System.Windows.Forms.GroupBox gbOptionChange;
        private System.Windows.Forms.Button btnReturnMenuChange;
        private System.Windows.Forms.Button btnAddClassChange;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}