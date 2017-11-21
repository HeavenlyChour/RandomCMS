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
            if (!clsValidation.ValidateComboBox(cmbSuburbName))
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
            if (!clsValidation.ValidateComboBox(cmbSemesterID))
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

            clsCourse objCourse = new clsCourse(txtCourseName.Text, Convert.ToInt32(cmbSuburbID.Text), Convert.ToInt32(txtCourseDuration.Text),
                Convert.ToInt32(cmbSemesterID.Text), dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpEndDate.Value.ToString("yyyy-MM-dd"), courseDelText,
                Convert.ToInt32(txtHoursPerWeek.Text), Convert.ToInt32(txtNumOfUnits.Text), Convert.ToInt32(txtCourseFee.Text));

            objCourse.Add();
            MessageBox.Show("Course record successfully added!");
            objCourse.ViewAll(dgvCourse);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                txtCourseID.Focus();
                return;
            }
            clsCourse objCourse = new clsCourse(Convert.ToInt32(txtCourseID.Text));
            objCourse.Delete();
            MessageBox.Show("Course record successfully deleted");
            objCourse.ViewAll(dgvCourse);
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
            if (!clsValidation.ValidateComboBox(cmbSuburbName))
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
            if (!clsValidation.ValidateComboBox(cmbSemesterID))
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

            clsCourse objCourse = new clsCourse(Convert.ToInt32(txtCourseID.Text), txtCourseName.Text, Convert.ToInt32(cmbSuburbID.Text), Convert.ToInt32(txtCourseDuration.Text),
                Convert.ToInt32(cmbSemesterID.Text), dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpEndDate.Value.ToString("yyyy-MM-dd"), courseDelText,
                Convert.ToInt32(txtHoursPerWeek.Text), Convert.ToInt32(txtNumOfUnits.Text), Convert.ToInt32(txtCourseFee.Text));

            objCourse.Update();
            MessageBox.Show("Course record successfully updated!");
            objCourse.ViewAll(dgvCourse);
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
            cmbSuburbName.SelectedIndex = -1;
            txtCourseDuration.Text = String.Empty;
            cmbSemesterID.SelectedIndex = -1;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                txtCourseID.Focus();
                return;
            }

            clsCourse objCourse = new clsCourse(Convert.ToInt32(txtCourseID.Text));

            bool valid = objCourse.Search();
            if(valid)
            {
                txtCourseName.Text = objCourse.CourseName;
                cmbSuburbID.Text = objCourse.SuburbID.ToString();
                cmbSuburbName.Text = objCourse.SuburbName.ToString();
                txtCourseDuration.Text = objCourse.CourseDuration.ToString();
                cmbSemesterID.Text = objCourse.SemesterID.ToString();
                dtpStartDate.Value = DateTime.Parse(objCourse.StartDate);
                dtpEndDate.Value = DateTime.Parse(objCourse.EndDate);
                if (objCourse.CourseDelivery == "FaceToFace")
                {
                    rdbFaceToFace.Checked = true;
                }
                else if (objCourse.CourseDelivery == "Online")
                {
                    rdbOnline.Checked = true;
                }
                txtHoursPerWeek.Text = objCourse.HoursPerWeek.ToString();
                txtNumOfUnits.Text = objCourse.NoOfUnits.ToString();
                txtCourseFee.Text = objCourse.CourseFee.ToString();
            }
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsCourse objCourse = new clsCourse();
            objCourse.ViewAll(dgvCourse);
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            clsCourse objCourse = new clsCourse();
            ComboBox[] cmb = new ComboBox[] { cmbSuburbID, cmbSuburbName, cmbSemesterID };
            objCourse.Load(cmb);
            objCourse.ViewAll(dgvCourse);
        }

        private void cmbSuburbName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbSuburbName.SelectedIndex;

            cmbSuburbID.SelectedIndex = selectedNumber;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
