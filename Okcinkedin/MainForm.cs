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
    public partial class MainForm : Form
    {
        Operations op = new Operations();
        public MainForm()
        {
            InitializeComponent();
        }

        private void employerLogin_Click(object sender, EventArgs e)
        {
            string username = employerUsername.Text;
            string password = employerPassword.Text;

            bool isSuccess = op.LoginEmployer(username, password);

            if (isSuccess)
            {
                MessageBox.Show("Giriş Başarılı");
                EmployerForm employerForm = new EmployerForm();
                Hide();
                employerForm.Show();
              
                // Giriş başarılı ise yeni bir form açabilir veya işlemleri gerçekleştirebilirsiniz.
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void employerRegister_Click(object sender, EventArgs e)
        {
            string username = employerUsername.Text;
            string password = employerPassword.Text;

            bool isSuccess = op.RegisterEmployer(username, password);

            if (isSuccess)
            {
                MessageBox.Show("Kayıt Başarılı");
                
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void employeeLogin_Click(object sender, EventArgs e)
        {
            string username = employeeUsername.Text;
            string password = employeePassword.Text;

            bool isSuccess = op.LoginEmployee(username, password);

            if (isSuccess)
            {
                MessageBox.Show("Giriş Başarılı");
                Hide();
                // Kullanıcının oturum açtığını varsayalım ve loggedInUsername değişkenini doldur

                // Employee Form'u açalım
                OpenEmployeeForm(username);

                // Giriş başarılı ise yeni bir form açabilir veya işlemleri gerçekleştirebilirsiniz.
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
        private void OpenEmployeeForm(string username)
        {
            // Employee Form'a geçiş işlemleri burada gerçekleştirilir
            EmployeeForm employeeForm = new EmployeeForm(username);
            employeeForm.Show();
        }

        private void employeeRegister_Click(object sender, EventArgs e)
        {
            string username = employeeUsername.Text;
            string password = employeePassword.Text;

            bool isSuccess = op.RegisterEmployee(username, password);

            if (isSuccess)
            {
                MessageBox.Show("Kayıt Başarılı");
                
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

    }
}
