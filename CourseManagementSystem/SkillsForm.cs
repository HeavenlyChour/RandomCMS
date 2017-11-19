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
            objSkills.Add();
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
            objSkills.Delete();
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
            clsSkills objSkills = new clsSkills(Convert.ToInt32(txtSkillID.Text), txtSkillName.Text, txtSkillDescription.Text);
            objSkills.Update();
            MessageBox.Show("Skill successfully updated");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtSkillID))
            {
                txtSkillID.Focus();
                return;
            }
            clsSkills objSkills = new clsSkills(Convert.ToInt32(txtSkillID.Text));
            bool valid = objSkills.Search();
            if (valid)
            {
                txtSkillName.Text = objSkills.SkillName;
                txtSkillDescription.Text = objSkills.SkillDescription;
            }
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsSkills objSkills = new clsSkills();
            objSkills.ViewAll(dgvSkills);
        }

        private void SkillsForm_Load(object sender, EventArgs e)
        {
            clsSkills objSkills = new clsSkills();
            objSkills.ViewAll(dgvSkills);
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtSkillID.Text = String.Empty;
            txtSkillName.Text = String.Empty;
            txtSkillDescription.Text = String.Empty;
        }
    }
}
