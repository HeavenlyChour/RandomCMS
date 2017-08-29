using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.courseID = courseID;
        }

        public clsCourse(int courseID, string courseName, string courseLocation, string courseDuration, string courseSemester, string startDate, string endDate, string courseDelivery, int hoursPerWeek, int noOfUnits, double courseFee)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            this.courseLocation = courseLocation;
            this.courseDuration = courseDuration;
            this.courseSemester = courseSemester;
            this.startDate = startDate;
            this.endDate = endDate;
            this.courseDelivery = courseDelivery;
            this.hoursPerWeek = hoursPerWeek;
            this.noOfUnits = noOfUnits;
            this.courseFee = courseFee;
        }

        public int CourseID { get => courseID; set => courseID = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseLocation { get => courseLocation; set => courseLocation = value; }
        public string CourseDuration { get => courseDuration; set => courseDuration = value; }
        public string CourseSemester { get => courseSemester; set => courseSemester = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string CourseDelivery { get => courseDelivery; set => courseDelivery = value; }
        public int HoursPerWeek { get => hoursPerWeek; set => hoursPerWeek = value; }
        public int NoOfUnits { get => noOfUnits; set => noOfUnits = value; }
        public double CourseFee { get => courseFee; set => courseFee = value; }
    }


}
