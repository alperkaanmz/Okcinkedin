namespace Presentation
{
    partial class EmployerForm
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
            this.Skills = new System.Windows.Forms.CheckedListBox();
            this.selectLang = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.employerSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Skills
            // 
            this.Skills.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skills.FormattingEnabled = true;
            this.Skills.Items.AddRange(new object[] {
            "Java",
            "C#",
            "Javascript",
            "Python",
            "C++"});
            this.Skills.Location = new System.Drawing.Point(12, 54);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(202, 159);
            this.Skills.TabIndex = 0;
            // 
            // selectLang
            // 
            this.selectLang.AutoSize = true;
            this.selectLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectLang.Location = new System.Drawing.Point(12, 9);
            this.selectLang.Name = "selectLang";
            this.selectLang.Size = new System.Drawing.Size(283, 29);
            this.selectLang.TabIndex = 1;
            this.selectLang.Text = "Please select a language";
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.continueButton.Location = new System.Drawing.Point(220, 169);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(127, 44);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // employerSaveBtn
            // 
            this.employerSaveBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.employerSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employerSaveBtn.Location = new System.Drawing.Point(230, 54);
            this.employerSaveBtn.Name = "employerSaveBtn";
            this.employerSaveBtn.Size = new System.Drawing.Size(108, 95);
            this.employerSaveBtn.TabIndex = 3;
            this.employerSaveBtn.Text = "Save";
            this.employerSaveBtn.UseVisualStyleBackColor = false;
            this.employerSaveBtn.Click += new System.EventHandler(this.employerSaveBtn_Click);
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 242);
            this.Controls.Add(this.employerSaveBtn);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.selectLang);
            this.Controls.Add(this.Skills);
            this.Name = "EmployerForm";
            this.Text = "EmployerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Skills;
        private System.Windows.Forms.Label selectLang;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button employerSaveBtn;
    }
}