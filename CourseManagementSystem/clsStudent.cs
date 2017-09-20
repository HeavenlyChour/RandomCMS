using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DatabaseClass;

namespace CourseManagementSystem
{
    class clsStudent
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string gender;
        //private string dateOfBirth;
        private DateTime dateOfBirth;
        private string streetAddress;
        private string suburb;
        private string postCode;
        private string phoneNumber;
        private string email;
        private string nationality;
        private string disability;
        private string disabilityDescription;

        public clsStudent()
        {
        }

        public clsStudent(int studentID)
        {
            this.StudentID = studentID;
        }

        public clsStudent(int studentID, string firstName, string lastName)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public clsStudent(string firstName, string lastName, string gender, DateTime dateOfBirth, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, string disability, string disabilityDescription)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.StreetAddress = streetAddress;
            this.Suburb = suburb;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Nationality = nationality;
            this.Disability = disability;
            this.DisabilityDescription = disabilityDescription;
        }

        public clsStudent(int studentID, string firstName, string lastName, string gender, DateTime dateOfBirth, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, string disability, string disabilityDescription)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.StreetAddress = streetAddress;
            this.Suburb = suburb;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Nationality = nationality;
            this.Disability = disability;
            this.DisabilityDescription = disabilityDescription;
        }

        #region Getters and Setters
        public int StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
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

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public string Disability
        {
            get
            {
                return disability;
            }

            set
            {
                disability = value;
            }
        }

        public string DisabilityDescription
        {
            get
            {
                return disabilityDescription;
            }

            set
            {
                disabilityDescription = value;
            }
        }
        #endregion
        


        public bool AddStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            //SqlCommand objCommand = new SqlCommand("CheckIfStudentExists", objConnection);
            
            //SqlDataReader objDataReader = objCommand.ExecuteReader();
            //objDataReader.Read();

            //if(objDataReader.HasRows)
            //{
                //objDataReader.Close();
                //string strSql = "insert into values(@fname, @lname, @gender, @dob, @staddress, @suburb, @postcode, @phoneno, @email, @nat, @dis, @disdetails)";
                SqlCommand objCommand = new SqlCommand("CheckIfStudentExists", objConnection);
                //objCommand.Parameters.AddWithValue("@sid", StudentID);
                objCommand.Parameters.AddWithValue("@fname", FirstName);
                objCommand.Parameters.AddWithValue("@lname", LastName);
                objCommand.Parameters.AddWithValue("@gender", Gender);
                objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
                objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
                objCommand.Parameters.AddWithValue("@suburb", Suburb);
                objCommand.Parameters.AddWithValue("@postcode", PostCode);
                objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
                objCommand.Parameters.AddWithValue("@email", Email);
                objCommand.Parameters.AddWithValue("@nat", Nationality);
                objCommand.Parameters.AddWithValue("@dis", Disability);
                objCommand.Parameters.AddWithValue("@disdetails", DisabilityDescription);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.ExecuteNonQuery();
                return true;
            //}
            //else
            //{
            //    objDataReader.Close();
            //    return false;
            //}
        }

        public bool DeleteStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteStudent", objConnection);

            objCommand.Parameters.AddWithValue("@sid", studentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
            //objDataReader.Read();

            //if (objDataReader.HasRows)
            //{
            //    objDataReader.Close();
            //    string strSql = "delete from student where studentid = @sid";
            //    SqlCommand objCommand2 = new SqlCommand(strSql, objConnection);
            //    objCommand2.ExecuteReader();
            //    objDataReader.Close();
            //    return true;
            //}
            //else
            //{
            //    objDataReader.Close();
            //    return false;
            //}
        }
        
        public bool UpdateStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateStudent", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@suburb", Suburb);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@nat", Nationality);
            objCommand.Parameters.AddWithValue("@dis", Disability);
            objCommand.Parameters.AddWithValue("@disdetails", DisabilityDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }
    }
}
