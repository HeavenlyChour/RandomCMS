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
    public partial class StudentCourseForm : Form
    {
        public StudentCourseForm()
        {
            InitializeComponent();
        }
        
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbStudentID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }

            clsStudentCourse objStudentCourse = new clsStudentCourse(Convert.ToInt32(cmbStudentID.Text), Convert.ToInt32(cmbCourseID.Text));
            if (!objStudentCourse.Add())
                return;
            MessageBox.Show("Student-Course record successfully added!");
            objStudentCourse.ViewAll(dgvStudentCourse);
        }
        
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbStudentID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }
            clsStudentCourse objStudentCourse = new clsStudentCourse(Convert.ToInt32(cmbStudentID.Text), Convert.ToInt32(cmbCourseID.Text));
            objStudentCourse.Delete();
            MessageBox.Show("Student-Course record successfully deleted!");
            objStudentCourse.ViewAll(dgvStudentCourse);
        }
        
        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsStudentCourse objStudentCourse = new clsStudentCourse();
            objStudentCourse.ViewAll(dgvStudentCourse);
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

        private void StudentCourseForm_Load(object sender, EventArgs e)
        {
            clsStudentCourse objStudentCourse = new clsStudentCourse();
            ComboBox[] cmb = new ComboBox[] { cmbStudentID, cmbStudentName, cmbCourseID, cmbCourseName };
            objStudentCourse.Load(cmb);
            objStudentCourse.ViewAll(dgvStudentCourse);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            cmbStudentName.SelectedIndex = -1;
            cmbCourseName.SelectedIndex = -1;
        }
    }
}
