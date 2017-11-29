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
    public partial class UnitCourseForm : Form
    {
        public UnitCourseForm()
        {
            InitializeComponent();
        }
        
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbUnitID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }

            clsUnitCourse objUnitCourse = new clsUnitCourse(Convert.ToInt32(cmbUnitID.Text), Convert.ToInt32(cmbCourseID.Text));
            if (!objUnitCourse.Add())
                return;
            MessageBox.Show("Unit-Course record successfully added!");
            objUnitCourse.ViewAll(dgvUnitCourse);
        }
        
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbUnitID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }
            clsUnitCourse objUnitCourse = new clsUnitCourse(Convert.ToInt32(cmbUnitID.Text), Convert.ToInt32(cmbCourseID.Text));
            objUnitCourse.Delete();
            MessageBox.Show("Unit-Course record successfully deleted!");
            objUnitCourse.ViewAll(dgvUnitCourse);
        }
        
        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsUnitCourse objUnitCourse = new clsUnitCourse();
            objUnitCourse.ViewAll(dgvUnitCourse);
        }

        private void UnitCourseForm_Load(object sender, EventArgs e)
        {
            clsUnitCourse objUnitCourse = new clsUnitCourse();
            ComboBox[] cmb = new ComboBox[] { cmbUnitID, cmbUnitName, cmbCourseID, cmbCourseName };
            objUnitCourse.Load(cmb);
            objUnitCourse.ViewAll(dgvUnitCourse);
        }

        private void cmbUnitName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbUnitName.SelectedIndex;

            cmbUnitID.SelectedIndex = selectedNumber;
        }

        private void cmbCourseName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbCourseName.SelectedIndex;

            cmbCourseID.SelectedIndex = selectedNumber;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            cmbUnitName.SelectedIndex = -1;
            cmbCourseName.SelectedIndex = -1;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
