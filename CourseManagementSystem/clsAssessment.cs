using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;
using System.Data.SqlClient;
using System.Data;

namespace CourseManagementSystem
{
    class clsAssessment
    {
        private int assessmentID;
        private int unitID;
        private int teacherID;
        private string assessmentName;
        private DateTime startDate;
        private DateTime endDate;

        public clsAssessment()
        {
        }

        public clsAssessment(int assessmentID)
        {
            this.assessmentID = assessmentID;
        }

        public clsAssessment(int assessmentID, int unitID, int teacherID)
        {
            this.assessmentID = assessmentID;
            this.unitID = unitID;
            this.teacherID = teacherID;
        }

        public clsAssessment(int unitID, int teacherID, string assessmentName, DateTime startDate, DateTime endDate)
        {
            this.unitID = unitID;
            this.teacherID = teacherID;
            this.assessmentName = assessmentName;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public clsAssessment(int assessmentID, int unitID, int teacherID, string assessmentName, DateTime startDate, DateTime endDate)
        {
            this.assessmentID = assessmentID;
            this.unitID = unitID;
            this.teacherID = teacherID;
            this.assessmentName = assessmentName;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        #region Getters and Setters
        public int AssessmentID
        {
            get
            {
                return assessmentID;
            }

            set
            {
                assessmentID = value;
            }
        }
        public int UnitID
        {
            get
            {
                return unitID;
            }

            set
            {
                unitID = value;
            }
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
        public string AssessmentName
        {
            get
            {
                return assessmentName;
            }

            set
            {
                assessmentName = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }
        #endregion

        public bool AddAssessment()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertAssessment", objConnection);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@assname", AssessmentName);
            objCommand.Parameters.AddWithValue("@startdate", StartDate);
            objCommand.Parameters.AddWithValue("@enddate", EndDate);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteAssessment()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteAssessment", objConnection);

            objCommand.Parameters.AddWithValue("@aid", AssessmentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateAssessment()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateAssessment", objConnection);
            objCommand.Parameters.AddWithValue("@aid", AssessmentID);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@assname", AssessmentName);
            objCommand.Parameters.AddWithValue("@startdate", StartDate);
            objCommand.Parameters.AddWithValue("@enddate", EndDate);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }
    }
}
