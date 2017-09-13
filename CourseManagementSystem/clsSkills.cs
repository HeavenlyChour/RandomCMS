using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void AddSkill()
        {

        }
    }
}
