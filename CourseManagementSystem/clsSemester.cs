using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsSemester: ILogic
    {
        private int semesterID;
        private string semesterDate;
        private int semesterWeeks;

        public clsSemester()
        {
        }

        public clsSemester(int semesterID)
        {
            this.SemesterID = semesterID;
        }

        public clsSemester(string semesterDate, int semesterWeeks)
        {
            this.SemesterDate = semesterDate;
            this.SemesterWeeks = semesterWeeks;
        }

        public clsSemester(int semesterID, string semesterDate, int semesterWeeks)
        {
            this.SemesterID = semesterID;
            this.SemesterDate = semesterDate;
            this.SemesterWeeks = semesterWeeks;
        }

        #region Getters and Setters
        public int SemesterID
        {
            get
            {
                return semesterID;
            }

            set
            {
                semesterID = value;
            }
        }

        public string SemesterDate
        {
            get
            {
                return semesterDate;
            }

            set
            {
                semesterDate = value;
            }
        }

        public int SemesterWeeks
        {
            get
            {
                return semesterWeeks;
            }

            set
            {
                semesterWeeks = value;
            }
        }
        #endregion

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertSemester", objConnection);
            objCommand.Parameters.AddWithValue("@semdate", SemesterDate);
            objCommand.Parameters.AddWithValue("@semweeks", SemesterWeeks);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteSemester", objConnection);

            objCommand.Parameters.AddWithValue("@semid", SemesterID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateSemester", objConnection);

            objCommand.Parameters.AddWithValue("@semid", SemesterID);
            objCommand.Parameters.AddWithValue("@semdate", SemesterDate);
            objCommand.Parameters.AddWithValue("@semweeks", SemesterWeeks);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchSemester", objConnection);
            objCommand.Parameters.AddWithValue("@semid", SemesterID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                semesterDate = objDataReader[1].ToString();
                semesterWeeks = Convert.ToInt32(objDataReader[2]);
                objConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ViewAll(DataGridView dgv)
        {
            string strConnection = "server=localhost;database=randomdb;Trusted_Connection=yes";
            SqlConnection objConnection = new SqlConnection(strConnection);
            //SqlConnection objConnection = clsDatabase.CreateConnection();
            objConnection.Open();

            string strSQL = "select * from semester";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Semester ID";
                dgv.Columns[1].HeaderText = "Semester Date";
                dgv.Columns[2].HeaderText = "Semester Weeks";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no semesters");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            throw new NotImplementedException();
        }
    }
}
