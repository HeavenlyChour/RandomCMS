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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();

            //This is to make the date time picker empty at the beginning of the form
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = " ";
            dtpCommencementDate.Format = DateTimePickerFormat.Custom;
            dtpCommencementDate.CustomFormat = " ";
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBox(txtTeacherFirstName))
            {
                txtTeacherFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtTeacherFirstName))
            {
                txtTeacherFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateNameFormat(txtTeacherFirstName))
            {
                txtTeacherFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherLastName))
            {
                txtTeacherLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtTeacherLastName))
            {
                txtTeacherLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateNameFormat(txtTeacherLastName))
            {
                txtTeacherLastName.Focus();
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
            if (!clsValidation.ValidateTextBox(txtTeachStreetAddress))
            {
                txtTeachStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateStreetAddress(txtTeachStreetAddress))
            {
                txtTeachStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbTeachSuburb))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeachPostCode))
            {
                txtTeachPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeachPostCode))
            {
                txtTeachPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidatePostCode(txtTeachPostCode.Text))
            {
                txtTeachPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherPhoneNum))
            {
                txtTeacherPhoneNum.Focus();
                return;
            }
            if (!clsValidation.ValidatePhoneNumber(txtTeacherPhoneNum))
            {
                txtTeacherPhoneNum.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherEmail))
            {
                txtTeacherEmail.Focus();
                return;
            }
            if (!clsValidation.ValidateEmail(txtTeacherEmail))
            {
                txtTeacherEmail.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpCommencementDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpDateOfBirth, dtpCommencementDate))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbTeachDepartment))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherSkills))
            {
                txtTeacherSkills.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtTeacherSkills))
            {
                txtTeacherSkills.Focus();
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbASYes, rdbASNo))
            {
                return;
            }
            #endregion

            string genderText = String.Empty;
            if (rdbMale.Checked)
            {
                genderText = "m";
            }
            else if (rdbFemale.Checked)
            {
                genderText = "f";
            }
            string leaveText = String.Empty;
            if (rdbASYes.Checked)
            {
                leaveText = "Yes";
            }
            else if (rdbASNo.Checked)
            {
                leaveText = "No";
            }
            clsTeacher objTeacher = new clsTeacher(txtTeacherFirstName.Text,
                  txtTeacherLastName.Text, dtpDateOfBirth.Value.Date, genderText, txtTeachStreetAddress.Text,
                  cmbTeachSuburb.Text, txtTeachPostCode.Text, txtTeacherPhoneNum.Text, txtTeacherEmail.Text,
                  dtpCommencementDate.Value.Date, cmbClassTaught.Text, txtTeacherSkills.Text, leaveText);
            objTeacher.AddTeacher();
            MessageBox.Show("Teacher record successfully added!");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherID))
            {
                txtTeacherID.Focus();
                return;
            }
            clsTeacher objTeacher = new clsTeacher(Convert.ToInt32(txtTeacherID.Text));
            objTeacher.DeleteTeacher();
            MessageBox.Show("Teacher record successfully deleted");
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBox(txtTeacherFirstName))
            {
                txtTeacherFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtTeacherFirstName))
            {
                txtTeacherFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateNameFormat(txtTeacherFirstName))
            {
                txtTeacherFirstName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherLastName))
            {
                txtTeacherLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtTeacherLastName))
            {
                txtTeacherLastName.Focus();
                return;
            }
            if (!clsValidation.ValidateNameFormat(txtTeacherLastName))
            {
                txtTeacherLastName.Focus();
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
            if (!clsValidation.ValidateTextBox(txtTeachStreetAddress))
            {
                txtTeachStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateStreetAddress(txtTeachStreetAddress))
            {
                txtTeachStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbTeachSuburb))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeachPostCode))
            {
                txtTeachPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeachPostCode))
            {
                txtTeachPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidatePostCode(txtTeachPostCode.Text))
            {
                txtTeachPostCode.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherPhoneNum))
            {
                txtTeacherPhoneNum.Focus();
                return;
            }
            if (!clsValidation.ValidatePhoneNumber(txtTeacherPhoneNum))
            {
                txtTeacherPhoneNum.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherEmail))
            {
                txtTeacherEmail.Focus();
                return;
            }
            if (!clsValidation.ValidateEmail(txtTeacherEmail))
            {
                txtTeacherEmail.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpCommencementDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpDateOfBirth, dtpCommencementDate))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbTeachDepartment))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtTeacherSkills))
            {
                txtTeacherSkills.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtTeacherSkills))
            {
                txtTeacherSkills.Focus();
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbASYes, rdbASNo))
            {
                return;
            }
            #endregion
            string genderText = String.Empty;
            if (rdbMale.Checked)
            {
                genderText = "m";
            }
            else if (rdbFemale.Checked)
            {
                genderText = "f";
            }
            string leaveText = String.Empty;
            if (rdbASYes.Checked)
            {
                leaveText = "Yes";
            }
            else if (rdbASNo.Checked)
            {
                leaveText = "No";
            }
            clsTeacher objTeacher = new clsTeacher(Convert.ToInt32(txtTeacherID.Text), txtTeacherFirstName.Text,
                  txtTeacherLastName.Text, dtpDateOfBirth.Value.Date, genderText, txtTeachStreetAddress.Text,
                  cmbTeachSuburb.Text, txtTeachPostCode.Text, txtTeacherPhoneNum.Text, txtTeacherEmail.Text,
                  dtpCommencementDate.Value.Date, cmbClassTaught.Text, txtTeacherSkills.Text, leaveText);
            objTeacher.UpdateTeacher();
            MessageBox.Show("Teacher record successfully updated!");
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string dobSelected = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = dobSelected;
        }
        private void dtpCommencementDate_ValueChanged(object sender, EventArgs e)
        {            
            string commDateSelected = dtpCommencementDate.Value.ToString("yyyy-MM-dd");
            dtpCommencementDate.Format = DateTimePickerFormat.Custom;
            dtpCommencementDate.CustomFormat = commDateSelected;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtTeacherID.Text = String.Empty;
            txtTeacherFirstName.Text = String.Empty;
            txtTeacherLastName.Text = String.Empty;
            dtpDateOfBirth.Format= DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = " ";
            if (rdbMale.Checked==true)
            {
                rdbMale.Checked = false;
            }
            else
            {
                rdbFemale.Checked = false;
            }
            txtTeachStreetAddress.Text = String.Empty;
            cmbTeachSuburb.SelectedIndex = -1;
            txtTeachPostCode.Text = String.Empty;
            txtTeacherPhoneNum.Text = String.Empty;
            txtTeacherEmail.Text = String.Empty;
            dtpCommencementDate.Format = DateTimePickerFormat.Custom;
            dtpCommencementDate.CustomFormat = " ";
            cmbTeachDepartment.SelectedIndex = -1;
            cmbClassTaught.SelectedIndex = -1;
            txtTeacherSkills.Text = String.Empty;
            if (rdbASYes.Checked == true)
            {
                rdbASYes.Checked = false;
            }
            else
            {
                rdbASNo.Checked = false;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
