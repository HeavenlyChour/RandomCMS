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
    class clsUnit: ILogic
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

        public clsUnit(string unitName, int noOfHours, string unitType)
        {
            this.UnitName = unitName;
            this.NoOfHours = noOfHours;
            this.UnitType = unitType;
        }

        public clsUnit(string unitName, int noOfHours, int noOfAssessments, string unitType)
        {
            this.UnitName = unitName;
            this.NoOfHours = noOfHours;
            this.NoOfAssessments = noOfAssessments;
            this.UnitType = unitType;
        }

        public clsUnit(int unitID, string unitName, int noOfHours, string unitType)
        {
            this.UnitID = unitID;
            this.UnitName = unitName;
            this.NoOfHours = noOfHours;
            //this.NoOfAssessments = noOfAssessments;
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

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertUnit", objConnection);
            objCommand.Parameters.AddWithValue("@uname", UnitName);
            objCommand.Parameters.AddWithValue("@noofhours", NoOfHours);
            //objCommand.Parameters.AddWithValue("@noofass", NoOfAssessments);
            objCommand.Parameters.AddWithValue("@unittype", UnitType);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteUnit", objConnection);

            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateUnit", objConnection);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.Parameters.AddWithValue("@uname", UnitName);
            objCommand.Parameters.AddWithValue("@noofhours", NoOfHours);
            //objCommand.Parameters.AddWithValue("@noofass", NoOfAssessments);
            objCommand.Parameters.AddWithValue("@unittype", UnitType);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchUnit", objConnection);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                unitName = objDataReader[1].ToString();
                noOfHours = Convert.ToInt32(objDataReader[2]);
                noOfAssessments = Convert.ToInt32(objDataReader[3]);
                unitType = objDataReader[4].ToString();
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

            string strSQL = "select * from unit";
            //string strSQL = "SELECT U.UnitID, U.UnitName, U.NoOfHours, COUNT(A.AssessmentID) AS NoOfAssessments, U.UnitType FROM Unit U" +
            //    "Left Join Assessment A ON(U.UnitID = A.UnitID) GROUP BY U.UnitID, U.UnitName, U.NoOfHours, U.UnitType";

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Unit ID";
                dgv.Columns[1].HeaderText = "Unit Name";
                dgv.Columns[2].HeaderText = "No of Hours";
                //dgv.Columns[3].HeaderText = "No of Assessments";
                dgv.Columns[3].HeaderText = "Unit Type";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no assessments");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            throw new NotImplementedException();
        }
        //private int unitID;
        //private string unitName;
        //private int noOfHours;
        //private string unitType;
    }
}
