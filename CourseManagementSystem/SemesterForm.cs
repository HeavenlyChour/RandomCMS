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

            clsSemester objSemester = new clsSemester(dtpSemesterStartDate.Value.Date, Convert.ToInt32(txtSemesterWeeks.Text));
            objSemester.AddSemester();
            MessageBox.Show("Semester successfully added");
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            
            if (!clsValidation.ValidateTextBoxForNumeric(txtSemesterID))
            {
                return;
            }

            clsSemester objSemester = new clsSemester(Convert.ToInt32(txtSemesterID.Text));
            objSemester.DeleteSemester();
            MessageBox.Show("Semester successfully deleted");
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
            clsSemester objSemester = new clsSemester(Convert.ToInt32(txtSemesterID.Text), dtpSemesterStartDate.Value.Date, Convert.ToInt32(txtSemesterWeeks.Text));
            objSemester.UpdateSemester();
            MessageBox.Show("Semester successfully updated");
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
    }
}
