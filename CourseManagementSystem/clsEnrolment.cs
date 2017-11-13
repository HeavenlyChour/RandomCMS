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
    class clsEnrolment : ILogic
    {
        private int enrolmentID;
        private int studentID;
        private string studentName;
        private int courseID;
        private string courseName;
        private string enrolmentDate;
        private string expectedEndDate;
        private string courseDelivery;
        private float amountDue;
        private string paymentDueDate;
        private string paymentMethod;
        private string paymentStatus;
        private string datePaid;
        //private string disability;
        //private string disabilityDetails;
        private string studyStatus;

        public clsEnrolment()
        {
        }

        public clsEnrolment(int enrolmentID)
        {
            this.EnrolmentID = enrolmentID;
        }

        public clsEnrolment(int enrolmentID, int studentID, int courseID)
        {
            this.EnrolmentID = enrolmentID;
            this.StudentID = studentID;
            this.CourseID = courseID;
        }

        public clsEnrolment(int studentID, int courseID, string enrolmentDate, string expectedEndDate, string courseDelivery, float amountDue, string paymentDueDate, string paymentMethod, string paymentStatus, string datePaid, string studyStatus)
        {
            this.StudentID = studentID;
            this.CourseID = courseID;
            this.EnrolmentDate = enrolmentDate;
            this.ExpectedEndDate = expectedEndDate;
            this.CourseDelivery = courseDelivery;
            this.AmountDue = amountDue;
            this.PaymentDueDate = paymentDueDate;
            this.PaymentMethod = paymentMethod;
            this.PaymentStatus = paymentStatus;
            this.DatePaid = datePaid;
            //this.Disability = disability;
            //this.DisabilityDetails = disabilityDetails;
            this.StudyStatus = studyStatus;
        }

        public clsEnrolment(int enrolmentID, int studentID, int courseID, string enrolmentDate, string expectedEndDate, string courseDelivery, float amountDue, string paymentDueDate, string paymentMethod, string paymentStatus, string datePaid, string studyStatus)
        {
            this.EnrolmentID = enrolmentID;
            this.StudentID = studentID;
            this.CourseID = courseID;
            this.EnrolmentDate = enrolmentDate;
            this.ExpectedEndDate = expectedEndDate;
            this.CourseDelivery = courseDelivery;
            this.AmountDue = amountDue;
            this.PaymentDueDate = paymentDueDate;
            this.PaymentMethod = paymentMethod;
            this.PaymentStatus = paymentStatus;
            this.DatePaid = datePaid;
            //this.Disability = disability;
            //this.DisabilityDetails = disabilityDetails;
            this.StudyStatus = studyStatus;
        }

        #region Getters and Setters
        public int EnrolmentID
        {
            get
            {
                return enrolmentID;
            }

            set
            {
                enrolmentID = value;
            }
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

        public string StudentName
        {
            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
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

        public string EnrolmentDate
        {
            get
            {
                return enrolmentDate;
            }

            set
            {
                enrolmentDate = value;
            }
        }

        public string ExpectedEndDate
        {
            get
            {
                return expectedEndDate;
            }

            set
            {
                expectedEndDate = value;
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

        public float AmountDue
        {
            get
            {
                return amountDue;
            }

            set
            {
                amountDue = value;
            }
        }

        public string PaymentDueDate
        {
            get
            {
                return paymentDueDate;
            }

            set
            {
                paymentDueDate = value;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return paymentMethod;
            }

            set
            {
                paymentMethod = value;
            }
        }

        public string PaymentStatus
        {
            get
            {
                return paymentStatus;
            }

            set
            {
                paymentStatus = value;
            }
        }

        public string DatePaid
        {
            get
            {
                return datePaid;
            }

            set
            {
                datePaid = value;
            }
        }

        public string StudyStatus
        {
            get
            {
                return studyStatus;
            }

            set
            {
                studyStatus = value;
            }
        }
        #endregion

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertEnrolment", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.Parameters.AddWithValue("@enroldate", EnrolmentDate);
            objCommand.Parameters.AddWithValue("@enddate", ExpectedEndDate);
            objCommand.Parameters.AddWithValue("@coursedel", CourseDelivery);
            objCommand.Parameters.AddWithValue("@paymeth", PaymentMethod);
            objCommand.Parameters.AddWithValue("@payduedate", PaymentDueDate);
            objCommand.Parameters.AddWithValue("@amountpaid", AmountPaid);
            objCommand.Parameters.AddWithValue("@balowing", BalanceOwing);
            objCommand.Parameters.AddWithValue("@paystat", PaymentStatus);
            //objCommand.Parameters.AddWithValue("@dis", Disability);
            //objCommand.Parameters.AddWithValue("@disdetails", DisabilityDetails);
            objCommand.Parameters.AddWithValue("@studystat", StudyStatus);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteEnrolment", objConnection);

            objCommand.Parameters.AddWithValue("@eid", EnrolmentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateEnrolment", objConnection);
            objCommand.Parameters.AddWithValue("@eid", EnrolmentID);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.Parameters.AddWithValue("@enroldate", EnrolmentDate);
            objCommand.Parameters.AddWithValue("@enddate", ExpectedEndDate);
            objCommand.Parameters.AddWithValue("@coursedel", CourseDelivery);
            objCommand.Parameters.AddWithValue("@paymeth", PaymentMethod);
            objCommand.Parameters.AddWithValue("@payduedate", PaymentDueDate);
            objCommand.Parameters.AddWithValue("@amountpaid", AmountPaid);
            objCommand.Parameters.AddWithValue("@balanceowe", BalanceOwing);
            objCommand.Parameters.AddWithValue("@paystat", PaymentStatus);
            //objCommand.Parameters.AddWithValue("@dis", Disability);
            //objCommand.Parameters.AddWithValue("@disdetails", DisabilityDetails);
            objCommand.Parameters.AddWithValue("@studystat", StudyStatus);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchEnrolment", objConnection);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                StudentID = Convert.ToInt32(objDataReader[1]);
                StudentName = objDataReader[2].ToString();
                CourseID = Convert.ToInt32(objDataReader[3]);
                CourseName = objDataReader[4].ToString();
                EnrolmentDate = objDataReader[6].ToString();
                ExpectedEndDate = objDataReader[7].ToString();
                PaymentMethod = objDataReader[8].ToString();
                PaymentDueDate = objDataReader[9].ToString();
                //amountPaid = Convert.ToInt32(objDataReader[10]);
                //balanceOwing = Convert.ToInt32(objDataReader[11]);
                PaymentStatus = objDataReader[12].ToString();
                StudyStatus = objDataReader[13].ToString();
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

            string strSQL = "select * from enrolment";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Enroment ID";
                dgv.Columns[1].HeaderText = "Student ID";
                dgv.Columns[2].HeaderText = "Student Name";
                dgv.Columns[3].HeaderText = "Course ID";
                dgv.Columns[4].HeaderText = "Course Name";
                dgv.Columns[5].HeaderText = "Enrolment Date";
                dgv.Columns[6].HeaderText = "Expected End Date";
                dgv.Columns[7].HeaderText = "Delivery";
                dgv.Columns[8].HeaderText = "Payment Method";
                dgv.Columns[9].HeaderText = "Payment Due Date";
                dgv.Columns[10].HeaderText = "Amount Paid";
                dgv.Columns[11].HeaderText = "Balance Owed";
                dgv.Columns[12].HeaderText = "Payment Status";
                dgv.Columns[13].HeaderText = "Study Status";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no enrolments");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            throw new NotImplementedException();
        }
    }
}
