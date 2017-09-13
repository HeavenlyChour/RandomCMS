using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsUnit
    {
        private int unitID;
        private string unitName;
        private int noOfHours;
        private int noOfAssessments;
        private string unitType;

        
        public clsUnit()
        {
        }

        public clsUnit(int unitID)
        {
            this.UnitID = unitID;
        }

        public clsUnit(int unitID, string unitName, int noOfHours, int noOfAssessments, string unitType)
        {
            this.UnitID = unitID;
            this.UnitName = unitName;
            this.NoOfHours = noOfHours;
            this.NoOfAssessments = noOfAssessments;
            this.UnitType = unitType;
        }

        #region Getters and Setters
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

        public string UnitName
        {
            get
            {
                return unitName;
            }

            set
            {
                unitName = value;
            }
        }

        public int NoOfHours
        {
            get
            {
                return noOfHours;
            }

            set
            {
                noOfHours = value;
            }
        }

        public int NoOfAssessments
        {
            get
            {
                return noOfAssessments;
            }

            set
            {
                noOfAssessments = value;
            }
        }

        public string UnitType
        {
            get
            {
                return unitType;
            }

            set
            {
                unitType = value;
            }
        }
        #endregion

        //public int UnitID { get => unitID; set => unitID = value; }
        //public string UnitName { get => unitName; set => unitName = value; }
        //public int NoOfHours { get => noOfHours; set => noOfHours = value; }
        //public int NoOfAssessments { get => noOfAssessments; set => noOfAssessments = value; }
        //public string UnitType { get => unitType; set => unitType = value; }
    }
}
