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
            //if (!clsValidation.ValidateComboBox(cmbCourseName))
            //{
            //    cmbCourseName.Focus();
            //    return;
            //}
            if (!clsValidation.ValidateTextBox(txtCourseName))
            {
                cmbCourseLocation.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseLocation))
            {
                cmbCourseLocation.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseDuration))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseSemester))
            {
                cmbCourseSemester.Focus();
                return;
            }
            //dtpStartDate.Format = DateTimePickerFormat.Custom;
            //dtpStartDate.CustomFormat = "yyyy-MM-dd";
            if (!clsValidation.ValidateDOB(dtpStartDate))
            {
                return;
            }
            //dtpEndDate.Format = DateTimePickerFormat.Custom;
            //dtpEndDate.CustomFormat = "yyyy-MM-dd";
            if (!clsValidation.ValidateDOB(dtpEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbFaceToFace, rdbOnline))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtHoursPerWeek))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtNumOfUnits))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseFee))
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
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                txtCourseID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtCourseName))
            {
                cmbCourseLocation.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseLocation))
            {
                cmbCourseLocation.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseDuration))
            {
                txtCourseDuration.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseSemester))
            {
                cmbCourseSemester.Focus();
                return;
            }
            if (!clsValidation.ValidateDOB(dtpStartDate))
            {
                dtpStartDate.Focus();
                return;
            }
            if (!clsValidation.ValidateDOB(dtpEndDate))
            {
                dtpEndDate.Focus();
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbFaceToFace, rdbOnline))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtHoursPerWeek))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtNumOfUnits))
            {
                txtHoursPerWeek.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseFee))
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
    }
}
