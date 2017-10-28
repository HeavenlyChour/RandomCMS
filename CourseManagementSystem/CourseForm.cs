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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = " ";
        }
        
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBox(txtCourseName))
            {
                txtCourseName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtCourseName))
            {
                txtCourseName.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseLocation))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtCourseDuration))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseDuration))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtCourseDuration, 100, 200))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseSemester))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpStartDate, dtpEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbFaceToFace, rdbOnline))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtHoursPerWeek))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtHoursPerWeek))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtHoursPerWeek, 10, 30))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtNumOfUnits))
            {
                txtNumOfUnits.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtNumOfUnits))
            {
                txtNumOfUnits.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtNumOfUnits, 5, 30))
            {
                txtNumOfUnits.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtCourseFee))
            {
                txtCourseFee.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseFee))
            {
                txtCourseFee.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtCourseFee, 1000, 6000))
            {
                txtCourseFee.Focus();
                return;
            }
            #endregion
            string courseDelText = String.Empty;
            if (rdbFaceToFace.Checked)
            {
                courseDelText = "FaceToFace";
            }
            else if (rdbOnline.Checked)
            {
                courseDelText = "Online";
            }

            clsCourse objCourse = new clsCourse(txtCourseName.Text, cmbCourseLocation.Text, Convert.ToInt32(txtCourseDuration.Text),
                cmbCourseSemester.Text, dtpStartDate.Value.Date, dtpEndDate.Value.Date, courseDelText,
                Convert.ToInt32(txtHoursPerWeek.Text), Convert.ToInt32(txtNumOfUnits.Text), Convert.ToInt32(txtCourseFee.Text));

            objCourse.AddCourse();
            MessageBox.Show("Course record successfully added!");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                txtCourseID.Focus();
                return;
            }
            clsCourse objStudent = new clsCourse(Convert.ToInt32(txtCourseID.Text));
            objStudent.DeleteCourse();
            MessageBox.Show("Course record successfully deleted");
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBox(txtCourseName))
            {
                txtCourseName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtCourseName))
            {
                txtCourseName.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseLocation))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtCourseDuration))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseDuration))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtCourseDuration, 100, 200))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseSemester))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpStartDate, dtpEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbFaceToFace, rdbOnline))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtHoursPerWeek))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtHoursPerWeek))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtHoursPerWeek, 10, 30))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtNumOfUnits))
            {
                txtNumOfUnits.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtNumOfUnits))
            {
                txtNumOfUnits.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtNumOfUnits, 5, 30))
            {
                txtNumOfUnits.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtCourseFee))
            {
                txtCourseFee.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseFee))
            {
                txtCourseFee.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxRange(txtCourseFee, 1000, 6000))
            {
                txtCourseFee.Focus();
                return;
            }
            #endregion

            string courseDelText = String.Empty;
            if (rdbFaceToFace.Checked)
            {
                courseDelText = "FaceToFace";
            }
            else if (rdbOnline.Checked)
            {
                courseDelText = "Online";
            }

            clsCourse objCourse = new clsCourse(Convert.ToInt32(txtCourseID.Text), txtCourseName.Text, cmbCourseLocation.Text, Convert.ToInt32(txtCourseDuration.Text),
                cmbCourseSemester.Text, dtpStartDate.Value.Date, dtpEndDate.Value.Date, courseDelText,
                Convert.ToInt32(txtHoursPerWeek.Text), Convert.ToInt32(txtNumOfUnits.Text), Convert.ToInt32(txtCourseFee.Text));

            objCourse.UpdateCourse();
            MessageBox.Show("Course record successfully updated!");
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpStartDate.Value.ToString("yyyy-MM-dd");
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = dateSelected;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpEndDate.Value.ToString("yyyy-MM-dd");
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = dateSelected;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtCourseID.Text = String.Empty;
            txtCourseName.Text = String.Empty;
            cmbCourseLocation.SelectedIndex = -1;
            txtCourseDuration.Text = String.Empty;
            cmbCourseSemester.SelectedIndex = -1;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = " ";
            rdbFaceToFace.Checked = false;
            rdbOnline.Checked = false;
            txtHoursPerWeek.Text = String.Empty;
            txtNumOfUnits.Text = String.Empty;
            txtCourseFee.Text = String.Empty;
        }
    }
}
