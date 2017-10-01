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
        public AssessmentForm()
        {
            InitializeComponent();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtUnitID))
            {
                txtUnitID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherID))
            {
                txtTeacherID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtAssessmentName))
            {
                txtAssessmentName.Focus();
                return;
            }
            if (!clsValidation.ValidateDOB(dtpStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateDOB(dtpEndDate))
            {
                return;
            }

            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtUnitID.Text), Convert.ToInt32(txtTeacherID.Text), 
                txtAssessmentName.Text, dtpStartDate.Value.Date, dtpEndDate.Value.Date);

            objAssessment.AddAssessment();
            MessageBox.Show("Assessment successfully added");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtAssessmentID))
            {
                txtAssessmentID.Focus();
                return;
            }

            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text));

            objAssessment.DeleteAssessment();
            MessageBox.Show("Assessment successfully deleted");
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtAssessmentID))
            {
                txtAssessmentID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtUnitID))
            {
                txtUnitID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtTeacherID))
            {
                txtTeacherID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtAssessmentName))
            {
                txtAssessmentName.Focus();
                return;
            }
            if (!clsValidation.ValidateDOB(dtpStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateDOB(dtpEndDate))
            {
                return;
            }

            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text), Convert.ToInt32(txtUnitID.Text), Convert.ToInt32(txtTeacherID.Text),
                txtAssessmentName.Text, dtpStartDate.Value.Date, dtpEndDate.Value.Date);

            objAssessment.UpdateAssessment();
            MessageBox.Show("Assessment successfully updated");
        }
    }
}
