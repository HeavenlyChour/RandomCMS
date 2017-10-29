using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class clsCourse : ILogic
    {
        private int courseID;
        private string courseName;
        private string courseLocation;
        private int courseDuration;
        private string courseSemester;
        private string startDate;
        private string endDate;
        //private DateTime startDate;
        //private DateTime endDate;
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

        public clsCourse(string courseName, string courseLocation, int courseDuration, string courseSemester, string startDate, string endDate, string courseDelivery, int hoursPerWeek, int noOfUnits, int courseFee)
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

        public clsCourse(int courseID, string courseName, string courseLocation, int courseDuration, string courseSemester, string startDate, string endDate, string courseDelivery, int hoursPerWeek, int noOfUnits, int courseFee)
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

        public string StartDate
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

        public string EndDate
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


        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertCourse", objConnection);
            objCommand.Parameters.AddWithValue("@cname", CourseName);
            objCommand.Parameters.AddWithValue("@cloc", CourseLocation);
            objCommand.Parameters.AddWithValue("@csdur", CourseDuration);
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

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteCourse", objConnection);

            objCommand.Parameters.AddWithValue("@cid", courseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateStudent", objConnection);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.Parameters.AddWithValue("@cname", CourseName);
            objCommand.Parameters.AddWithValue("@cloc", CourseLocation);
            objCommand.Parameters.AddWithValue("@csdur", CourseDuration);
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

        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchCourse", objConnection);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                //courseID = objDataReader[0].ToString();
                courseName = objDataReader[1].ToString();
                courseLocation = objDataReader[2].ToString();
                courseDuration = Convert.ToInt32(objDataReader[3]);
                courseSemester = objDataReader[4].ToString();
                startDate = objDataReader[5].ToString();
                endDate = objDataReader[6].ToString();
                courseDelivery = objDataReader[7].ToString();
                hoursPerWeek = Convert.ToInt32(objDataReader[8]);
                noOfUnits = Convert.ToInt32(objDataReader[9]);
                courseFee = Convert.ToInt32(objDataReader[10]);
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

            string strSQL = "select * from course";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Course ID";
                dgv.Columns[1].HeaderText = "Course Name";
                dgv.Columns[2].HeaderText = "Course Location";
                dgv.Columns[3].HeaderText = "Course Duration";
                dgv.Columns[4].HeaderText = "Course Semester";
                dgv.Columns[5].HeaderText = "Start Date";
                dgv.Columns[6].HeaderText = "End Date";
                dgv.Columns[7].HeaderText = "Delivery";
                dgv.Columns[8].HeaderText = "Hrs/Week";
                dgv.Columns[9].HeaderText = "No. of Units";
                dgv.Columns[10].HeaderText = "Course Fee";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no courses");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {

        }
    }
}
