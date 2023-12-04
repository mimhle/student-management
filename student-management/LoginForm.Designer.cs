namespace studentManagement {
    partial class LoginForm {
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.btnClass = new System.Windows.Forms.Button();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnExit);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtPassWord);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbLogin.Location = new System.Drawing.Point(225, 133);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(603, 410);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(326, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(81, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPassWord.Location = new System.Drawing.Point(118, 205);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(313, 45);
            this.txtPassWord.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtUserName.Location = new System.Drawing.Point(118, 126);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(313, 45);
            this.txtUserName.TabIndex = 0;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.gbSubject);
            this.gbMenu.Controls.Add(this.btnLogout);
            this.gbMenu.Controls.Add(this.gbClass);
            this.gbMenu.Controls.Add(this.gbStudent);
            this.gbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbMenu.Location = new System.Drawing.Point(12, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(1018, 704);
            this.gbMenu.TabIndex = 1;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu chức năng";
            this.gbMenu.Visible = false;
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.btnSubject);
            this.gbSubject.Location = new System.Drawing.Point(6, 439);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(1006, 195);
            this.gbSubject.TabIndex = 1;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Môn học";
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(29, 39);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(961, 137);
            this.btnSubject.TabIndex = 6;
            this.btnSubject.Text = "Chỉnh Sửa Môn Học";
            this.btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(410, 649);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.btnClass);
            this.gbClass.Location = new System.Drawing.Point(6, 238);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(1006, 195);
            this.gbClass.TabIndex = 1;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Lớp Học";
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(23, 38);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(961, 151);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Chỉnh Sửa Lớp Học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.btnStudent);
            this.gbStudent.Location = new System.Drawing.Point(6, 33);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(1006, 195);
            this.gbStudent.TabIndex = 0;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Sinh Viên";
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(23, 38);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(961, 151);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Chỉnh Sửa Sinh Viên";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.gbLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.gbSubject.ResumeLayout(false);
            this.gbClass.ResumeLayout(false);
            this.gbStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnSubject;
    }
}