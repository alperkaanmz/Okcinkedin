namespace Presentation
{
    partial class EmployeeForm
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
            this.EmployeeSkills = new System.Windows.Forms.CheckedListBox();
            this.employeeSaveBtn = new System.Windows.Forms.Button();
            this.employeeContinueButton = new System.Windows.Forms.Button();
            this.empSelectLang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeSkills
            // 
            this.EmployeeSkills.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeSkills.FormattingEnabled = true;
            this.EmployeeSkills.Items.AddRange(new object[] {
            "Java",
            "C#",
            "Javascript",
            "Python",
            "C++"});
            this.EmployeeSkills.Location = new System.Drawing.Point(12, 161);
            this.EmployeeSkills.Name = "EmployeeSkills";
            this.EmployeeSkills.Size = new System.Drawing.Size(202, 159);
            this.EmployeeSkills.TabIndex = 1;
            // 
            // employeeSaveBtn
            // 
            this.employeeSaveBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.employeeSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeSaveBtn.Location = new System.Drawing.Point(229, 161);
            this.employeeSaveBtn.Name = "employeeSaveBtn";
            this.employeeSaveBtn.Size = new System.Drawing.Size(108, 95);
            this.employeeSaveBtn.TabIndex = 4;
            this.employeeSaveBtn.Text = "Save";
            this.employeeSaveBtn.UseVisualStyleBackColor = false;
            this.employeeSaveBtn.Click += new System.EventHandler(this.employeeSaveBtn_Click);
            // 
            // employeeContinueButton
            // 
            this.employeeContinueButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.employeeContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeContinueButton.Location = new System.Drawing.Point(220, 276);
            this.employeeContinueButton.Name = "employeeContinueButton";
            this.employeeContinueButton.Size = new System.Drawing.Size(127, 44);
            this.employeeContinueButton.TabIndex = 5;
            this.employeeContinueButton.Text = "Continue";
            this.employeeContinueButton.UseVisualStyleBackColor = false;
            this.employeeContinueButton.Click += new System.EventHandler(this.employeeContinueButton_Click);
            // 
            // empSelectLang
            // 
            this.empSelectLang.AutoSize = true;
            this.empSelectLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.empSelectLang.Location = new System.Drawing.Point(12, 105);
            this.empSelectLang.Name = "empSelectLang";
            this.empSelectLang.Size = new System.Drawing.Size(283, 29);
            this.empSelectLang.TabIndex = 6;
            this.empSelectLang.Text = "Please select a language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Write your University.";
            // 
            // universityTextBox
            // 
            this.universityTextBox.Location = new System.Drawing.Point(17, 59);
            this.universityTextBox.Multiline = true;
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(232, 34);
            this.universityTextBox.TabIndex = 8;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submit.Location = new System.Drawing.Point(255, 49);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(82, 53);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 346);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.universityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empSelectLang);
            this.Controls.Add(this.employeeContinueButton);
            this.Controls.Add(this.employeeSaveBtn);
            this.Controls.Add(this.EmployeeSkills);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox EmployeeSkills;
        private System.Windows.Forms.Button employeeSaveBtn;
        private System.Windows.Forms.Button employeeContinueButton;
        private System.Windows.Forms.Label empSelectLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox universityTextBox;
        private System.Windows.Forms.Button submit;
    }
}