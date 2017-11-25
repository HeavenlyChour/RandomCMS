using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationClass;


namespace CourseManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm objMainForm = new MainForm();
            if (!clsValidation.ValidateTextBox(txtUserName))
            {
                txtUserName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtUserName))
            {
                txtUserName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtPassword))
            {
                txtPassword.Focus();
                return;
            }
            //if (!clsValidation.ValidateTextBoxForNumeric(txtPassword))
            //{
            //    txtPassword.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidateTextBoxLength(txtPassword, 6))
            //{
            //    txtPassword.Focus();
            //    return;
            //}

            if(txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                objMainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            //this.Close();
        }
    }
}
