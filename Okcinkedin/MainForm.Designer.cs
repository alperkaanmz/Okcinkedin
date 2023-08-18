namespace Presentation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployerLoginPanel = new System.Windows.Forms.Panel();
            this.employerPassword = new System.Windows.Forms.TextBox();
            this.employerUsername = new System.Windows.Forms.TextBox();
            this.EmployeeLoginPanel = new System.Windows.Forms.Panel();
            this.employeePassword = new System.Windows.Forms.TextBox();
            this.employeeUsername = new System.Windows.Forms.TextBox();
            this.employerLogin = new System.Windows.Forms.Button();
            this.employerRegister = new System.Windows.Forms.Button();
            this.employeeLogin = new System.Windows.Forms.Button();
            this.employeeRegister = new System.Windows.Forms.Button();
            this.EmployerLoginPanel.SuspendLayout();
            this.EmployeeLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(361, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jobseeker Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELCOME TO OKCINKEDIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employer Part";
            // 
            // EmployerLoginPanel
            // 
            this.EmployerLoginPanel.Controls.Add(this.employerPassword);
            this.EmployerLoginPanel.Controls.Add(this.employerUsername);
            this.EmployerLoginPanel.Location = new System.Drawing.Point(25, 111);
            this.EmployerLoginPanel.Name = "EmployerLoginPanel";
            this.EmployerLoginPanel.Size = new System.Drawing.Size(242, 167);
            this.EmployerLoginPanel.TabIndex = 4;
            // 
            // employerPassword
            // 
            this.employerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employerPassword.Location = new System.Drawing.Point(18, 99);
            this.employerPassword.Multiline = true;
            this.employerPassword.Name = "employerPassword";
            this.employerPassword.PasswordChar = '*';
            this.employerPassword.Size = new System.Drawing.Size(206, 40);
            this.employerPassword.TabIndex = 1;
            // 
            // employerUsername
            // 
            this.employerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employerUsername.Location = new System.Drawing.Point(18, 33);
            this.employerUsername.Multiline = true;
            this.employerUsername.Name = "employerUsername";
            this.employerUsername.Size = new System.Drawing.Size(206, 40);
            this.employerUsername.TabIndex = 0;
            // 
            // EmployeeLoginPanel
            // 
            this.EmployeeLoginPanel.Controls.Add(this.employeePassword);
            this.EmployeeLoginPanel.Controls.Add(this.employeeUsername);
            this.EmployeeLoginPanel.Location = new System.Drawing.Point(324, 111);
            this.EmployeeLoginPanel.Name = "EmployeeLoginPanel";
            this.EmployeeLoginPanel.Size = new System.Drawing.Size(254, 167);
            this.EmployeeLoginPanel.TabIndex = 5;
            // 
            // employeePassword
            // 
            this.employeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeePassword.Location = new System.Drawing.Point(18, 99);
            this.employeePassword.Multiline = true;
            this.employeePassword.Name = "employeePassword";
            this.employeePassword.PasswordChar = '*';
            this.employeePassword.Size = new System.Drawing.Size(214, 39);
            this.employeePassword.TabIndex = 1;
            // 
            // employeeUsername
            // 
            this.employeeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeUsername.Location = new System.Drawing.Point(18, 33);
            this.employeeUsername.Multiline = true;
            this.employeeUsername.Name = "employeeUsername";
            this.employeeUsername.Size = new System.Drawing.Size(214, 39);
            this.employeeUsername.TabIndex = 0;
            // 
            // employerLogin
            // 
            this.employerLogin.Location = new System.Drawing.Point(155, 297);
            this.employerLogin.Name = "employerLogin";
            this.employerLogin.Size = new System.Drawing.Size(103, 36);
            this.employerLogin.TabIndex = 6;
            this.employerLogin.Text = "Login";
            this.employerLogin.UseVisualStyleBackColor = true;
            this.employerLogin.Click += new System.EventHandler(this.employerLogin_Click);
            // 
            // employerRegister
            // 
            this.employerRegister.Location = new System.Drawing.Point(34, 297);
            this.employerRegister.Name = "employerRegister";
            this.employerRegister.Size = new System.Drawing.Size(103, 36);
            this.employerRegister.TabIndex = 7;
            this.employerRegister.Text = "Register";
            this.employerRegister.UseVisualStyleBackColor = true;
            this.employerRegister.Click += new System.EventHandler(this.employerRegister_Click);
            // 
            // employeeLogin
            // 
            this.employeeLogin.Location = new System.Drawing.Point(475, 297);
            this.employeeLogin.Name = "employeeLogin";
            this.employeeLogin.Size = new System.Drawing.Size(103, 36);
            this.employeeLogin.TabIndex = 8;
            this.employeeLogin.Text = "Login";
            this.employeeLogin.UseVisualStyleBackColor = true;
            this.employeeLogin.Click += new System.EventHandler(this.employeeLogin_Click);
            // 
            // employeeRegister
            // 
            this.employeeRegister.Location = new System.Drawing.Point(338, 297);
            this.employeeRegister.Name = "employeeRegister";
            this.employeeRegister.Size = new System.Drawing.Size(103, 36);
            this.employeeRegister.TabIndex = 9;
            this.employeeRegister.Text = "Register";
            this.employeeRegister.UseVisualStyleBackColor = true;
            this.employeeRegister.Click += new System.EventHandler(this.employeeRegister_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 388);
            this.Controls.Add(this.EmployerLoginPanel);
            this.Controls.Add(this.employerRegister);
            this.Controls.Add(this.employeeRegister);
            this.Controls.Add(this.employerLogin);
            this.Controls.Add(this.EmployeeLoginPanel);
            this.Controls.Add(this.employeeLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.EmployerLoginPanel.ResumeLayout(false);
            this.EmployerLoginPanel.PerformLayout();
            this.EmployeeLoginPanel.ResumeLayout(false);
            this.EmployeeLoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel EmployerLoginPanel;
        private System.Windows.Forms.TextBox employerPassword;
        private System.Windows.Forms.TextBox employerUsername;
        private System.Windows.Forms.Panel EmployeeLoginPanel;
        private System.Windows.Forms.TextBox employeePassword;
        private System.Windows.Forms.TextBox employeeUsername;
        private System.Windows.Forms.Button employerLogin;
        private System.Windows.Forms.Button employerRegister;
        private System.Windows.Forms.Button employeeLogin;
        private System.Windows.Forms.Button employeeRegister;
    }
}