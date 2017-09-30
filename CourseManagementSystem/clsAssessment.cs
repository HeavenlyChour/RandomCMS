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


    }
}
