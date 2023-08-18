using Business;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using DataAccess;

namespace Presentation
{
    public partial class StudentResult : Form
    {
        private List<Employee> matchingEmployees;
        private int currentEmployeeIndex = 0;
        LanguageMatch lm = new LanguageMatch();

        public StudentResult(List<string> selectedLanguages)
        {
            InitializeComponent();
            matchingEmployees = lm.GetMatchingEmployees(selectedLanguages);

            if (matchingEmployees.Count > 0)
            {
                ShowEmployeeInfo(currentEmployeeIndex);
            }
            else
            {
                MessageBox.Show("Hiç eşleşen çalışan bulunamadı.");
                Hide();
            }
        }

        private void ShowEmployeeInfo(int index)
        {
            if (index >= 0 && index < matchingEmployees.Count)
            {
                Employee employee = matchingEmployees[index];

                usernameTextBox.Text = employee.Username;
                universityInfoTextBox.Text = employee.University;
                progLangTextBox.Text = string.Join(", ", employee.ProgrammingLanguages);
            }
        }

        private void hireEmployee_Click(object sender, EventArgs e)
        {
            if (currentEmployeeIndex < matchingEmployees.Count - 1)
            {
                currentEmployeeIndex++;
                ShowEmployeeInfo(currentEmployeeIndex);
            }
            else
            {
                MessageBox.Show("Hiç eşleşen çalışan bulunamadı.");
            }
        }

        private void rejectEmployee_Click(object sender, EventArgs e)
        {
               
        }
    }
}
