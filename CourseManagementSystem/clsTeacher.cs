using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;
using System.Data.SqlClient;
using System.Data;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsTeacher
    {
        private int teacherID;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string gender;
        private string streetAddress;
        private string suburb;
        private string postCode;
        private string phoneNumber;
        private string email;
        private DateTime commencementDate;
        private string classTaught;
        private string skills;
        private string leave;

        

        public clsTeacher()
        {
        }

        public clsTeacher(int teacherID)
        {
            this.TeacherID = teacherID;
        }

        public clsTeacher(string firstName, string lastName, DateTime dateOfBirth, string gender, string streetAddress, string suburb, string postCode, string phoneNumber, string email, DateTime commencementDate, string classTaught, string skills, string leave)
        {
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

        public clsTeacher(int teacherID, string firstName, string lastName, DateTime dateOfBirth, string gender, string streetAddress, string suburb, string postCode, string phoneNumber, string email, DateTime commencementDate, string classTaught, string skills, string leave)
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

        public DateTime DateOfBirth
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

        public DateTime CommencementDate
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

        public string Leave
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

        public bool AddTeacher()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertTeacher", objConnection);

            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@suburb", Suburb);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@commdate", CommencementDate);
            objCommand.Parameters.AddWithValue("@clstaught", ClassTaught);
            objCommand.Parameters.AddWithValue("@skills", Skills);
            objCommand.Parameters.AddWithValue("@leave", Leave);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool DeleteTeacher()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteTeacher", objConnection);

            objCommand.Parameters.AddWithValue("@tid", teacherID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool UpdateTeacher()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateStudent", objConnection);
            objCommand.Parameters.AddWithValue("@sid", TeacherID);
            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@suburb", Suburb);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@commdate", CommencementDate);
            objCommand.Parameters.AddWithValue("@clstaught", ClassTaught);
            objCommand.Parameters.AddWithValue("@skills", Skills);
            objCommand.Parameters.AddWithValue("@leave", Leave);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }
        //private int teacherID;
        //private string firstName;
        //private string lastName;
        //private string dateOfBirth;
        //private string gender;
        //private string streetAddress;
        //private string suburb;
        //private string postCode;
        //private string phoneNumber;
        //private string email;
        //private string commencementDate;
        //private string classTaught;
        //private string skills;
        //private bool leave;
    }
}
