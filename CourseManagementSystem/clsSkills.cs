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
    class clsSkills: ILogic
    {
        private int skillID;
        private string skillName;
        private string skillDescription;

        

        public clsSkills()
        {
        }

        public clsSkills(int skillID)
        {
            this.SkillID = skillID;
        }

        public clsSkills(string skillName, string skillDescription)
        {
            
            this.SkillName = skillName;
            this.SkillDescription = skillDescription;
        }

        public clsSkills(int skillID, string skillName, string skillDescription)
        {
            this.SkillID = skillID;
            this.SkillName = skillName;
            this.SkillDescription = skillDescription;
        }

        #region Getters and Setters
        public int SkillID
        {
            get
            {
                return skillID;
            }

            set
            {
                skillID = value;
            }
        }

        public string SkillName
        {
            get
            {
                return skillName;
            }

            set
            {
                skillName = value;
            }
        }

        public string SkillDescription
        {
            get
            {
                return skillDescription;
            }

            set
            {
                skillDescription = value;
            }
        }
        #endregion

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertSkill", objConnection);
            objCommand.Parameters.AddWithValue("@skname", SkillName);
            objCommand.Parameters.AddWithValue("@skdesc", SkillDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteSkill", objConnection);

            objCommand.Parameters.AddWithValue("@skid", SkillID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateSkill", objConnection);
            objCommand.Parameters.AddWithValue("@skid", SkillID);
            objCommand.Parameters.AddWithValue("@skname", SkillName);
            objCommand.Parameters.AddWithValue("@skdesc", SkillDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchSkill", objConnection);
            objCommand.Parameters.AddWithValue("@skid", SkillID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                skillName = objDataReader[1].ToString();
                skillDescription = objDataReader[2].ToString();
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

            string strSQL = "select * from skill";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Skill ID";
                dgv.Columns[1].HeaderText = "Skill Name";
                dgv.Columns[2].HeaderText = "Skill Description";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no skills");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            throw new NotImplementedException();
        }
    }
}
