namespace Presentation
{
    partial class StudentResult
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hireEmployee = new System.Windows.Forms.Button();
            this.rejectEmployee = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.universityInfoTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.education = new System.Windows.Forms.Label();
            this.languages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progLangTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hireEmployee
            // 
            this.hireEmployee.BackColor = System.Drawing.Color.Lime;
            this.hireEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hireEmployee.ForeColor = System.Drawing.Color.Black;
            this.hireEmployee.Location = new System.Drawing.Point(191, 563);
            this.hireEmployee.Name = "hireEmployee";
            this.hireEmployee.Size = new System.Drawing.Size(137, 64);
            this.hireEmployee.TabIndex = 1;
            this.hireEmployee.Text = "Hire";
            this.hireEmployee.UseVisualStyleBackColor = false;
            this.hireEmployee.Click += new System.EventHandler(this.hireEmployee_Click);
            // 
            // rejectEmployee
            // 
            this.rejectEmployee.BackColor = System.Drawing.Color.Red;
            this.rejectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rejectEmployee.ForeColor = System.Drawing.Color.Black;
            this.rejectEmployee.Location = new System.Drawing.Point(9, 563);
            this.rejectEmployee.Name = "rejectEmployee";
            this.rejectEmployee.Size = new System.Drawing.Size(142, 64);
            this.rejectEmployee.TabIndex = 2;
            this.rejectEmployee.Text = "Reject";
            this.rejectEmployee.UseVisualStyleBackColor = false;
            this.rejectEmployee.Click += new System.EventHandler(this.rejectEmployee_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextBox.Location = new System.Drawing.Point(138, 309);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(205, 34);
            this.usernameTextBox.TabIndex = 3;
            // 
            // universityInfoTextBox
            // 
            this.universityInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.universityInfoTextBox.Location = new System.Drawing.Point(138, 359);
            this.universityInfoTextBox.Multiline = true;
            this.universityInfoTextBox.Name = "universityInfoTextBox";
            this.universityInfoTextBox.ReadOnly = true;
            this.universityInfoTextBox.Size = new System.Drawing.Size(202, 33);
            this.universityInfoTextBox.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(12, 309);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 25);
            this.name.TabIndex = 6;
            this.name.Text = "Username";
            // 
            // education
            // 
            this.education.AutoSize = true;
            this.education.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.education.Location = new System.Drawing.Point(12, 359);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(99, 25);
            this.education.TabIndex = 9;
            this.education.Text = "Education";
            // 
            // languages
            // 
            this.languages.AutoSize = true;
            this.languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.languages.Location = new System.Drawing.Point(4, 425);
            this.languages.Name = "languages";
            this.languages.Size = new System.Drawing.Size(128, 25);
            this.languages.TabIndex = 10;
            this.languages.Text = "Programming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Languages";
            // 
            // progLangTextBox
            // 
            this.progLangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progLangTextBox.Location = new System.Drawing.Point(138, 411);
            this.progLangTextBox.Multiline = true;
            this.progLangTextBox.Name = "progLangTextBox";
            this.progLangTextBox.ReadOnly = true;
            this.progLangTextBox.Size = new System.Drawing.Size(202, 116);
            this.progLangTextBox.TabIndex = 12;
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(369, 657);
            this.Controls.Add(this.progLangTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languages);
            this.Controls.Add(this.education);
            this.Controls.Add(this.name);
            this.Controls.Add(this.universityInfoTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.rejectEmployee);
            this.Controls.Add(this.hireEmployee);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentResult";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hireEmployee;
        private System.Windows.Forms.Button rejectEmployee;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox universityInfoTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label education;
        private System.Windows.Forms.Label languages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox progLangTextBox;
    }
}

