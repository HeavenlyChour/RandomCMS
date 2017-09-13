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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();

            //This disables the text box for the disability by default and user will only be allowed to enter a value once they have selected yes in the disability radio button.
            txtDisabilityDescription.ReadOnly = true;

            //This is to make the date time picker empty at the beginning of the form
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = " ";
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBox(txtStudentFirstName))
            {
                txtStudentFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtStudentFirstName))
            {
                txtStudentFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateNameFormat(txtStudentFirstName))
            {
                txtStudentFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtStudentLastName))
            {
                txtStudentLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtStudentLastName))
            {
                txtStudentLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateNameFormat(txtStudentLastName))
            {
                txtStudentLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpDateOfBirth))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbMale, rdbFemale))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtStudStreetAddress))
            {
                txtStudStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateStreetAddress(txtStudStreetAddress))
            {
                txtStudStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbStudSuburb))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtStudPostCode))
            {
                txtStudPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtStudPostCode))
            {
                txtStudPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidatePostCode(txtStudPostCode.Text))
            {
                txtStudPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtStudentPhoneNum))
            {
                txtStudentPhoneNum.Focus();
                return;
            }
            if (!clsValidation.ValidatePhoneNumber(txtStudentPhoneNum))
            {
                txtStudentPhoneNum.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtStudentEmail))
            {
                txtStudentEmail.Focus();
                return;
            }
            if (!clsValidation.ValidateEmail(txtStudentEmail))
            {
                txtStudentEmail.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbNationality))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbDisabilityYes, rdbDisabilityNo))
            {
                return;
            }
            if (rdbDisabilityYes.Checked==true)
            {
                txtDisabilityDescription.ReadOnly = false;
                if (!clsValidation.ValidateTextBox(txtDisabilityDescription))
                {
                    return;
                }
            }
            if (rdbDisabilityNo.Checked == true)
            {
                txtDisabilityDescription.Text = String.Empty;
                txtDisabilityDescription.ReadOnly = true;
            }
             MessageBox.Show("Student record successfully added!");            
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string dobSelected = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = dobSelected;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = String.Empty;
            txtStudentFirstName.Text = String.Empty;
            txtStudentLastName.Text = String.Empty;
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = " ";
            if (rdbMale.Checked==true)
            {
                rdbMale.Checked = false;
            }else 
            {
                rdbFemale.Checked = false;
            }
            txtStudStreetAddress.Text = String.Empty;
            cmbStudSuburb.SelectedIndex = -1;
            txtStudPostCode.Text = String.Empty;
            txtStudentPhoneNum.Text = String.Empty;
            txtStudentEmail.Text = String.Empty;
            cmbNationality.SelectedIndex = -1;
            if (rdbDisabilityYes.Checked == true)
            {
                rdbDisabilityYes.Checked = false;
            }
            else
            {
                rdbDisabilityNo.Checked = false;
            }
            txtDisabilityDescription.Text = String.Empty;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
