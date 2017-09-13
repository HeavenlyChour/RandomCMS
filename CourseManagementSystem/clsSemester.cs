using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddSemester()
        {

        }
    }
}
