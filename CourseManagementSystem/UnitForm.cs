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
            if (!clsValidation.ValidateComboBox(cmbUnitName))
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
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtUnitID.Text = String.Empty;
            cmbUnitName.SelectedIndex = -1;
            cmbNoOfHours.SelectedIndex = -1;
            cmbNoOfAssessments.SelectedIndex = -1;
        }
    }
}
