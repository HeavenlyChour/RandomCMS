using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Insert validation code here

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

            clsStudent objStudent = new clsStudent(Convert.ToInt32(txtStudentID.Text), txtStudentFirstName.Text, 
                txtStudentLastName.Text, genderText, txtStudentDateOfBirth.Text, txtStudStreetAddress.Text, 
                txtStudentSuburb.Text, txtStudentPostCode.Text, txtStudentPhoneNum.Text, txtStudentEmail.Text, 
                cmbNationality.Text, disabilityText, txtDisabilityDescription.Text);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
