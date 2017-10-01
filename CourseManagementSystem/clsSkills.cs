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
    class clsSkills
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


        public bool AddSkill()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertAssessment", objConnection);
            objCommand.Parameters.AddWithValue("@skname", SkillName);
            objCommand.Parameters.AddWithValue("@skweeks", SkillDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteSkill()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteSkill", objConnection);

            objCommand.Parameters.AddWithValue("@skid", SkillID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateSkill()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateSkill", objConnection);
            objCommand.Parameters.AddWithValue("@skid", SkillID);
            objCommand.Parameters.AddWithValue("@skname", SkillName);
            objCommand.Parameters.AddWithValue("@skweeks", SkillDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }
    }
}
