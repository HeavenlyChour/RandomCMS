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
            if (!clsValidation.ValidateTextBox(txtUnitName))
            {
                txtUnitName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtCourseID))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbNoOfHours))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbNoOfAssessments))
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

            clsUnit objUnit = new clsUnit(txtUnitName.Text, Convert.ToInt32(cmbNoOfHours.Text), Convert.ToInt32(cmbNoOfAssessments.Text), unitTypeText);
            objUnit.AddUnit();
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
            objUnit.DeleteUnit();
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
            if (!clsValidation.ValidateTextBox(txtCourseID))
            {
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtCourseID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbNoOfHours))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbNoOfAssessments))
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
                Convert.ToInt32(cmbNoOfHours.Text), Convert.ToInt32(cmbNoOfAssessments.Text), unitTypeText);

            objUnit.UpdateUnit();
            MessageBox.Show("Unit record successfully updated!");
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtUnitID.Text = String.Empty;
            //cmbUnitName.SelectedIndex = -1;
            txtUnitName.Text = String.Empty;
            cmbNoOfHours.SelectedIndex = -1;
            cmbNoOfAssessments.SelectedIndex = -1;
        }
    }
}
