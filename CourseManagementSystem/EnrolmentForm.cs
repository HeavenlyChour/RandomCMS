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
    public partial class EnrolmentForm : Form
    {
        public EnrolmentForm()
        {
            InitializeComponent();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBoxForNumeric(txtStudentID))
            {
                txtStudentID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                txtCourseID.Focus();
                return;
            }
            if (!clsValidation.ValidateDOB(dtpEnrolmentDate))
            {
                return;
            }
            if (!clsValidation.ValidateDOB(dtpExpectedEndDate))
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
            if (!clsValidation.ValidateDOB(dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtAmountPaid))
            {
                txtAmountPaid.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtBalanceOwing))
            {
                txtBalanceOwing.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbPaymentStatus))
            {
                cmbPaymentStatus.Focus();
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbDisabilityYes, rdbDisabilityNo))
            {
                return;
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

            if (!clsValidation.ValidateComboBox(cmbStudyStatus))
            {
                cmbStudyStatus.Focus();
                return;
            }
            #endregion

            clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(txtStudentID.Text), Convert.ToInt32(txtCourseID.Text),
                dtpEnrolmentDate.Value.Date, dtpExpectedEndDate.Value.Date, courseDelText, cmbPaymentMethod.Text,
                dtpPaymentDueDate.Value.Date, Convert.ToInt32(txtAmountPaid.Text), Convert.ToInt32(txtBalanceOwing.Text),
                cmbPaymentStatus.Text, disabilityText, txtDisabilityDescription.Text, cmbStudyStatus.Text);

            objEnrolment.AddEnrolment();
            MessageBox.Show("Enrolment record successfully added!");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtEnrolmentID))
            {
                txtEnrolmentID.Focus();
                return;
            }
            clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(txtEnrolmentID.Text));
            objEnrolment.DeleteEnrolment();
            MessageBox.Show("Enrolment record successfully deleted");
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            #region ValidationArea
            if (!clsValidation.ValidateTextBoxForNumeric(txtEnrolmentID))
            {
                txtEnrolmentID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtStudentID))
            {
                txtStudentID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                txtCourseID.Focus();
                return;
            }
            if (!clsValidation.ValidateDOB(dtpEnrolmentDate))
            {
                return;
            }
            if (!clsValidation.ValidateDOB(dtpExpectedEndDate))
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
            if (!clsValidation.ValidateDOB(dtpPaymentDueDate))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtAmountPaid))
            {
                txtAmountPaid.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtBalanceOwing))
            {
                txtBalanceOwing.Focus();
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbPaymentStatus))
            {
                cmbPaymentStatus.Focus();
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbDisabilityYes, rdbDisabilityNo))
            {
                return;
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

            if (!clsValidation.ValidateComboBox(cmbStudyStatus))
            {
                cmbStudyStatus.Focus();
                return;
            }
            #endregion

            clsEnrolment objEnrolment = new clsEnrolment(Convert.ToInt32(txtEnrolmentID.Text), Convert.ToInt32(txtStudentID.Text), 
                Convert.ToInt32(txtCourseID.Text), dtpEnrolmentDate.Value.Date, dtpExpectedEndDate.Value.Date, courseDelText, 
                cmbPaymentMethod.Text, dtpPaymentDueDate.Value.Date, Convert.ToInt32(txtAmountPaid.Text), 
                Convert.ToInt32(txtBalanceOwing.Text), cmbPaymentStatus.Text, disabilityText, txtDisabilityDescription.Text, 
                cmbStudyStatus.Text);

            objEnrolment.UpdateEnrolment();
            MessageBox.Show("Enrolment record successfully updated!");
        }
    }
}
