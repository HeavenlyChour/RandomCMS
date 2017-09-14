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
        private string dateOfBirth;
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

        public clsStudent(string firstName, string lastName, string gender, string dateOfBirth, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, string disability, string disabilityDescription)
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

        public clsStudent(int studentID, string firstName, string lastName, string gender, string dateOfBirth, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, string disability, string disabilityDescription)
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
        

        //public void DeleteStudent(ArrayList arl)
        //{
        //    foreach (object stu in arl)
        //    {
        //        if (((clsStudent)stu).StudentID.Equals(this.StudentID))
        //        {
        //            arl.Remove(stu);
        //            break;
        //        }
        //    }
        //}

        public bool AddStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("CheckIfStudentExists", objConnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            objDataReader.Read();

            if(objDataReader.HasRows)
            {
                objDataReader.Close();
                string strSql = "insert into values(@sid, @fname, @lname, @gender, @dob, @staddress, @suburb, @postcode, @phoneno, @email, @nat, @dis, @disdesc)";
                SqlCommand objCommand1 = new SqlCommand(strSql, objConnection);
                objCommand.Parameters.AddWithValue("@sid", StudentID);
                objCommand.Parameters.AddWithValue("@fname", StudentID);
                objCommand.Parameters.AddWithValue("@lname", StudentID);
                objCommand.Parameters.AddWithValue("@gender", StudentID);
                objCommand.Parameters.AddWithValue("@dob", StudentID);
                objCommand.Parameters.AddWithValue("@staddress", StudentID);
                objCommand.Parameters.AddWithValue("@suburb", StudentID);
                objCommand.Parameters.AddWithValue("@postcode", StudentID);
                objCommand.Parameters.AddWithValue("@phoneno", StudentID);
                objCommand.Parameters.AddWithValue("@email", StudentID);
                objCommand.Parameters.AddWithValue("@nat", StudentID);
                objCommand.Parameters.AddWithValue("@dis", StudentID);
                objCommand.Parameters.AddWithValue("@disdesc", StudentID);
                return true;
            }
            else
            {
                objDataReader.Close();
                return false;
            }
        }

        public bool DeleteStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand1 = new SqlCommand("CheckIfStudentExists", objConnection);

            objCommand1.Parameters.AddWithValue("@sid", studentID);
            objCommand1.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand1.ExecuteReader();
            objDataReader.Read();

            if (objDataReader.HasRows)
            {
                objDataReader.Close();
                string strSql = "delete from student where studentid = @sid";
                SqlCommand objCommand2 = new SqlCommand(strSql, objConnection);
                objCommand2.ExecuteReader();
                objDataReader.Close();
                return true;
            }
            else
            {
                objDataReader.Close();
                return false;
            }
        }

        //public bool SearchStudent(ArrayList arl)
        //{
        //    bool valid = false;
        //    foreach (object stu in arl)
        //    {
        //        if (((clsStudent)stu).StudentID.Equals(this.studentID))
        //        {
        //            this.studentID = ((clsStudent)stu).studentID;
        //            this.firstName = ((clsStudent)stu).firstName;
        //            this.lastName = ((clsStudent)stu).lastName;
        //            this.dateOfBirth = ((clsStudent)stu).dateOfBirth;
        //            this.gender = ((clsStudent)stu).gender;
        //            this.streetAddress = ((clsStudent)stu).streetAddress;
        //            this.suburb = ((clsStudent)stu).suburb;
        //            this.postCode = ((clsStudent)stu).postCode;
        //            this.phoneNumber = ((clsStudent)stu).phoneNumber;
        //            this.email = ((clsStudent)stu).email;
        //            this.nationality = ((clsStudent)stu).nationality;
        //            this.disability = ((clsStudent)stu).disability;
        //            this.disabilityDetails = ((clsStudent)stu).disabilityDetails;
        //            valid = true;
        //            break;
        //        }
        //    }

        //    if (valid)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public void something()
        {

        }

        public void somethingElse()
        {

        }
    }
}
