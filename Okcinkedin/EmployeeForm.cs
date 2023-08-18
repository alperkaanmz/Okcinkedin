using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class EmployeeForm : Form
    {
        Operations op = new Operations();
        private string username;

        public EmployeeForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void employeeSaveBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedLanguages = new List<string>();
            foreach (var item in EmployeeSkills.CheckedItems)
            {
                selectedLanguages.Add(item.ToString());
            }
            if (selectedLanguages.Count > 0)
            {
                bool isSuccess = op.SaveProgrammingLanguages(username, selectedLanguages);

                if (isSuccess)
                {
                    MessageBox.Show("Programlama dilleri kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Programlama dilleri kaydedilemedi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az bir programlama dili seçin.");
            }
        }

        private void employeeContinueButton_Click(object sender, EventArgs e)
        {


        }

        private void submit_Click(object sender, EventArgs e)
        {
            string university = universityTextBox.Text;
            bool isSuccess = op.RegisterUniversity(username, university);

            if (isSuccess)
            {
                MessageBox.Show("Üniversite kaydedildi.");
            }
            else
            {
                MessageBox.Show("Üniversite kaydedilemedi.");
            }
        }
    }
}
