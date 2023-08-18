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
    public partial class EmployerForm : Form
    {
        public EmployerForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            List<string> selectedLanguages = new List<string>();
            foreach (var item in Skills.CheckedItems)
            {
                selectedLanguages.Add(item.ToString());
            }

            StudentResult resultForm = new StudentResult(selectedLanguages);
            resultForm.Show();

        }

        private void employerSaveBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedLanguages = new List<string>();
            foreach (var item in Skills.CheckedItems)
            {
                selectedLanguages.Add(item.ToString());
            }
        }
    }
}
