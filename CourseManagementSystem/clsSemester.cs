using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsSemester
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

        public bool AddSemester()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertSemester", objConnection);
            objCommand.Parameters.AddWithValue("@semdate", SemesterDate);
            objCommand.Parameters.AddWithValue("@semweeks", SemesterWeeks);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteSemester()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteSemester", objConnection);

            objCommand.Parameters.AddWithValue("@semid", SemesterID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateSemester()
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
    }
}
