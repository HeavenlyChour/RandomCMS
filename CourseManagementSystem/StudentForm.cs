using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ValidationClass;
using DatabaseClass;

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

        /// <summary>
        /// When the Add menu item is clicked, a student object is made with all the fields except ID.
        /// These values are passed to the AddStudent method which will run the procedure for adding the student into the database table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region ValidationArea
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
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
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

            string genderText = String.Empty;
            if (rdbMale.Checked)
            {
                genderText = "m";
            }
            else if (rdbFemale.Checked)
            {
                genderText = "f";
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
            string disabilityText = String.Empty;
            if (rdbDisabilityYes.Checked)
            {
                disabilityText = "Yes";
            }
            else if (rdbDisabilityNo.Checked)
            {
                disabilityText = "No";
            }
            #endregion

            if (rdbDisabilityYes.Checked == true)
            {
                //   txtDisabilityDescription.ReadOnly = false;
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
            clsStudent objStudent = new clsStudent(txtStudentFirstName.Text,
                  txtStudentLastName.Text, dtpDateOfBirth.Value.ToString("yyyy-MM-dd"), genderText, txtStudStreetAddress.Text,
                  cmbStudSuburb.Text, txtStudPostCode.Text, txtStudentPhoneNum.Text, txtStudentEmail.Text,
                  cmbNationality.Text, disabilityText, txtDisabilityDescription.Text);
            objStudent.Add();
            MessageBox.Show("Student record successfully added!");
        }

        /// <summary>
        /// When the Delete menu item is clicked, a student object is created with only the ID field.
        /// This ID is passed to the DeleteStudent method which will run the procedure for deleting the student from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtStudentID))
            {
                txtStudentID.Focus();
                return;
            }
            clsStudent objStudent = new clsStudent(Convert.ToInt32(txtStudentID.Text));
            objStudent.DeleteStudent();
            MessageBox.Show("Student record successfully deleted");
        }

        /// <summary>
        /// When the Update menu item is clicked, a student object is created with all the fields.
        /// The values are passed to the UpdateStudent method which will run the procedure for updating the student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBoxForNumeric(txtStudentID))
            {
                txtStudentID.Focus();
                return;
            }
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
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
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
            if (rdbDisabilityYes.Checked == true)
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
            string disabilityText = String.Empty;
            if (rdbDisabilityYes.Checked)
            {
                disabilityText = "Yes";
            }
            else if (rdbDisabilityNo.Checked)
            {
                disabilityText = "No";
            }
            clsStudent objStudent = new clsStudent(Convert.ToInt32(txtStudentID.Text), txtStudentFirstName.Text,
                  txtStudentLastName.Text, dtpDateOfBirth.Value.ToString("yyyy-MM-dd"), genderText, txtStudStreetAddress.Text,
                  cmbStudSuburb.Text, txtStudPostCode.Text, txtStudentPhoneNum.Text, txtStudentEmail.Text,
                  cmbNationality.Text, disabilityText, txtDisabilityDescription.Text);
            objStudent.UpdateStudent();
            MessageBox.Show("Student record successfully updated!");
        }

        /// <summary>
        /// Sets the format of the DateTimePicker to make sure it is always yyyy-MM-dd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string dobSelected = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = dobSelected;
        }

        /// <summary>
        /// Clears all the fields when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Exits the application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Next two methods toggles the disability description so that you can write in it if disability is yes, or cannot write if disability is no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbDisabilityYes_CheckedChanged(object sender, EventArgs e)
        {
            txtDisabilityDescription.ReadOnly = false;
        }
        private void rdbDisabilityNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDisabilityDescription.Text = String.Empty;
            txtDisabilityDescription.ReadOnly = true;
        }

        /// <summary>
        /// When the Update menu item is clicked, a student object is created with only the ID field.
        /// The SearchStudent method will use the ID from this object in the procedure in the database to find the right student.
        /// The values that are changed in the student class are passed to the form and all the fields are filled in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtStudentID))
            {
                txtStudentID.Focus();
                return;
            }
            clsStudent objStudent = new clsStudent(Convert.ToInt32(txtStudentID.Text));
            
            bool valid = objStudent.SearchStudent();
            if (valid)
            {
                txtStudentFirstName.Text = objStudent.FirstName;
                txtStudentLastName.Text = objStudent.LastName;
                if(objStudent.Gender == "m" || objStudent.Gender == "M")
                {
                    rdbMale.Checked = true;
                }
                else if(objStudent.Gender == "f" || objStudent.Gender == "F")
                {
                    rdbFemale.Checked = true;
                }
                dtpDateOfBirth.Value = DateTime.Parse(objStudent.DateOfBirth);
                txtStudStreetAddress.Text = objStudent.StreetAddress;
                cmbStudSuburb.Text = objStudent.Suburb;
                txtStudPostCode.Text = objStudent.PostCode;
                txtStudentPhoneNum.Text = objStudent.PhoneNumber;
                txtStudentEmail.Text = objStudent.Email;
                cmbNationality.Text = objStudent.Nationality;
                if (objStudent.Disability == "Yes")
                {
                    rdbDisabilityYes.Checked = true;
                }
                else if (objStudent.Gender == "No")
                {
                    rdbDisabilityNo.Checked = true;
                }
                txtDisabilityDescription.Text = objStudent.DisabilityDescription;
            }
            else
            {
                MessageBox.Show("This student code does not exist.");
            }
        }

        /// <summary>
        /// Connects to the database and selects all the students from the table.
        /// Fills in the DataGridView with students with the amount within the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            string strConnection = "server=localhost;database=randomdb;Trusted_Connection=yes";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strSQL = "select * from student";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if(objDataTable.Rows.Count != 0)
            {
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = objDataTable;
                dgvStudent.AutoGenerateColumns = false;
                dgvStudent.Columns[0].HeaderText = "Student ID";
                dgvStudent.Columns[1].HeaderText = "First Name";
                dgvStudent.Columns[2].HeaderText = "Last Name";
                dgvStudent.Columns[3].HeaderText = "Gender";
                dgvStudent.Columns[4].HeaderText = "D.O.B.";
                dgvStudent.Columns[5].HeaderText = "Street Address";
                dgvStudent.Columns[6].HeaderText = "Suburb";
                dgvStudent.Columns[7].HeaderText = "Post Code";
                dgvStudent.Columns[8].HeaderText = "Phone No.";
                dgvStudent.Columns[9].HeaderText = "Email";
                dgvStudent.Columns[10].HeaderText = "Nationality";
                dgvStudent.Columns[11].HeaderText = "Disability";
                dgvStudent.Columns[12].HeaderText = "Disability Description";
                dgvStudent.AutoResizeColumns();
                dgvStudent.AutoSize = false;
                dgvStudent.Visible = true;
            }
            else
            {
                MessageBox.Show("There are no students");
            }
        }
    }
}
