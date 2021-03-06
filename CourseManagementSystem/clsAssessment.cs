﻿using System;
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
    class clsAssessment :ILogic
    {
        private int assessmentID;
        private string assessmentName;
        private int unitID;
        private string unitName;
        private int teacherID;
        private string teacherFirstName;
        private string teacherLastName;
        private string startDate;
        private string dueDate;

        public clsAssessment()
        {
        }

        public clsAssessment(int assessmentID)
        {
            this.assessmentID = assessmentID;
        }

        public clsAssessment(int assessmentID, int unitID, int teacherID)
        {
            this.assessmentID = assessmentID;
            this.unitID = unitID;
            this.teacherID = teacherID;
        }

        public clsAssessment(string assessmentName, int unitID, int teacherID, string startDate, string dueDate)
        {
            this.unitID = unitID;
            this.teacherID = teacherID;
            this.assessmentName = assessmentName;
            this.startDate = startDate;
            this.dueDate = dueDate;
        }

        public clsAssessment(int assessmentID, string assessmentName, int unitID, int teacherID, string startDate, string dueDate)
        {
            this.assessmentID = assessmentID;
            this.unitID = unitID;
            this.teacherID = teacherID;
            this.assessmentName = assessmentName;
            this.startDate = startDate;
            this.dueDate = dueDate;
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
        public string TeacherFirstName
        {
            get
            {
                return teacherFirstName;
            }

            set
            {
                teacherFirstName = value;
            }
        }
        public string TeacherLastName
        {
            get
            {
                return teacherLastName;
            }

            set
            {
                teacherLastName = value;
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
        public string DueDate
        {
            get
            {
                return dueDate;
            }

            set
            {
                dueDate = value;
            }
        }
        #endregion

        /// <summary>
        /// This method connects to the database and runs the stored procedure InsertAssessment. 
        /// The procedure holds the query for inserting the assessment values into the assessment table. 
        /// 
        /// INSERT INTO Assessment VALUES(@uid, @tid, @aname, @sdate, @ddate);
        /// </summary>
        /// <returns></returns>
        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertAssessment", objConnection);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@aname", AssessmentName);
            objCommand.Parameters.AddWithValue("@sdate", StartDate);
            objCommand.Parameters.AddWithValue("@ddate", DueDate);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// This method connects to the database and runs the stored procedure DeleteAssessment.
        /// The procedure deletes a assessment from the table based on the ID that is passsed through.
        /// 
        /// DELETE FROM Assessment WHERE AssessmentID = @aid;
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteAssessment", objConnection);

            objCommand.Parameters.AddWithValue("@aid", AssessmentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        /// <summary>
        /// This method connects to the database and runs the stored procedure UpdateAssessment.
        /// The procedure updates an Assessment with the values passed in based on the chosen ID.
        /// 
        /// UPDATE Assessment SET UnitID = @uid, TeacherID = @tid, AssessmentName = @aname, StartDate = @sdate, DueDate = @ddate
        /// WHERE AssessmentID = @aid;
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateAssessment", objConnection);
            objCommand.Parameters.AddWithValue("@aid", AssessmentID);
            objCommand.Parameters.AddWithValue("@aname", AssessmentName);
            objCommand.Parameters.AddWithValue("@uid", UnitID);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@sdate", StartDate);
            objCommand.Parameters.AddWithValue("@ddate", DueDate);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// This method connects to the database and runs the stored procedure SearchStudent.
        /// The procedure selects a student based on the chosen ID and uses a DataReader to read
        /// the values from the table in the database. These values change the attributes within this class
        /// which the Form then uses to fill in the GUI elements.
        /// 
        /// Select A.assessmentid, A.assessmentname,  U.unitid, U.unitname, T.teacherid, T.teacherfirstname, T.teacherlastname, A.startdate, A.duedate
        /// from unit U inner join assessment A on U.unitid = A.unitid inner join teacher T on A.teacherid = T.teacherid where A.AssessmentID = @aid;
        /// </summary>
        /// <returns></returns>
        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchAssessment", objConnection);
            objCommand.Parameters.AddWithValue("@aid", AssessmentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                //assessmentID = Convert.ToInt32(objDataReader[0]);
                assessmentName = objDataReader[1].ToString();
                unitID = Convert.ToInt32(objDataReader[2]);
                unitName = objDataReader[3].ToString();
                teacherID = Convert.ToInt32(objDataReader[4]);
                teacherFirstName = objDataReader[5].ToString();
                teacherLastName = objDataReader[6].ToString();
                startDate = objDataReader[7].ToString();
                dueDate = objDataReader[8].ToString();
                objConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method connects to the database, reads through the table and fills the data grid view on the form with the corresponding values.
        /// The connection is written here rather than using the DatabaseClass CreateConnection method because the objDataAdapter requires
        /// the objConnection object which can't be retrieved from clsDatabase.
        /// </summary>
        /// <param name="dgv"></param>
        public void ViewAll(DataGridView dgv)
        {
            string strConnection = "server=localhost;database=randomdb;Trusted_Connection=yes";
            SqlConnection objConnection = new SqlConnection(strConnection);
            //SqlConnection objConnection = clsDatabase.CreateConnection();
            objConnection.Open();



#if DEBUG
            string strSQL = "select * from assessment";
#elif (!DEBUG)
            string strSQL = "SELECT A.assessmentid, A.assessmentname, "+
	            "U.unitid, U.unitname, "+
	            "T.teacherid, T.teacherfirstname, T.teacherlastname, "+
            	"A.startdate, A.duedate "+
                "FROM unit U inner join assessment A ON U.unitid = A.unitid "+
                "inner join teacher T ON A.teacherid = T.teacherid";
#endif
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                try
                {
                    dgv.DataSource = null;
                    dgv.DataSource = objDataTable;
                    dgv.AutoGenerateColumns = false;
                    dgv.Columns[0].HeaderText = "Assessment ID";
                    dgv.Columns[1].HeaderText = "Assessment Name";
                    dgv.Columns[2].HeaderText = "Unit ID";
                    dgv.Columns[3].HeaderText = "Unit Name";
                    dgv.Columns[4].HeaderText = "Teacher ID";
                    dgv.Columns[5].HeaderText = "Teacher First Name";
                    dgv.Columns[6].HeaderText = "Teacher Last Name";
                    dgv.Columns[7].HeaderText = "Start Date";
                    dgv.Columns[8].HeaderText = "Due Date";
                    dgv.AutoResizeColumns();
                    dgv.AutoSize = false;
                    dgv.Visible = true;
                    objConnection.Close();
                }
                catch(IndexOutOfRangeException e)
                {
                    MessageBox.Show(e.Message);
                }
                
            }
            else
            {
                MessageBox.Show("There are no assessments");
                objConnection.Close();
            }
        }

        /// <summary>
        /// Populates an array of comboboxes passed in from the form. This method is called upon load.
        /// </summary>
        /// <param name="cmb"></param>
        public void Load(ComboBox[] cmb)
        {
            string strSql = "select * from unit";
            clsDatabase.CreateConnection();
            DataTable objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[0].DataSource = objDataTable;
            cmb[0].DisplayMember = "unitid";
            cmb[0].ValueMember = "unitid";
            cmb[0].SelectedIndex = -1;
            cmb[0].Text = "";

            objDataTable = null;
            //strSql = "select * from unit";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[1].DataSource = objDataTable;
            cmb[1].DisplayMember = "unitname";
            cmb[1].ValueMember = "unitid";
            cmb[1].SelectedIndex = -1;
            cmb[1].Text = "Select a unit";

            objDataTable = null;
            strSql = "select * from teacher";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[2].DataSource = objDataTable;
            cmb[2].DisplayMember = "teacherid";
            cmb[2].ValueMember = "teacherid";
            cmb[2].SelectedIndex = -1;
            cmb[2].Text = "";

            objDataTable = null;
            strSql = "select teacherid, (teacherfirstname + ' ' + teacherlastname) as name from teacher";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[3].DataSource = objDataTable;
            cmb[3].DisplayMember = "name";
            cmb[3].ValueMember = "teacherid";
            cmb[3].SelectedIndex = -1;
            cmb[3].Text = "Select a teacher";
        }
    }
}
