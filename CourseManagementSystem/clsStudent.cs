using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DatabaseClass;
using static CourseManagementSystem.clsExceptionHandling;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class clsStudent : ILogic
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string gender;
        private string dateOfBirth;
        //private DateTime dateOfBirth;
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

        public clsStudent(string firstName, string lastName, string dateOfBirth, string gender, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, string disability, string disabilityDescription)
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

        public clsStudent(int studentID, string firstName, string lastName, string dateOfBirth, string gender, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, string disability, string disabilityDescription)
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

        /// <summary>
        /// This method connects to the database and runs the stored procedure InsertStudent. 
        /// The procedure holds the query for inserting the student values into the student table. 
        /// INSERT INTO student VALUES(@fname, @lname, @gender, @dob, @staddress, @suburb, @postcode, @phoneno, @email, @nat, @dis, @disdetails);
        /// </summary>
        /// <returns></returns>
        //public bool AddStudent()
        //{
        //    SqlConnection objConnection = clsDatabase.CreateConnection();
        //    SqlCommand objCommand = new SqlCommand("InsertStudent", objConnection);
        //    objCommand.Parameters.AddWithValue("@fname", FirstName);
        //    objCommand.Parameters.AddWithValue("@lname", LastName);
        //    objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
        //    objCommand.Parameters.AddWithValue("@gender", Gender);
        //    objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
        //    objCommand.Parameters.AddWithValue("@suburb", Suburb);
        //    objCommand.Parameters.AddWithValue("@postcode", PostCode);
        //    objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
        //    objCommand.Parameters.AddWithValue("@email", Email);
        //    objCommand.Parameters.AddWithValue("@nat", Nationality);
        //    objCommand.Parameters.AddWithValue("@dis", Disability);
        //    objCommand.Parameters.AddWithValue("@disdetails", DisabilityDescription);
        //    objCommand.CommandType = CommandType.StoredProcedure;
        //    objCommand.ExecuteNonQuery();
        //    return true;
        //}

        /// <summary>
        /// This method connects to the database and runs the stored procedure DeleteStudent.
        /// The procedure deletes a student from the table based on the ID that is passsed through.
        /// DELETE FROM student WHERE StudentID = @sid;
        /// </summary>
        /// <returns></returns>
        public bool DeleteStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteStudent", objConnection);

            objCommand.Parameters.AddWithValue("@sid", studentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        /// <summary>
        /// This method connects to the database and runs the stored procedure UpdateStudent.
        /// The procedure updates a student with the values passed in based on the chosen ID.
        /// UPDATE student SET StudentFirstName = @fname, StudentLastName = @lname, StudentGender = @gender, StudentDOB = @dob, 
        /// StudentStreetAddress = @staddress, StudentSuburb = @suburb, StudentPostCode = @postcode, StudentPhoneNo = @phoneno, 
        /// StudentEmail = @email, StudentNationality = @nat, Disability = @dis, DisabilityDescription = @disdetails WHERE StudentID = @sid;
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method connects to the database and runs the stored procedure SearchStudent.
        /// The procedure selects a student based on the chosen ID and uses a DataReader to read
        /// the values from the table in the database. These values change the attributes within this class
        /// which the Form then uses to fill in the GUI elements.
        /// SELECT * FROM student WHERE StudentID = @sid;
        /// </summary>
        /// <returns></returns>
        public bool SearchStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchStudent", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                firstName = objDataReader[1].ToString();
                lastName = objDataReader[2].ToString();
                gender = objDataReader[3].ToString();
                dateOfBirth = objDataReader[4].ToString();
                streetAddress = objDataReader[5].ToString();
                suburb = objDataReader[6].ToString();
                postCode = objDataReader[7].ToString();
                phoneNumber = objDataReader[8].ToString();
                email = objDataReader[9].ToString();
                nationality = objDataReader[10].ToString();
                disability = objDataReader[11].ToString();
                disabilityDescription = objDataReader[12].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertStudent", objConnection);
            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@gender", Gender);
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
