using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsEnrolment
    {
        private int enrolmentID;
        private int studentID;
        private int courseID;
        private string enrolmentDate;
        private string expectedEndDate;
        private string courseDelivery;
        private string paymentMethod;
        private string paymentDueDate;
        private double amountPaid;
        private double balanceOwing;
        private string paymentStatus;
        private bool disability;
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

        public clsEnrolment(int enrolmentID, int studentID, int courseID, string enrolmentDate, string expectedEndDate, string courseDelivery, string paymentMethod, string paymentDueDate, double amountPaid, double balanceOwing, string paymentStatus, bool disability, string disabilityDetails, string studyStatus)
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

        public bool Disability
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

        //public int EnrolmentID { get => enrolmentID; set => enrolmentID = value; }
        //public int StudentID { get => studentID; set => studentID = value; }
        //public int CourseID { get => courseID; set => courseID = value; }
        //public string EnrolmentDate { get => enrolmentDate; set => enrolmentDate = value; }
        //public string ExpectedEndDate { get => expectedEndDate; set => expectedEndDate = value; }
        //public string CourseDelivery { get => courseDelivery; set => courseDelivery = value; }
        //public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        //public string PaymentDueDate { get => paymentDueDate; set => paymentDueDate = value; }
        //public double AmountPaid { get => amountPaid; set => amountPaid = value; }
        //public double BalanceOwing { get => balanceOwing; set => balanceOwing = value; }
        //public string PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        //public bool Disability { get => disability; set => disability = value; }
        //public string DisabilityDetails { get => disabilityDetails; set => disabilityDetails = value; }
        //public string StudyStatus { get => studyStatus; set => studyStatus = value; }
    }
}
