namespace studentManagement {
    partial class StudentForm {
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.labelSex = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.checkBoxClassMonitor = new System.Windows.Forms.CheckBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageFind = new System.Windows.Forms.TabPage();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboLefBoxClass = new System.Windows.Forms.ComboBox();
            this.comboLefFaculty = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdFind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.btnReturnToFind = new System.Windows.Forms.Button();
            this.btnUpdates = new System.Windows.Forms.Button();
            this.comboBoxClassEdit = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioFemaleEdit = new System.Windows.Forms.RadioButton();
            this.radioMaleEdit = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFacultyEdit = new System.Windows.Forms.ComboBox();
            this.birthEdit = new System.Windows.Forms.DateTimePicker();
            this.txtNameEdit = new System.Windows.Forms.TextBox();
            this.checkBoxClassMonitorEdit = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.groupBoxAddStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageFind.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAdd);
            this.tabControl.Controls.Add(this.tabPageFind);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1042, 728);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.groupBoxAddStudent);
            this.tabPageAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdd.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1034, 695);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Thêm sinh viên";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Controls.Add(this.comboBoxClass);
            this.groupBoxAddStudent.Controls.Add(this.btnInput);
            this.groupBoxAddStudent.Controls.Add(this.btnReturn);
            this.groupBoxAddStudent.Controls.Add(this.panel1);
            this.groupBoxAddStudent.Controls.Add(this.comboBoxFaculty);
            this.groupBoxAddStudent.Controls.Add(this.birth);
            this.groupBoxAddStudent.Controls.Add(this.txtName);
            this.groupBoxAddStudent.Controls.Add(this.txtId);
            this.groupBoxAddStudent.Controls.Add(this.checkBoxClassMonitor);
            this.groupBoxAddStudent.Controls.Add(this.labelClass);
            this.groupBoxAddStudent.Controls.Add(this.labelFaculty);
            this.groupBoxAddStudent.Controls.Add(this.label6);
            this.groupBoxAddStudent.Controls.Add(this.labelName);
            this.groupBoxAddStudent.Controls.Add(this.labelDateOfBirth);
            this.groupBoxAddStudent.Controls.Add(this.labelId);
            this.groupBoxAddStudent.Controls.Add(this.label1);
            this.groupBoxAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBoxAddStudent.Location = new System.Drawing.Point(-4, -29);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(1038, 730);
            this.groupBoxAddStudent.TabIndex = 1;
            this.groupBoxAddStudent.TabStop = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(46, 514);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(366, 39);
            this.comboBoxClass.TabIndex = 20;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(652, 631);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(146, 47);
            this.btnInput.TabIndex = 19;
            this.btnInput.Text = "Nhập";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(834, 631);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 47);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioBtnFemale);
            this.panel1.Controls.Add(this.radioBtnMale);
            this.panel1.Controls.Add(this.labelSex);
            this.panel1.Location = new System.Drawing.Point(560, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 135);
            this.panel1.TabIndex = 17;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFemale.Location = new System.Drawing.Point(130, 72);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(58, 29);
            this.radioBtnFemale.TabIndex = 10;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Nữ";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMale.Location = new System.Drawing.Point(27, 72);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(74, 29);
            this.radioBtnMale.TabIndex = 9;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Nam";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelSex.Location = new System.Drawing.Point(22, 10);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(106, 29);
            this.labelSex.TabIndex = 4;
            this.labelSex.Text = "Giới tính";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(46, 321);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(366, 39);
            this.comboBoxFaculty.TabIndex = 16;
            this.comboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaculty_SelectedIndexChanged);
            // 
            // birth
            // 
            this.birth.CustomFormat = "MM/dd/yyyy";
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birth.Location = new System.Drawing.Point(575, 321);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(405, 34);
            this.birth.TabIndex = 14;
            this.birth.Value = new System.DateTime(2023, 12, 6, 20, 53, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(569, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 38);
            this.txtName.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(46, 178);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 38);
            this.txtId.TabIndex = 12;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // checkBoxClassMonitor
            // 
            this.checkBoxClassMonitor.AutoSize = true;
            this.checkBoxClassMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClassMonitor.Location = new System.Drawing.Point(46, 591);
            this.checkBoxClassMonitor.Name = "checkBoxClassMonitor";
            this.checkBoxClassMonitor.Size = new System.Drawing.Size(127, 29);
            this.checkBoxClassMonitor.TabIndex = 11;
            this.checkBoxClassMonitor.Text = "Lớp trưởng";
            this.checkBoxClassMonitor.UseVisualStyleBackColor = true;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelClass.Location = new System.Drawing.Point(41, 456);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(55, 29);
            this.labelClass.TabIndex = 7;
            this.labelClass.Text = "Lớp";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelFaculty.Location = new System.Drawing.Point(41, 262);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(72, 29);
            this.labelFaculty.TabIndex = 6;
            this.labelFaculty.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(667, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelName.Location = new System.Drawing.Point(564, 132);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 29);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Họ và tên";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(564, 262);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(126, 29);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "Ngày sinh";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelId.Location = new System.Drawing.Point(41, 132);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(190, 29);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Mã số sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(264, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập các của thông tin sinh viên";
            // 
            // tabPageFind
            // 
            this.tabPageFind.Controls.Add(this.groupBoxFind);
            this.tabPageFind.Controls.Add(this.groupBoxEdit);
            this.tabPageFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageFind.Location = new System.Drawing.Point(4, 29);
            this.tabPageFind.Name = "tabPageFind";
            this.tabPageFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFind.Size = new System.Drawing.Size(1034, 695);
            this.tabPageFind.TabIndex = 2;
            this.tabPageFind.Text = "Tìm sinh viên";
            this.tabPageFind.UseVisualStyleBackColor = true;
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFind.Controls.Add(this.radioButtonId);
            this.groupBoxFind.Controls.Add(this.radioButtonName);
            this.groupBoxFind.Controls.Add(this.label13);
            this.groupBoxFind.Controls.Add(this.label8);
            this.groupBoxFind.Controls.Add(this.comboLefBoxClass);
            this.groupBoxFind.Controls.Add(this.comboLefFaculty);
            this.groupBoxFind.Controls.Add(this.btnDelete);
            this.groupBoxFind.Controls.Add(this.label2);
            this.groupBoxFind.Controls.Add(this.btnFind);
            this.groupBoxFind.Controls.Add(this.listViewDisplay);
            this.groupBoxFind.Controls.Add(this.btnEdit);
            this.groupBoxFind.Controls.Add(this.button1);
            this.groupBoxFind.Controls.Add(this.txtIdFind);
            this.groupBoxFind.Controls.Add(this.label5);
            this.groupBoxFind.Controls.Add(this.label9);
            this.groupBoxFind.Controls.Add(this.label10);
            this.groupBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBoxFind.Location = new System.Drawing.Point(-4, -29);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(1042, 724);
            this.groupBoxFind.TabIndex = 2;
            this.groupBoxFind.TabStop = false;
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonId.Location = new System.Drawing.Point(158, 190);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(199, 33);
            this.radioButtonId.TabIndex = 29;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "Mã số sinh viên";
            this.radioButtonId.UseVisualStyleBackColor = true;
            this.radioButtonId.CheckedChanged += new System.EventHandler(this.radioButtonId_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonName.Location = new System.Drawing.Point(44, 190);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(77, 33);
            this.radioButtonName.TabIndex = 28;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Tên";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(723, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(458, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Khoa";
            // 
            // comboLefBoxClass
            // 
            this.comboLefBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLefBoxClass.FormattingEnabled = true;
            this.comboLefBoxClass.Location = new System.Drawing.Point(728, 239);
            this.comboLefBoxClass.Name = "comboLefBoxClass";
            this.comboLefBoxClass.Size = new System.Drawing.Size(245, 37);
            this.comboLefBoxClass.TabIndex = 25;
            // 
            // comboLefFaculty
            // 
            this.comboLefFaculty.BackColor = System.Drawing.SystemColors.Window;
            this.comboLefFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLefFaculty.FormattingEnabled = true;
            this.comboLefFaculty.Location = new System.Drawing.Point(463, 239);
            this.comboLefFaculty.Name = "comboLefFaculty";
            this.comboLefFaculty.Size = new System.Drawing.Size(245, 37);
            this.comboLefFaculty.TabIndex = 24;
            this.comboLefFaculty.SelectedIndexChanged += new System.EventHandler(this.comboLefFaculty_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(210, 640);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 38);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(39, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Thông tin";
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(826, 300);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(147, 38);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(44, 353);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(929, 261);
            this.listViewDisplay.TabIndex = 20;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.SelectedIndexChanged += new System.EventHandler(this.listViewDisplay_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(44, 640);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 38);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(839, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtIdFind
            // 
            this.txtIdFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdFind.Enabled = false;
            this.txtIdFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFind.Location = new System.Drawing.Point(44, 239);
            this.txtIdFind.Name = "txtIdFind";
            this.txtIdFind.Size = new System.Drawing.Size(341, 38);
            this.txtIdFind.TabIndex = 12;
            this.txtIdFind.TextChanged += new System.EventHandler(this.txtIdFind_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(667, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(39, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tìm sinh viên theo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(264, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Thông tin sinh viên";
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.btnReturnToFind);
            this.groupBoxEdit.Controls.Add(this.btnUpdates);
            this.groupBoxEdit.Controls.Add(this.comboBoxClassEdit);
            this.groupBoxEdit.Controls.Add(this.button2);
            this.groupBoxEdit.Controls.Add(this.panel2);
            this.groupBoxEdit.Controls.Add(this.comboBoxFacultyEdit);
            this.groupBoxEdit.Controls.Add(this.birthEdit);
            this.groupBoxEdit.Controls.Add(this.txtNameEdit);
            this.groupBoxEdit.Controls.Add(this.checkBoxClassMonitorEdit);
            this.groupBoxEdit.Controls.Add(this.label4);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Controls.Add(this.label11);
            this.groupBoxEdit.Controls.Add(this.label12);
            this.groupBoxEdit.Controls.Add(this.label14);
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBoxEdit.Location = new System.Drawing.Point(-4, -29);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(1038, 738);
            this.groupBoxEdit.TabIndex = 23;
            this.groupBoxEdit.TabStop = false;
            // 
            // btnReturnToFind
            // 
            this.btnReturnToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToFind.Location = new System.Drawing.Point(232, 618);
            this.btnReturnToFind.Name = "btnReturnToFind";
            this.btnReturnToFind.Size = new System.Drawing.Size(272, 50);
            this.btnReturnToFind.TabIndex = 21;
            this.btnReturnToFind.Text = "Quay lại tìm kiếm";
            this.btnReturnToFind.UseVisualStyleBackColor = true;
            this.btnReturnToFind.Click += new System.EventHandler(this.btnReturnToFind_Click);
            // 
            // btnUpdates
            // 
            this.btnUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdates.Location = new System.Drawing.Point(67, 620);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(146, 47);
            this.btnUpdates.TabIndex = 20;
            this.btnUpdates.Text = "Cập nhật";
            this.btnUpdates.UseVisualStyleBackColor = true;
            this.btnUpdates.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // comboBoxClassEdit
            // 
            this.comboBoxClassEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClassEdit.FormattingEnabled = true;
            this.comboBoxClassEdit.Location = new System.Drawing.Point(573, 322);
            this.comboBoxClassEdit.Name = "comboBoxClassEdit";
            this.comboBoxClassEdit.Size = new System.Drawing.Size(366, 39);
            this.comboBoxClassEdit.TabIndex = 19;
            this.comboBoxClassEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassEdit_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(836, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioFemaleEdit);
            this.panel2.Controls.Add(this.radioMaleEdit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(67, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 135);
            this.panel2.TabIndex = 17;
            // 
            // radioFemaleEdit
            // 
            this.radioFemaleEdit.AutoSize = true;
            this.radioFemaleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemaleEdit.Location = new System.Drawing.Point(130, 72);
            this.radioFemaleEdit.Name = "radioFemaleEdit";
            this.radioFemaleEdit.Size = new System.Drawing.Size(58, 29);
            this.radioFemaleEdit.TabIndex = 10;
            this.radioFemaleEdit.TabStop = true;
            this.radioFemaleEdit.Text = "Nữ";
            this.radioFemaleEdit.UseVisualStyleBackColor = true;
            // 
            // radioMaleEdit
            // 
            this.radioMaleEdit.AutoSize = true;
            this.radioMaleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMaleEdit.Location = new System.Drawing.Point(27, 72);
            this.radioMaleEdit.Name = "radioMaleEdit";
            this.radioMaleEdit.Size = new System.Drawing.Size(74, 29);
            this.radioMaleEdit.TabIndex = 9;
            this.radioMaleEdit.TabStop = true;
            this.radioMaleEdit.Text = "Nam";
            this.radioMaleEdit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(22, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // comboBoxFacultyEdit
            // 
            this.comboBoxFacultyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyEdit.FormattingEnabled = true;
            this.comboBoxFacultyEdit.Location = new System.Drawing.Point(573, 178);
            this.comboBoxFacultyEdit.Name = "comboBoxFacultyEdit";
            this.comboBoxFacultyEdit.Size = new System.Drawing.Size(366, 39);
            this.comboBoxFacultyEdit.TabIndex = 16;
            this.comboBoxFacultyEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultyEdit_SelectedIndexChanged);
            // 
            // birthEdit
            // 
            this.birthEdit.CustomFormat = "MM/dd/yyyy";
            this.birthEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthEdit.Location = new System.Drawing.Point(67, 322);
            this.birthEdit.Name = "birthEdit";
            this.birthEdit.Size = new System.Drawing.Size(405, 34);
            this.birthEdit.TabIndex = 14;
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEdit.Location = new System.Drawing.Point(67, 179);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(411, 38);
            this.txtNameEdit.TabIndex = 13;
            // 
            // checkBoxClassMonitorEdit
            // 
            this.checkBoxClassMonitorEdit.AutoSize = true;
            this.checkBoxClassMonitorEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClassMonitorEdit.Location = new System.Drawing.Point(573, 399);
            this.checkBoxClassMonitorEdit.Name = "checkBoxClassMonitorEdit";
            this.checkBoxClassMonitorEdit.Size = new System.Drawing.Size(127, 29);
            this.checkBoxClassMonitorEdit.TabIndex = 11;
            this.checkBoxClassMonitorEdit.Text = "Lớp trưởng";
            this.checkBoxClassMonitorEdit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(568, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(568, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên Khoa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(70, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Họ và tên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(65, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ngày sinh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.Location = new System.Drawing.Point(264, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(454, 39);
            this.label14.TabIndex = 0;
            this.label14.Text = "Chỉnh sửa thông tin sinh viên";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.tabControl);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.groupBoxAddStudent.ResumeLayout(false);
            this.groupBoxAddStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageFind.ResumeLayout(false);
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox checkBoxClassMonitor;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageFind;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button btnReturnToFind;
        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.ComboBox comboBoxClassEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioFemaleEdit;
        private System.Windows.Forms.RadioButton radioMaleEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFacultyEdit;
        private System.Windows.Forms.DateTimePicker birthEdit;
        private System.Windows.Forms.TextBox txtNameEdit;
        private System.Windows.Forms.CheckBox checkBoxClassMonitorEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboLefBoxClass;
        private System.Windows.Forms.ComboBox comboLefFaculty;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonName;
    }
}