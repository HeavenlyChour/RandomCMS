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
    public partial class TeacherCourseForm : Form
    {
        public TeacherCourseForm()
        {
            InitializeComponent();
        }
        
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbTeacherID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }

            clsTeacherCourse objTeacherCourse = new clsTeacherCourse(Convert.ToInt32(cmbTeacherID.Text), Convert.ToInt32(cmbCourseID.Text));
            objTeacherCourse.Add();
            MessageBox.Show("Teacher-Course record successfully added!");
            objTeacherCourse.ViewAll(dgvTeacherCourse);
        }
        
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbTeacherID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbCourseID))
            {
                return;
            }
            clsTeacherCourse objTeacherCourse = new clsTeacherCourse(Convert.ToInt32(cmbTeacherID.Text), Convert.ToInt32(cmbCourseID.Text));
            objTeacherCourse.Delete();
            MessageBox.Show("Teacher-Course record successfully deleted!");
            objTeacherCourse.ViewAll(dgvTeacherCourse);
        }
        
        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsTeacherCourse objTeacherCourse = new clsTeacherCourse();
            objTeacherCourse.ViewAll(dgvTeacherCourse);
        }
        
        private void cmbTeacherName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbTeacherName.SelectedIndex;

            cmbTeacherID.SelectedIndex = selectedNumber;
        }

        private void cmbCourseName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbCourseName.SelectedIndex;

            cmbCourseID.SelectedIndex = selectedNumber;
        }

        private void TeacherCourseForm_Load(object sender, EventArgs e)
        {
            clsTeacherCourse objTeacherCourse = new clsTeacherCourse();
            ComboBox[] cmb = new ComboBox[] { cmbTeacherID, cmbTeacherName, cmbCourseID, cmbCourseName };
            objTeacherCourse.Load(cmb);
            objTeacherCourse.ViewAll(dgvTeacherCourse);
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            cmbTeacherName.SelectedIndex = -1;
            cmbCourseName.SelectedIndex = -1;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
