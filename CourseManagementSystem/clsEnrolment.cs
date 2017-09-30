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
    class clsEnrolment
    {
        private int enrolmentID;
        private int studentID;
        private int courseID;
        private DateTime enrolmentDate;
        private DateTime expectedEndDate;
        private string courseDelivery;
        private string paymentMethod;
        private DateTime paymentDueDate;
        private double amountPaid;
        private double balanceOwing;
        private string paymentStatus;
        private string disability;
        private string disabilityDetails;
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

        public clsEnrolment(int studentID, int courseID, DateTime enrolmentDate, DateTime expectedEndDate, string courseDelivery, string paymentMethod, DateTime paymentDueDate, double amountPaid, double balanceOwing, string paymentStatus, string disability, string disabilityDetails, string studyStatus)
        {
            this.StudentID = studentID;
            this.CourseID = courseID;
            this.EnrolmentDate = enrolmentDate;
            this.ExpectedEndDate = expectedEndDate;
            this.CourseDelivery = courseDelivery;
            this.PaymentMethod = paymentMethod;
            this.PaymentDueDate = paymentDueDate;
            this.AmountPaid = amountPaid;
            this.BalanceOwing = balanceOwing;
            this.PaymentStatus = paymentStatus;
            this.Disability = disability;
            this.DisabilityDetails = disabilityDetails;
            this.StudyStatus = studyStatus;
        }

        public clsEnrolment(int enrolmentID, int studentID, int courseID, DateTime enrolmentDate, DateTime expectedEndDate, string courseDelivery, string paymentMethod, DateTime paymentDueDate, double amountPaid, double balanceOwing, string paymentStatus, string disability, string disabilityDetails, string studyStatus)
        {
            this.EnrolmentID = enrolmentID;
            this.StudentID = studentID;
            this.CourseID = courseID;
            this.EnrolmentDate = enrolmentDate;
            this.ExpectedEndDate = expectedEndDate;
            this.CourseDelivery = courseDelivery;
            this.PaymentMethod = paymentMethod;
            this.PaymentDueDate = paymentDueDate;
            this.AmountPaid = amountPaid;
            this.BalanceOwing = balanceOwing;
            this.PaymentStatus = paymentStatus;
            this.Disability = disability;
            this.DisabilityDetails = disabilityDetails;
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

        public DateTime EnrolmentDate
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

        public DateTime ExpectedEndDate
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

        public DateTime PaymentDueDate
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

        public double AmountPaid
        {
            get
            {
                return amountPaid;
            }

            set
            {
                amountPaid = value;
            }
        }

        public double BalanceOwing
        {
            get
            {
                return balanceOwing;
            }

            set
            {
                balanceOwing = value;
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

        public string Disability
        {
            get
            {
                return disability;
            }

            set
            {
                disability = value;
            }
        }

        public string DisabilityDetails
        {
            get
            {
                return disabilityDetails;
            }

            set
            {
                disabilityDetails = value;
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

        public bool AddEnrolment()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertEnrolment", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.Parameters.AddWithValue("@enroldate", EnrolmentDate);
            objCommand.Parameters.AddWithValue("@enddate", ExpectedEndDate);
            objCommand.Parameters.AddWithValue("@coursedev", CourseDelivery);
            objCommand.Parameters.AddWithValue("@paymeth", PaymentMethod);
            objCommand.Parameters.AddWithValue("@payduedate", PaymentDueDate);
            objCommand.Parameters.AddWithValue("@amountpaid", AmountPaid);
            objCommand.Parameters.AddWithValue("@balanceowe", BalanceOwing);
            objCommand.Parameters.AddWithValue("@paystat", PaymentStatus);
            objCommand.Parameters.AddWithValue("@dis", Disability);
            objCommand.Parameters.AddWithValue("@disdetails", DisabilityDetails);
            objCommand.Parameters.AddWithValue("@studystat", StudyStatus);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteEnrolment()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteEnrolment", objConnection);

            objCommand.Parameters.AddWithValue("@eid", EnrolmentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateEnrolment()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateEnrolment", objConnection);
            objCommand.Parameters.AddWithValue("@eid", EnrolmentID);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@cid", CourseID);
            objCommand.Parameters.AddWithValue("@enroldate", EnrolmentDate);
            objCommand.Parameters.AddWithValue("@enddate", ExpectedEndDate);
            objCommand.Parameters.AddWithValue("@coursedev", CourseDelivery);
            objCommand.Parameters.AddWithValue("@paymeth", PaymentMethod);
            objCommand.Parameters.AddWithValue("@payduedate", PaymentDueDate);
            objCommand.Parameters.AddWithValue("@amountpaid", AmountPaid);
            objCommand.Parameters.AddWithValue("@balanceowe", BalanceOwing);
            objCommand.Parameters.AddWithValue("@paystat", PaymentStatus);
            objCommand.Parameters.AddWithValue("@dis", Disability);
            objCommand.Parameters.AddWithValue("@disdetails", DisabilityDetails);
            objCommand.Parameters.AddWithValue("@studystat", StudyStatus);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

    }
}
