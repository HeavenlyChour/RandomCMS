using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DatabaseClass;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class clsTeacherCourse: ILogic
    {
        private int teacherID;
        private int courseID;

        public clsTeacherCourse()
        {
        }

        public clsTeacherCourse(int teacherID, int courseID)
        {
            this.TeacherID = teacherID;
            this.CourseID = courseID;
        }

        public int TeacherID
        {
            get
            {
                return teacherID;
            }

            set
            {
                teacherID = value;
            }
        }

        public int CourseID
        {
            get
            {
                return courseID;
            }

            set
            {
                courseID = value;
            }
        }

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("AddTeacherCourse", objConnection);
            //objCommand.Parameters.AddWithValue("@table", tableName);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            return true;
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteTeacherCourse", objConnection);
            //objCommand.Parameters.AddWithValue("@table", tableName);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            objConnection.Close();
            return true;
        }

        public void ViewAll(DataGridView dgv)
        {
            string strConnection = "server=localhost;database=randomdb;Trusted_Connection=yes";
            SqlConnection objConnection = new SqlConnection(strConnection);
            //SqlConnection objConnection = clsDatabase.CreateConnection();
            objConnection.Open();

            string strSQL = "select * from teacher_course";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Teacher ID";
                dgv.Columns[1].HeaderText = "Course ID";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no Teacher-Courses");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            string strSql = "select * from teacher";
            clsDatabase.CreateConnection();
            DataTable objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[0].DataSource = objDataTable;
            cmb[0].DisplayMember = "teacherid";
            cmb[0].ValueMember = "teacherid";
            cmb[0].SelectedIndex = -1;
            cmb[0].Text = "";

            objDataTable = null;
            strSql = "select teacherid, (teacherfirstname + ' ' + teacherlastname) as name from teacher";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[1].DataSource = objDataTable;
            cmb[1].DisplayMember = "name";
            cmb[1].ValueMember = "teacherid";
            cmb[1].SelectedIndex = -1;
            cmb[1].Text = "Select a teacher";

            objDataTable = null;
            strSql = "select * from course";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[2].DataSource = objDataTable;
            cmb[2].DisplayMember = "courseid";
            cmb[2].ValueMember = "courseid";
            cmb[2].SelectedIndex = -1;
            cmb[2].Text = "";

            objDataTable = null;
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[3].DataSource = objDataTable;
            cmb[3].DisplayMember = "coursename";
            cmb[3].ValueMember = "courseid";
            cmb[3].SelectedIndex = -1;
            cmb[3].Text = "Select a course";
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Search()
        {
            throw new NotImplementedException();
        }
    }
}
