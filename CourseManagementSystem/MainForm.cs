using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm objStudentForm = new StudentForm();
            objStudentForm.Show();
        }

        private void btnEnrolment_Click(object sender, EventArgs e)
        {
            EnrolmentForm objEnrolmentForm = new EnrolmentForm();
            objEnrolmentForm.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseForm objCourseForm = new CourseForm();
            objCourseForm.Show();
        }

        private void btnSemester_Click(object sender, EventArgs e)
        {
            SemesterForm objSemesterForm = new SemesterForm();
            objSemesterForm.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm objTeacherForm = new TeacherForm();
            objTeacherForm.Show();
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            SkillsForm objSkillsForm = new SkillsForm();
            objSkillsForm.Show();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            UnitForm objUnitForm = new UnitForm();
            objUnitForm.Show();
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            AssessmentForm objAssessmentForm = new AssessmentForm();
            objAssessmentForm.Show();
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            StudentCourseForm objStudentCourseForm = new StudentCourseForm();
            objStudentCourseForm.Show();
        }

        private void btnTeacherCourse_Click(object sender, EventArgs e)
        {
            TeacherCourseForm objTeacherCourseForm = new TeacherCourseForm();
            objTeacherCourseForm.Show();
        }

        private void btnTeacherSkill_Click(object sender, EventArgs e)
        {
            TeacherSkillForm objTeacherSkillForm = new TeacherSkillForm();
            objTeacherSkillForm.Show();
        }

        private void btnUnitCourse_Click(object sender, EventArgs e)
        {
            UnitCourseForm objUnitCourseForm = new UnitCourseForm();
            objUnitCourseForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
