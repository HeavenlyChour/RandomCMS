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
    public partial class AssessmentForm : Form
    {
        //bool loaded = false;

        public AssessmentForm()
        {
            InitializeComponent();

            //Clear the date time pickers upon form load
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = " ";
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region Validation Area
            if (!clsValidation.ValidateComboBox(cmbUnitName))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbTeacherName))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtAssessmentName))
            {
                txtAssessmentName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtAssessmentName))
            {
                txtAssessmentName.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpStartDate, dtpDueDate))
            {
                return;
            }
            #endregion
            //create an assessment object with the supplied values
            clsAssessment objAssessment = new clsAssessment(txtAssessmentName.Text, Convert.ToInt32(cmbUnitID.Text), 
                Convert.ToInt32(cmbTeacherID.Text),  dtpStartDate.Value.ToString("yyyy-MM-dd"), 
                dtpDueDate.Value.ToString("yyyy-MM-dd"));

            //run the Add function for the object created
            objAssessment.Add();
            MessageBox.Show("Assessment successfully added");

            //refresh the data grid view
            objAssessment.ViewAll(dgvAssessment);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtAssessmentID))
            {
                txtAssessmentID.Focus();
                return;
            }
            //create and assessment object with only the id
            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text));

            //run the Delete function
            objAssessment.Delete();
            MessageBox.Show("Assessment successfully deleted");

            //refresh the data grid view
            objAssessment.ViewAll(dgvAssessment);
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            #region Validation Area
            if (!clsValidation.ValidateTextBoxForNumeric(txtAssessmentID))
            {
                txtAssessmentID.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbUnitName))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbTeacherName))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtAssessmentName))
            {
                txtAssessmentName.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpStartDate, dtpDueDate))
            {
                return;
            }
            #endregion
            //create an assessment object with all values
            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text), txtAssessmentName.Text,
                Convert.ToInt32(cmbUnitID.Text), Convert.ToInt32(cmbTeacherID.Text), 
                dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpDueDate.Value.ToString("yyyy-MM-dd"));

            //run the Update value for the created object
            objAssessment.Update();
            MessageBox.Show("Assessment successfully updated");

            //refresh the data grid view
            objAssessment.ViewAll(dgvAssessment);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            //force the date time picker to year/month/day format
            string dateSelected = dtpStartDate.Value.ToString("yyyy-MM-dd");
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = dateSelected;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpDueDate.Value.ToString("yyyy-MM-dd");
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = dateSelected;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            //sets all the form elements to be empty
            txtAssessmentID.Text = String.Empty;
            cmbUnitName.SelectedIndex = -1;
            cmbTeacherName.SelectedIndex = -1;
            txtAssessmentName.Text = String.Empty;
            dtpStartDate.Text = String.Empty;
            dtpDueDate.Text = String.Empty;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = " ";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtAssessmentID))
            {
                txtAssessmentID.Focus();
                return;
            }
            //creates an assessment object with only the id value
            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text));

            //runs the search function for the created object
            bool valid = objAssessment.Search();

            //if an assessment was found in the Search function, then set the form elements to the supplied values
            if (valid)
            {
                txtAssessmentName.Text = objAssessment.AssessmentName;
                cmbUnitID.Text = objAssessment.UnitID.ToString();
                cmbUnitName.Text = objAssessment.UnitName;
                cmbTeacherID.Text = objAssessment.TeacherID.ToString();
                cmbTeacherName.Text = objAssessment.TeacherFirstName + " " + objAssessment.TeacherLastName;
                dtpStartDate.Value = DateTime.Parse(objAssessment.StartDate);
                dtpDueDate.Value = DateTime.Parse(objAssessment.DueDate);
            }
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            //passes the data grid view to the ViewAll function and refreshes the data grid view on the form
            clsAssessment objAssessment = new clsAssessment();
            objAssessment.ViewAll(dgvAssessment);
        }

        private void AssessmentForm_Load(object sender, EventArgs e)
        {
            //passes the comboboxes that need to be popluated from the database and passes the data grid view
            //then runs the Load and ViewAll functions upon loading the form
            clsAssessment objAssessment = new clsAssessment();
            ComboBox[] cmb = new ComboBox[] {cmbUnitID, cmbUnitName, cmbTeacherID, cmbTeacherName };
            objAssessment.Load(cmb);
            objAssessment.ViewAll(dgvAssessment);
            //loaded = true;
        }

        private void cmbUnitName_Changed(object sender, EventArgs e)
        {
            //if (loaded == true)
            //{

            //changes the UnitID combobox whenever the UnitName combobox is changed
            int selectedNumber = cmbUnitName.SelectedIndex;
            cmbUnitID.SelectedIndex = selectedNumber;

            //}
        }

        private void cmbTeacherName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbTeacherName.SelectedIndex;
            cmbTeacherID.SelectedIndex = selectedNumber;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
