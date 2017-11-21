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
            if (!clsValidation.ValidateTextBox(txtTeacherStreetAddress))
            {
                txtTeacherStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateStreetAddress(txtTeacherStreetAddress))
            {
                txtTeacherStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbSuburbName))
            {
                return;
            }
            //if (!clsValidation.ValidateTextBox(txtTeacherPostCode))
            //{
            //    txtTeacherPostCode.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherPostCode))
            //{
            //    txtTeacherPostCode.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidatePostCode(txtTeacherPostCode.Text))
            //{
            //    txtTeacherPostCode.Focus();
            //    return;
            //}
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
            if (!clsValidation.ValidateComboBox(cmbTeacherDepartment))
            {
                return;
            }
            //if (!clsValidation.ValidateTextBox(txtTeacherSkills))
            //{
            //    txtTeacherSkills.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidateForAlphabet(txtTeacherSkills))
            //{
            //    txtTeacherSkills.Focus();
            //    return;
            //}
            if (!clsValidation.ValidateRadioButton(rdbASYes, rdbASNo))
            {
                return;
            }
            #endregion

            string genderText = String.Empty;
            if (rdbMale.Checked)
            {
                genderText = "M";
            }
            else if (rdbFemale.Checked)
            {
                genderText = "F";
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
                  txtTeacherLastName.Text, genderText, dtpDateOfBirth.Value.ToString("yyyy-MM-dd"), txtTeacherStreetAddress.Text,
                  Convert.ToInt32(cmbSuburbID.Text), cmbPostCode.Text, txtTeacherPhoneNum.Text, txtTeacherEmail.Text,
                  dtpCommencementDate.Value.ToString("yyyy-MM-dd"), cmbTeacherDepartment.Text, leaveText);
            objTeacher.Add();
            MessageBox.Show("Teacher record successfully added!");
            objTeacher.ViewAll(dgvTeacher);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherID))
            {
                txtTeacherID.Focus();
                return;
            }
            clsTeacher objTeacher = new clsTeacher(Convert.ToInt32(txtTeacherID.Text));
            objTeacher.Delete();
            MessageBox.Show("Teacher record successfully deleted");
            objTeacher.ViewAll(dgvTeacher);
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
            if (!clsValidation.ValidateTextBox(txtTeacherStreetAddress))
            {
                txtTeacherStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateStreetAddress(txtTeacherStreetAddress))
            {
                txtTeacherStreetAddress.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbSuburbName))
            {
                return;
            }
            //if (!clsValidation.ValidateTextBox(txtTeacherPostCode))
            //{
            //    txtTeacherPostCode.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherPostCode))
            //{
            //    txtTeacherPostCode.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidatePostCode(txtTeacherPostCode.Text))
            //{
            //    txtTeacherPostCode.Focus();
            //    return;
            //}
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
            if (!clsValidation.ValidateComboBox(cmbTeacherDepartment))
            {
                return;
            }
            //if (!clsValidation.ValidateTextBox(txtTeacherSkills))
            //{
            //    txtTeacherSkills.Focus();
            //    return;
            //}
            //if (!clsValidation.ValidateForAlphabet(txtTeacherSkills))
            //{
            //    txtTeacherSkills.Focus();
            //    return;
            //}
            if (!clsValidation.ValidateRadioButton(rdbASYes, rdbASNo))
            {
                return;
            }
            #endregion
            string genderText = String.Empty;
            if (rdbMale.Checked)
            {
                genderText = "M";
            }
            else if (rdbFemale.Checked)
            {
                genderText = "F";
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
                  txtTeacherLastName.Text, genderText, dtpDateOfBirth.Value.ToString("yyyy-MM-dd"), txtTeacherStreetAddress.Text,
                  Convert.ToInt32(cmbSuburbID.Text), cmbPostCode.Text, txtTeacherPhoneNum.Text, txtTeacherEmail.Text,
                  dtpCommencementDate.Value.ToString("yyyy-MM-dd"), cmbTeacherDepartment.Text, leaveText);
            objTeacher.Update();
            MessageBox.Show("Teacher record successfully updated!");
            objTeacher.ViewAll(dgvTeacher);
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherID))
            {
                txtTeacherID.Focus();
                return;
            }
            clsTeacher objTeacher = new clsTeacher(Convert.ToInt32(txtTeacherID.Text));

            bool valid = objTeacher.Search();
            if (valid)
            {
                txtTeacherFirstName.Text = objTeacher.FirstName;
                txtTeacherLastName.Text = objTeacher.LastName;
                if (objTeacher.Gender == "m" || objTeacher.Gender == "M")
                {
                    rdbMale.Checked = true;
                }
                else if (objTeacher.Gender == "f" || objTeacher.Gender == "F")
                {
                    rdbFemale.Checked = true;
                }
                dtpDateOfBirth.Value = DateTime.Parse(objTeacher.DateOfBirth);
                txtTeacherStreetAddress.Text = objTeacher.StreetAddress;
                cmbSuburbID.Text = objTeacher.SuburbID.ToString();
                cmbSuburbName.Text = objTeacher.SuburbName;
                cmbPostCode.Text = objTeacher.PostCode;
                //txtStudPostCode.Text = objStudent.PostCode;
                txtTeacherPhoneNum.Text = objTeacher.PhoneNumber;
                txtTeacherEmail.Text = objTeacher.Email;
                dtpCommencementDate.Value = DateTime.Parse(objTeacher.CommencementDate);
                cmbTeacherDepartment.Text = objTeacher.Department;
                //txtTeacherSkills.Text = objTeacher.Skills;
                if (objTeacher.Leave == "Yes")
                {
                    rdbASYes.Checked = true;
                }
                else if (objTeacher.Leave == "No")
                {
                    rdbASNo.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("This teacher code does not exist.");
            }
        }
        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsTeacher objTeacher = new clsTeacher();
            objTeacher.ViewAll(dgvTeacher);
        }
        
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            clsTeacher objTeacher = new clsTeacher();
            ComboBox[] cmb = new ComboBox[] { cmbSuburbID, cmbSuburbName, cmbPostCode };
            objTeacher.Load(cmb);
            objTeacher.ViewAll(dgvTeacher);
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
            txtTeacherStreetAddress.Text = String.Empty;
            cmbSuburbName.SelectedIndex = -1;
            cmbSuburbName.Text = String.Empty;
            cmbSuburbID.Text = String.Empty;
            cmbPostCode.Text = String.Empty;
            txtTeacherPhoneNum.Text = String.Empty;
            txtTeacherEmail.Text = String.Empty;
            dtpCommencementDate.Format = DateTimePickerFormat.Custom;
            dtpCommencementDate.CustomFormat = " ";
            cmbTeacherDepartment.SelectedIndex = -1;
            //cmbClassTaught.SelectedIndex = -1;
            //txtTeacherSkills.Text = String.Empty;
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

        private void cmbSuburbName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbSuburbName.SelectedIndex;

            cmbSuburbID.SelectedIndex = selectedNumber;
            cmbPostCode.SelectedIndex = selectedNumber;
        }
    }
}
