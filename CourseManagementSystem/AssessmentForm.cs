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
        bool loaded = false;

        public AssessmentForm()
        {
            InitializeComponent();

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
            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(cmbUnitID.Text), Convert.ToInt32(cmbTeacherID.Text), 
                txtAssessmentName.Text, dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpDueDate.Value.ToString("yyyy-MM-dd"));

            objAssessment.Add();
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

            objAssessment.Delete();
            MessageBox.Show("Assessment successfully deleted");
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
            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text), 
                Convert.ToInt32(cmbUnitName.Text), Convert.ToInt32(cmbTeacherName.Text), txtAssessmentName.Text, 
                dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpDueDate.Value.ToString("yyyy-MM-dd"));

            objAssessment.Update();
            MessageBox.Show("Assessment successfully updated");
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
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
            txtAssessmentID.Text = String.Empty;
            cmbUnitName.Text = String.Empty;
            cmbTeacherName.Text = String.Empty;
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
            clsAssessment objAssessment = new clsAssessment(Convert.ToInt32(txtAssessmentID.Text));
            bool valid = objAssessment.Search();
            if (valid)
            {
                
                cmbUnitID.Text = objAssessment.UnitID.ToString();
                for (int i = 0; i < cmbUnitID.Items.Count; i++)
                {
                    if (i == objAssessment.UnitID)
                    {
                        cmbUnitName.SelectedIndex = i;
                        break;
                    }
                }

                cmbTeacherID.Text = objAssessment.TeacherID.ToString();
                txtAssessmentName.Text = objAssessment.AssessmentName;
                dtpStartDate.Value = DateTime.Parse(objAssessment.StartDate);
                dtpDueDate.Value = DateTime.Parse(objAssessment.DueDate);
            }
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsAssessment objAssessment = new clsAssessment();
            objAssessment.ViewAll(dgvAssessment);
        }

        private void AssessmentForm_Load(object sender, EventArgs e)
        {
            clsAssessment objAssessment = new clsAssessment();
            ComboBox[] cmb = new ComboBox[] {cmbUnitID, cmbUnitName, cmbTeacherID, cmbTeacherName };
            objAssessment.Load(cmb);
            objAssessment.ViewAll(dgvAssessment);
            loaded = true;
        }

        private void cmbUnitName_Changed(object sender, EventArgs e)
        {
            if (loaded == true)
            {
                int selectedNumber = cmbUnitName.SelectedIndex;
                //DataGridViewRow row = dgvAssessment.Rows[selectedNumber];

                //int selectedID = Convert.ToInt32(row.Cells[1].Value);
                //MessageBox.Show("Unit Name Selected Index: " + selectedNumber);
                //int selectedID = Convert.ToInt32(dgvAssessment.Rows[selectedNumber].Cells[1].Value);

                cmbUnitID.SelectedIndex = selectedNumber;
                //cmbUnitID.SelectedIndex = selectedID;
            }
        }

        private void cmbTeacherName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbTeacherName.SelectedIndex;

            cmbTeacherID.SelectedIndex = selectedNumber;
        }
    }
}
