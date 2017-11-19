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
    public partial class UnitForm : Form
    {
        public UnitForm()
        {
            InitializeComponent();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtNoOfHours))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtNoOfAssessments))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbCoreUnit, rdbElectiveUnit))
            {
                return;
            }
            string unitTypeText = String.Empty;
            if (rdbCoreUnit.Checked)
            {
                unitTypeText = "Core Unit";
            }
            else if (rdbElectiveUnit.Checked)
            {
                unitTypeText = "Elective Unit";
            }

            clsUnit objUnit = new clsUnit(txtUnitName.Text, Convert.ToInt32(txtNoOfHours.Text), unitTypeText);
            objUnit.Add();
            MessageBox.Show("Unit record successfully added!");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtUnitID))
            {
                txtUnitID.Focus();
                return;
            }
            clsUnit objUnit = new clsUnit(Convert.ToInt32(txtUnitID.Text));
            objUnit.Delete();
            MessageBox.Show("Unit record successfully deleted");
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtUnitID))
            {
                txtUnitID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtUnitName))
            {
                txtUnitName.Focus();
                return;
            }
            //if (!clsValidation.ValidateTextBox(txtCourseID))
            //{
            //    return;
            //}
            //if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            //{
            //    return;
            //}
            //if (!clsValidation.ValidateComboBox(cmbNoOfHours))
            //{
            //    return;
            //}
            //if (!clsValidation.ValidateComboBox(cmbNoOfAssessments))
            //{
            //    return;
            //}
            if (!clsValidation.ValidateTextBoxForNumeric(txtNoOfHours))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtNoOfAssessments))
            {
                return;
            }
            if (!clsValidation.ValidateRadioButton(rdbCoreUnit, rdbElectiveUnit))
            {
                return;
            }
            string unitTypeText = String.Empty;
            if (rdbCoreUnit.Checked)
            {
                unitTypeText = "Core Unit";
            }
            else if (rdbElectiveUnit.Checked)
            {
                unitTypeText = "Elective Unit";
            }

            clsUnit objUnit = new clsUnit(Convert.ToInt32(txtUnitID.Text), txtUnitName.Text, 
                Convert.ToInt32(txtNoOfHours.Text), unitTypeText);

            objUnit.Update();
            MessageBox.Show("Unit record successfully updated!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtUnitID))
            {
                txtUnitID.Focus();
                return;
            }
            clsUnit objUnit = new clsUnit(Convert.ToInt32(txtUnitID.Text));
            bool valid = objUnit.Search();
            if (valid)
            {
                txtUnitName.Text = objUnit.UnitName;
                txtNoOfHours.Text = objUnit.NoOfHours.ToString();
                txtNoOfAssessments.Text = objUnit.NoOfAssessments.ToString();
                if (objUnit.UnitType == "Core Unit")
                {
                    rdbCoreUnit.Checked = true;
                }
                else if (objUnit.UnitType == "Elective")
                {
                    rdbElectiveUnit.Checked = true;
                }
            }
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsUnit objUnit = new clsUnit();
            objUnit.ViewAll(dgvUnit);
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtUnitID.Text = String.Empty;
            //cmbUnitName.SelectedIndex = -1;
            txtUnitName.Text = String.Empty;
            txtNoOfHours.Text = String.Empty;
            txtNoOfAssessments.Text = String.Empty;
            //cmbNoOfHours.SelectedIndex = -1;
            //cmbNoOfAssessments.SelectedIndex = -1;
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            clsUnit objUnit = new clsUnit();
            objUnit.ViewAll(dgvUnit);
        }
    }
}
