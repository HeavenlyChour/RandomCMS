using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsTeacher
    {
        private int teacherID;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string gender;
        private string streetAddress;
        private string suburb;
        private string postCode;
        private string phoneNumber;
        private string email;
        private string commencementDate;
        private string classTaught;
        private string skills;
        private bool leave;

        

        public clsTeacher()
        {
        }

        public clsTeacher(int teacherID)
        {
            this.TeacherID = teacherID;
        }

        public clsTeacher(int teacherID, string firstName, string lastName, string dateOfBirth, string gender, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string commencementDate, string classTaught, string skills, bool leave)
        {
            this.TeacherID = teacherID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.StreetAddress = streetAddress;
            this.Suburb = suburb;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CommencementDate = commencementDate;
            this.ClassTaught = classTaught;
            this.Skills = skills;
            this.Leave = leave;
        }

        #region Getters and Setters
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

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }

            set
            {
                streetAddress = value;
            }
        }

        public string Suburb
        {
            get
            {
                return suburb;
            }

            set
            {
                suburb = value;
            }
        }

        public string PostCode
        {
            get
            {
                return postCode;
            }

            set
            {
                postCode = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string CommencementDate
        {
            get
            {
                return commencementDate;
            }

            set
            {
                commencementDate = value;
            }
        }

        public string ClassTaught
        {
            get
            {
                return classTaught;
            }

            set
            {
                classTaught = value;
            }
        }

        public string Skills
        {
            get
            {
                return skills;
            }

            set
            {
                skills = value;
            }
        }

        public bool Leave
        {
            get
            {
                return leave;
            }

            set
            {
                leave = value;
            }
        }
        #endregion

        //public int TeacherID { get => teacherID; set => teacherID = value; }
        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
        //public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        //public string Gender { get => gender; set => gender = value; }
        //public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        //public string Suburb { get => suburb; set => suburb = value; }
        //public string PostCode { get => postCode; set => postCode = value; }
        //public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        //public string Email { get => email; set => email = value; }
        //public string CommencementDate { get => commencementDate; set => commencementDate = value; }
        //public string ClassTaught { get => classTaught; set => classTaught = value; }
        //public string Skills { get => skills; set => skills = value; }
        //public bool Leave { get => leave; set => leave = value; }
    }
}
