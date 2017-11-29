using DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationClass;

namespace CourseManagementSystem
{
    public partial class EnrolmentForm : Form
    {
        public EnrolmentForm()
        {
            InitializeComponent();

            //txtDisabilityDescription.ReadOnly = true;
            dtpEnrolmentDate.Format = DateTimePickerFormat.Custom;
            dtpEnrolmentDate.CustomFormat = " ";
            dtpExpectedEndDate.Format = DateTimePickerFormat.Custom;
            dtpExpectedEndDate.CustomFormat = " ";
            dtpPaymentDueDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDueDate.CustomFormat = " ";
            dtpDatePaid.Format = DateTimePickerFormat.Custom;
            dtpDatePaid.CustomFormat = " ";
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateComboBox(cmbStudentID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpEnrolmentDate))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpExpectedEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpEnrolmentDate, dtpExpectedEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbFaceToFace, rdbOnline))
            {
                return;
            }
            string courseDelText = String.Empty;
            if (rdbFaceToFace.Checked)
            {
                courseDelText = "FaceToFace";
            }
            else if (rdbOnline.Checked)
            {
                courseDelText = "Online";
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpEnrolmentDate, dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpPaymentDueDate, dtpExpectedEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtAmountDue))
            {
                txtAmountDue.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtAmountDue))
            {
                txtAmountDue.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbPaymentMethod))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbPaymentStatus))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpDatePaid))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbStudyStatus))
            {
                cmbStudyStatus.Focus();
                return;
            }
            #endregion
        clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(cmbStudentID.Text), Convert.ToInt32(cmbCourseID.Text),
                dtpEnrolmentDate.Value.ToString("yyyy-MM-dd"), dtpExpectedEndDate.Value.ToString("yyyy-MM-dd"), courseDelText,
                Convert.ToInt32(txtAmountDue.Text), dtpPaymentDueDate.Value.ToString("yyyy-MM-dd"), cmbPaymentMethod.Text, 
                cmbPaymentStatus.Text, dtpDatePaid.Value.ToString("yyyy-MM-dd"), cmbStudyStatus.Text);

            objEnrolment.Add();
            MessageBox.Show("Enrolment record successfully added!");
            objEnrolment.ViewAll(dgvEnrolment);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtEnrolmentID))
            {
                txtEnrolmentID.Focus();
                return;
            }
            clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(txtEnrolmentID.Text));
            objEnrolment.Delete();
            MessageBox.Show("Enrolment record successfully deleted");
            objEnrolment.ViewAll(dgvEnrolment);
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBoxForNumeric(txtEnrolmentID))
            {
                txtEnrolmentID.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbStudentID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpEnrolmentDate))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpExpectedEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpEnrolmentDate, dtpExpectedEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbFaceToFace, rdbOnline))
            {
                return;
            }
            string courseDelText = String.Empty;
            if (rdbFaceToFace.Checked)
            {
                courseDelText = "FaceToFace";
            }
            else if (rdbOnline.Checked)
            {
                courseDelText = "Online";
            }

            if (!clsValidation.ValidateComboBox(cmbPaymentMethod))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpEnrolmentDate, dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateDateStartVsEnd(dtpPaymentDueDate, dtpExpectedEndDate))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtAmountDue))
            {
                txtAmountDue.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtAmountDue))
            {
                txtAmountDue.Focus();
                return;
            }
            if (!clsValidation.ValidateDate(dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbPaymentMethod))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbPaymentStatus))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpDatePaid))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbStudyStatus))
            {
                cmbStudyStatus.Focus();
                return;
            }
            #endregion

            clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(txtEnrolmentID.Text), Convert.ToInt32(cmbStudentID.Text), Convert.ToInt32(cmbCourseID.Text),
                dtpEnrolmentDate.Value.ToString("yyyy-MM-dd"), dtpExpectedEndDate.Value.ToString("yyyy-MM-dd"), courseDelText,
                Convert.ToInt32(txtAmountDue.Text), dtpPaymentDueDate.Value.ToString("yyyy-MM-dd"), cmbPaymentMethod.Text,
                cmbPaymentStatus.Text, dtpDatePaid.Value.ToString("yyyy-MM-dd"), cmbStudyStatus.Text);

            objEnrolment.Update();
            MessageBox.Show("Enrolment record successfully updated!");
            objEnrolment.ViewAll(dgvEnrolment);
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtEnrolmentID))
            {
                txtEnrolmentID.Focus();
                return;
            }

            clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(txtEnrolmentID.Text));

            bool valid = objEnrolment.Search();
            if (valid)
            {
                cmbStudentID.Text = objEnrolment.StudentID.ToString();
                cmbStudentName.Text = objEnrolment.StudentFirstName + " " + objEnrolment.StudentLastName;
                cmbCourseID.Text = objEnrolment.CourseID.ToString();
                cmbCourseName.Text = objEnrolment.CourseName;
                dtpEnrolmentDate.Value = DateTime.Parse(objEnrolment.EnrolmentDate);
                dtpExpectedEndDate.Value = DateTime.Parse(objEnrolment.ExpectedEndDate);
                if (objEnrolment.CourseDelivery == "FaceToFace")
                {
                    rdbFaceToFace.Checked = true;
                }
                else if (objEnrolment.CourseDelivery == "Online")
                {
                    rdbOnline.Checked = true;
                }
                txtAmountDue.Text = objEnrolment.AmountDue.ToString();
                dtpPaymentDueDate.Value = DateTime.Parse(objEnrolment.PaymentDueDate);
                cmbPaymentMethod.Text = objEnrolment.PaymentMethod;
                cmbPaymentStatus.Text = objEnrolment.PaymentStatus;
                if (objEnrolment.DatePaid != "")
                {
                    dtpDatePaid.Value = DateTime.Parse(objEnrolment.DatePaid);
                }
                else
                {
                    dtpDatePaid.Format = DateTimePickerFormat.Custom;
                    dtpDatePaid.CustomFormat = " ";
                }
                cmbStudyStatus.Text = objEnrolment.StudyStatus;
            }
        }

        private void dtpEnrolmentDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpEnrolmentDate.Value.ToString("yyyy-MM-dd");
            dtpEnrolmentDate.Format = DateTimePickerFormat.Custom;
            dtpEnrolmentDate.CustomFormat = dateSelected;
        }

        private void dtpExpectedEndDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpExpectedEndDate.Value.ToString("yyyy-MM-dd");
            dtpExpectedEndDate.Format = DateTimePickerFormat.Custom;
            dtpExpectedEndDate.CustomFormat = dateSelected;
        }

        private void dtpPaymentDueDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpPaymentDueDate.Value.ToString("yyyy-MM-dd");
            dtpPaymentDueDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDueDate.CustomFormat = dateSelected;
        }
        private void dtpDatePaid_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpDatePaid.Value.ToString("yyyy-MM-dd");
            dtpDatePaid.Format = DateTimePickerFormat.Custom;
            dtpDatePaid.CustomFormat = dateSelected;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtEnrolmentID.Text = String.Empty;
            cmbStudentName.SelectedIndex = -1;
            cmbCourseName.SelectedIndex = -1;
            dtpEnrolmentDate.Format = DateTimePickerFormat.Custom;
            dtpEnrolmentDate.CustomFormat = " ";
            dtpExpectedEndDate.Format = DateTimePickerFormat.Custom;
            dtpExpectedEndDate.CustomFormat = " ";
            rdbFaceToFace.Checked = false;
            rdbOnline.Checked = false;
            txtAmountDue.Text = String.Empty;
            dtpPaymentDueDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDueDate.CustomFormat = " ";
            cmbPaymentMethod.SelectedIndex = -1;
            cmbPaymentStatus.SelectedIndex = -1;
            dtpDatePaid.Format = DateTimePickerFormat.Custom;
            dtpDatePaid.CustomFormat = " ";
            cmbStudyStatus.SelectedIndex = -1;
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsEnrolment objEnrolment = new clsEnrolment();
            objEnrolment.ViewAll(dgvEnrolment);
        }

        private void EnrolmentForm_Load(object sender, EventArgs e)
        {
            clsEnrolment objEnrolment = new clsEnrolment();
            ComboBox[] cmb = new ComboBox[] { cmbStudentID, cmbStudentName, cmbCourseID, cmbCourseName, cmbSemester };
            //Doesn't include the other combo boxes because they are fixed values.

            objEnrolment.Load(cmb);
            objEnrolment.ViewAll(dgvEnrolment);
        }

        private void cmbStudentName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbStudentName.SelectedIndex;

            cmbStudentID.SelectedIndex = selectedNumber;
        }

        private void cmbCourseName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbCourseName.SelectedIndex;

            cmbCourseID.SelectedIndex = selectedNumber;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbStudentID))
            {
                return;
            }
            string strSQL = "select * from enrolment, course, semester where enrolment.courseID = course.courseId and " +
                            "course.semesterId = semester.semesterId and enrolment.studentId = " + Convert.ToInt32(cmbStudentID.SelectedValue);
            DataTable objDataTable = clsDatabase.CreateDataTable(strSQL);
            dgvEnrolment.DataSource = objDataTable;
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }

            string strSQL = "select * from enrolment, course, semester where enrolment.courseID = course.courseId and " +
                            "course.semesterId = semester.semesterId and enrolment.courseId = " + Convert.ToInt32(cmbCourseID.SelectedValue);
            DataTable objDataTable = clsDatabase.CreateDataTable(strSQL);
            dgvEnrolment.DataSource = objDataTable;
        }

        private void btnSearchSemester_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbSemester))
            {
                return;
            }
            string strSQL = "select * from enrolment, course, semester where enrolment.courseID = course.courseId and " +
                            "course.semesterId = semester.semesterId and semester.semesterId = " + Convert.ToInt32(cmbSemester.SelectedValue);
            DataTable objDataTable = clsDatabase.CreateDataTable(strSQL);
            dgvEnrolment.DataSource = objDataTable;
        }
    }
}
