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
    public partial class TeacherSkillForm : Form
    {
        public TeacherSkillForm()
        {
            InitializeComponent();
        }
        
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbTeacherID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbSkillID))
            {
                return;
            }

            clsTeacherSkill objTeacherSkill = new clsTeacherSkill(Convert.ToInt32(cmbTeacherID.Text), Convert.ToInt32(cmbSkillID.Text));
            if (!objTeacherSkill.Add())
                return;
            MessageBox.Show("Teacher-Skill record successfully added!");
            objTeacherSkill.ViewAll(dgvTeacherSkill);
        }
        
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateComboBox(cmbTeacherID))
            {
                return;
            }
            if (!clsValidation.ValidateComboBox(cmbSkillID))
            {
                return;
            }
            clsTeacherSkill objTeacherSkill = new clsTeacherSkill(Convert.ToInt32(cmbTeacherID.Text), Convert.ToInt32(cmbSkillID.Text));
            objTeacherSkill.Delete();
            MessageBox.Show("Teacher-Skill record successfully deleted!");
            objTeacherSkill.ViewAll(dgvTeacherSkill);
        }
        

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsTeacherSkill objTeacherSkill = new clsTeacherSkill();
            objTeacherSkill.ViewAll(dgvTeacherSkill);
        }

        //private void mnuExit_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        

        private void cmbTeacherName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbTeacherName.SelectedIndex;

            cmbTeacherID.SelectedIndex = selectedNumber;
        }

        private void cmbSkillName_Changed(object sender, EventArgs e)
        {
            int selectedNumber = cmbSkillName.SelectedIndex;

            cmbSkillID.SelectedIndex = selectedNumber;
        }

        private void TeacherSkillForm_Load(object sender, EventArgs e)
        {
            clsTeacherSkill objTeacherSkill = new clsTeacherSkill();
            ComboBox[] cmb = new ComboBox[] { cmbTeacherID, cmbTeacherName, cmbSkillID, cmbSkillName };
            objTeacherSkill.Load(cmb);
            objTeacherSkill.ViewAll(dgvTeacherSkill);
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            cmbTeacherName.SelectedIndex = -1;
            cmbSkillName.SelectedIndex = -1;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
