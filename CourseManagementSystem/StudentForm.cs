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
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region Validation code
            //if(!clsValidation.ValidateTextBoxForNumeric(txtStudentID))
            //{
            //    return;
            //}
            if(!clsValidation.ValidateTextBox(txtStudentFirstName))
            {
                return;
            }
            if(!clsValidation.ValidateTextBox(txtStudentLastName))
            {
                return;
            }
            if(!clsValidation.ValidateRadioButton(rdbMale, rdbFemale))
            {
                return;
            }
            if(!clsValidation.ValidateDOB(txtStudentDateOfBirth))
            {
                return;
            }
            if(!clsValidation.ValidateTextBox(txtStudStreetAddress))
            {
                return;
            }
            if(!clsValidation.ValidateTextBox(txtStudentSuburb))
            {
                return;
            }
            if(!clsValidation.ValidateTextBox(txtStudentPostCode))
            {
                return;
            }
            if(!clsValidation.ValidateTextBoxForNumeric(txtStudentPhoneNum))
            {
                return;
            }
            if(!clsValidation.ValidateEmail(txtStudentEmail))
            {
                return;
            }
            //if (!clsValidation.ValidateComboBox(cmbNationality))
            //{
            //    return;
            //}
            if (!clsValidation.ValidateRadioButton(rdbDisabilityYes, rdbDisabilityNo))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtDisabilityDescription))
            {
                return;
            }
            #endregion

            string genderText = String.Empty;
            if(rdbMale.Checked)
            {
                genderText = "m";
            }
            else if(rdbFemale.Checked)
            {
                genderText = "f";
            }

            string disabilityText = String.Empty;
            if(rdbDisabilityYes.Checked)
            {
                disabilityText = "Yes";
            }
            else if(rdbDisabilityNo.Checked)
            {
                disabilityText = "No";
            }

            //Convert.ToInt32(txtStudentID.Text), <-------I'm leaving this here for now. It belongs in the code below.
            clsStudent objStudent = new clsStudent(txtStudentFirstName.Text, 
                txtStudentLastName.Text, genderText, txtStudentDateOfBirth.Text, txtStudStreetAddress.Text, 
                txtStudentSuburb.Text, txtStudentPostCode.Text, txtStudentPhoneNum.Text, txtStudentEmail.Text, 
                cmbNationality.Text, disabilityText, txtDisabilityDescription.Text);

            bool valid = objStudent.AddStudent();
            if(valid)
            {
                MessageBox.Show("This student has been successfully added");
            }
            else
            {
                MessageBox.Show("Could not add student");
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
