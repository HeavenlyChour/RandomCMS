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
    class clsCourse
    {
        private int courseID;
        private string courseName;
        private string courseLocation;
        private int courseDuration;
        private string courseSemester;
        private DateTime startDate;
        private DateTime endDate;
        private string courseDelivery;
        private int hoursPerWeek;
        private int noOfUnits;
        private int courseFee;
        

        public clsCourse()
        {
        }

        public clsCourse(int courseID)
        {
            this.CourseID = courseID;
        }

        public clsCourse(string courseName, string courseLocation, int courseDuration, string courseSemester, DateTime startDate, DateTime endDate, string courseDelivery, int hoursPerWeek, int noOfUnits, int courseFee)
        {
            this.CourseName = courseName;
            this.CourseLocation = courseLocation;
            this.CourseDuration = courseDuration;
            this.CourseSemester = courseSemester;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CourseDelivery = courseDelivery;
            this.HoursPerWeek = hoursPerWeek;
            this.NoOfUnits = noOfUnits;
            this.CourseFee = courseFee;
        }

        public clsCourse(int courseID, string courseName, string courseLocation, int courseDuration, string courseSemester, DateTime startDate, DateTime endDate, string courseDelivery, int hoursPerWeek, int noOfUnits, int courseFee)
        {
            this.CourseID = courseID;
            this.CourseName = courseName;
            this.CourseLocation = courseLocation;
            this.CourseDuration = courseDuration;
            this.CourseSemester = courseSemester;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CourseDelivery = courseDelivery;
            this.HoursPerWeek = hoursPerWeek;
            this.NoOfUnits = noOfUnits;
            this.CourseFee = courseFee;
        }

        #region Proper Getters and Setters. Screw 2017
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

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public string CourseLocation
        {
            get
            {
                return courseLocation;
            }

            set
            {
                courseLocation = value;
            }
        }

        public int CourseDuration
        {
            get
            {
                return courseDuration;
            }

            set
            {
                courseDuration = value;
            }
        }

        public string CourseSemester
        {
            get
            {
                return courseSemester;
            }

            set
            {
                courseSemester = value;
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

        public string CourseDelivery
        {
            get
            {
                return courseDelivery;
            }

            set
            {
                courseDelivery = value;
            }
        }

        public int HoursPerWeek
        {
            get
            {
                return hoursPerWeek;
            }

            set
            {
                hoursPerWeek = value;
            }
        }

        public int NoOfUnits
        {
            get
            {
                return noOfUnits;
            }

            set
            {
                noOfUnits = value;
            }
        }

        public int CourseFee
        {
            get
            {
                return courseFee;
            }

            set
            {
                courseFee = value;
            }
        }
        #endregion


        public bool AddCourse()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertCourse", objConnection);
            objCommand.Parameters.AddWithValue("@cname", CourseName);
            objCommand.Parameters.AddWithValue("@cloc", CourseLocation);
            objCommand.Parameters.AddWithValue("@csem", CourseSemester);
            objCommand.Parameters.AddWithValue("@sdate", StartDate);
            objCommand.Parameters.AddWithValue("@edate", EndDate);
            objCommand.Parameters.AddWithValue("@cdeliv", CourseDelivery);
            objCommand.Parameters.AddWithValue("@hrs", HoursPerWeek);
            objCommand.Parameters.AddWithValue("@noofunits", NoOfUnits);
            objCommand.Parameters.AddWithValue("@cfee", CourseFee);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteCourse()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteCourse", objConnection);

            objCommand.Parameters.AddWithValue("@cid", courseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateCourse()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateStudent", objConnection);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.Parameters.AddWithValue("@cname", CourseName);
            objCommand.Parameters.AddWithValue("@cloc", CourseLocation);
            objCommand.Parameters.AddWithValue("@csem", CourseSemester);
            objCommand.Parameters.AddWithValue("@sdate", StartDate);
            objCommand.Parameters.AddWithValue("@edate", EndDate);
            objCommand.Parameters.AddWithValue("@cdeliv", CourseDelivery);
            objCommand.Parameters.AddWithValue("@hrs", HoursPerWeek);
            objCommand.Parameters.AddWithValue("@noofunits", NoOfUnits);
            objCommand.Parameters.AddWithValue("@cfee", CourseFee);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }
    }
}
