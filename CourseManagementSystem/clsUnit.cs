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

        public clsUnit(string unitName, int noOfHours, int noOfAssessments, string unitType)
        {
            this.UnitName = unitName;
            this.NoOfHours = noOfHours;
            this.NoOfAssessments = noOfAssessments;
            this.UnitType = unitType;
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

        public bool AddUnit()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertUnit", objConnection);
            objCommand.Parameters.AddWithValue("@uname", UnitName);
            objCommand.Parameters.AddWithValue("@noofhours", NoOfHours);
            objCommand.Parameters.AddWithValue("@noofass", NoOfAssessments);
            objCommand.Parameters.AddWithValue("@unittype", UnitType);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteUnit()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteUnit", objConnection);

            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateUnit()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateUnit", objConnection);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.Parameters.AddWithValue("@uname", UnitName);
            objCommand.Parameters.AddWithValue("@noofhours", NoOfHours);
            objCommand.Parameters.AddWithValue("@noofass", NoOfAssessments);
            objCommand.Parameters.AddWithValue("@unittype", UnitType);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }
        //private int unitID;
        //private string unitName;
        //private int noOfHours;
        //private int noOfAssessments;
        //private string unitType;
    }
}
