using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;


namespace CourseManagementSystem
{
    class clsCourse
    {
        private int courseID;
        private string courseName;
        private string courseLocation;
        private string courseDuration;
        private string courseSemester;
        private string startDate;
        private string endDate;
        private string courseDelivery;
        private int hoursPerWeek;
        private int noOfUnits;
        private double courseFee;
        

        public clsCourse()
        {
        }

        public clsCourse(int courseID)
        {
            this.CourseID = courseID;
        }

        public clsCourse(int courseID, string courseName, string courseLocation, string courseDuration, string courseSemester, string startDate, string endDate, string courseDelivery, int hoursPerWeek, int noOfUnits, double courseFee)
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

        public string CourseDuration
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

        public double CourseFee
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
        
        //public int CourseID { get => courseID; set => courseID = value; }
        //public string CourseName { get => courseName; set => courseName = value; }
        //public string CourseLocation { get => courseLocation; set => courseLocation = value; }
        //public string CourseDuration { get => courseDuration; set => courseDuration = value; }
        //public string CourseSemester { get => courseSemester; set => courseSemester = value; }
        //public string StartDate { get => startDate; set => startDate = value; }
        //public string EndDate { get => endDate; set => endDate = value; }
        //public string CourseDelivery { get => courseDelivery; set => courseDelivery = value; }
        //public int HoursPerWeek { get => hoursPerWeek; set => hoursPerWeek = value; }
        //public int NoOfUnits { get => noOfUnits; set => noOfUnits = value; }
        //public double CourseFee { get => courseFee; set => courseFee = value; }
    }
}
