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
    public partial class SkillsForm : Form
    {
        public SkillsForm()
        {
            InitializeComponent();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBox(txtSkillName))
            {
                txtSkillName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtSkillName))
            {
                txtSkillName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtSkillDescription))
            {
                txtSkillDescription.Focus();
                return;
            }
            clsSkills objSkills = new clsSkills(txtSkillName.Text, txtSkillDescription.Text);
            objSkills.AddSkill();
            MessageBox.Show("Skill successfully added");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBox(txtSkillID))
            {
                txtSkillID.Focus();
                return;
            }

            clsSkills objSkills = new clsSkills(Convert.ToInt32(txtSkillID.Text));
            objSkills.DeleteSkill();
            MessageBox.Show("Skill successfully deleted");
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBox(txtSkillID))
            {
                txtSkillID.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtSkillName))
            {
                txtSkillName.Focus();
                return;
            }
            if (!clsValidation.ValidateForAlphabet(txtSkillName))
            {
                txtSkillName.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBox(txtSkillDescription))
            {
                txtSkillDescription.Focus();
                return;
            }
            clsSkills objSkills = new clsSkills(txtSkillName.Text, txtSkillDescription.Text);
            objSkills.AddSkill();
            MessageBox.Show("Skill successfully updated");
        }
    }
}
