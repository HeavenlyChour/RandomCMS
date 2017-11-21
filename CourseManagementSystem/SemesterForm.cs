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
    public partial class SemesterForm : Form
    {
        public SemesterForm()
        {
            InitializeComponent();

            dtpSemesterStartDate.Format = DateTimePickerFormat.Custom;
            dtpSemesterStartDate.CustomFormat = " ";
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateDate(dtpSemesterStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtSemesterWeeks))
            {
                txtSemesterWeeks.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtSemesterWeeks))
            {
                txtSemesterWeeks.Focus();
                return;
            }

            clsSemester objSemester = new clsSemester(dtpSemesterStartDate.Value.ToString("yyyy-MM-dd"), 
                Convert.ToInt32(txtSemesterWeeks.Text));
            objSemester.Add();
            MessageBox.Show("Semester successfully added");
            objSemester.ViewAll(dgvSemester);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            
            if (!clsValidation.ValidateTextBoxForNumeric(txtSemesterID))
            {
                return;
            }

            clsSemester objSemester = new clsSemester(Convert.ToInt32(txtSemesterID.Text));
            objSemester.Delete();
            MessageBox.Show("Semester successfully deleted");
            objSemester.ViewAll(dgvSemester);
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtSemesterID))
            {
                return;
            }
            if (!clsValidation.ValidateDate(dtpSemesterStartDate))
            {
                return;
            }
            if (!clsValidation.ValidateTextBox(txtSemesterWeeks))
            {
                txtSemesterWeeks.Focus();
                return;
            }
            if (!clsValidation.ValidateTextBoxForNumeric(txtSemesterWeeks))
            {
                txtSemesterWeeks.Focus();
                return;
            }
            clsSemester objSemester = new clsSemester(Convert.ToInt32(txtSemesterID.Text), 
                dtpSemesterStartDate.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(txtSemesterWeeks.Text));
            objSemester.Update();
            MessageBox.Show("Semester successfully updated");
            objSemester.ViewAll(dgvSemester);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateTextBoxForNumeric(txtSemesterID))
            {
                txtSemesterID.Focus();
                return;
            }
            clsSemester objSemester = new clsSemester(Convert.ToInt32(txtSemesterID.Text));
            bool valid = objSemester.Search();
            if (valid)
            {
                dtpSemesterStartDate.Value = DateTime.Parse(objSemester.SemesterDate);
                txtSemesterWeeks.Text = objSemester.SemesterWeeks.ToString();
            }
        }
        
        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            clsSemester objSemester = new clsSemester();
            objSemester.ViewAll(dgvSemester);
        }

        private void dtpSemesterStartDate_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = dtpSemesterStartDate.Value.ToString("yyyy-MM-dd");
            dtpSemesterStartDate.Format = DateTimePickerFormat.Custom;
            dtpSemesterStartDate.CustomFormat = dateSelected;
        }

        private void mnuClearAll_Click(object sender, EventArgs e)
        {
            txtSemesterID.Text = String.Empty;
            dtpSemesterStartDate.Format = DateTimePickerFormat.Custom;
            dtpSemesterStartDate.CustomFormat = " ";
            txtSemesterWeeks.Text = String.Empty;
        }

        private void SemesterForm_Load(object sender, EventArgs e)
        {
            clsSemester objSemester = new clsSemester();
            objSemester.ViewAll(dgvSemester);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
