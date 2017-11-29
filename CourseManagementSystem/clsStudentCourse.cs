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
    class clsStudentCourse: ILogic
    {
        private int studentID;
        private int courseID;

        public clsStudentCourse()
        {
        }

        public clsStudentCourse(int studentID, int courseID)
        {
            this.StudentID = studentID;
            this.CourseID = courseID;
        }

        public int StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
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
            SqlCommand objCommand = new SqlCommand("AddStudentCourse", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException es)
            {
                if (es.Number == 2627)
                {
                    MessageBox.Show("Primary Key Violation");
                }
                return false;
            }
            finally
            {
                objConnection.Close();
            }
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteStudentCourse", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
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

            string strSQL = "select student_course.studentId, (student.studentFirstName + ' ' + " +
                            "student.studentLastName) as StudentName, student_course.courseId, " +
                            "course.courseName from student, student_course, course " +
                            "where student.studentId = student_course.studentId and " +
                            "course.courseId = student_course.courseId;";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Student ID";
                dgv.Columns[1].HeaderText = "Student Name";
                dgv.Columns[2].HeaderText = "Course ID";
                dgv.Columns[3].HeaderText = "Course Name";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no Student-Courses");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            string strSql = "select * from student";
            clsDatabase.CreateConnection();
            DataTable objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[0].DataSource = objDataTable;
            cmb[0].DisplayMember = "studentid";
            cmb[0].ValueMember = "studentid";
            cmb[0].SelectedIndex = -1;
            cmb[0].Text = "";

            objDataTable = null;
            strSql = "select studentid, (studentfirstname + ' ' + studentlastname) as name from student";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[1].DataSource = objDataTable;
            cmb[1].DisplayMember = "name";
            cmb[1].ValueMember = "studentid";
            cmb[1].SelectedIndex = -1;
            cmb[1].Text = "Select a student";

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
