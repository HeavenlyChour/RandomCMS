﻿using System;
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
        private int suburbID;
        private string suburbName;
        private string postCode;
        private string phoneNumber;
        private string email;
        private int countryID;
        private string countryName;
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

        public clsStudent(string firstName, string lastName, string gender, string dateOfBirth, string streetAddress, int suburbID, string postCode, string phoneNumber, string email, int countryID, string disability, string disabilityDescription)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.StreetAddress = streetAddress;
            this.SuburbID = suburbID;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CountryID = countryID;
            this.Disability = disability;
            this.DisabilityDescription = disabilityDescription;
        }

        public clsStudent(int studentID, string firstName, string lastName, string gender, string dateOfBirth, string streetAddress, int suburbID, string postCode, string phoneNumber, string email, int countryID, string disability, string disabilityDescription)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.StreetAddress = streetAddress;
            this.SuburbID = suburbID;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CountryID = countryID;
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

        public int SuburbID
        {
            get
            {
                return suburbID;
            }

            set
            {
                suburbID = value;
            }
        }

        public string SuburbName
        {
            get
            {
                return suburbName;
            }

            set
            {
                suburbName = value;
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

        public int CountryID
        {
            get
            {
                return countryID;
            }

            set
            {
                countryID = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }

            set
            {
                countryName = value;
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

        #region Old code
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

        public bool DeleteStudent()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteStudent", objConnection);

            objCommand.Parameters.AddWithValue("@sid", studentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            objConnection.Close();
            return true;
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
            objCommand.Parameters.AddWithValue("@suburb", SuburbName);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@nat", CountryName);
            objCommand.Parameters.AddWithValue("@dis", Disability);
            objCommand.Parameters.AddWithValue("@disdetails", DisabilityDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            return true;
        }


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
                suburbName = objDataReader[6].ToString();
                postCode = objDataReader[7].ToString();
                phoneNumber = objDataReader[8].ToString();
                email = objDataReader[9].ToString();
                countryName = objDataReader[10].ToString();
                disability = objDataReader[11].ToString();
                disabilityDescription = objDataReader[12].ToString();
                objConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// This method connects to the database and runs the stored procedure InsertStudent. 
        /// The procedure holds the query for inserting the student values into the student table. 
        /// INSERT INTO student VALUES(@fname, @lname, @gender, @dob, @staddress, @suburb, @postcode, @phoneno, @email, @nat, @dis, @disdetails);
        /// </summary>
        /// <returns></returns>
        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertStudent", objConnection);
            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@subid", SuburbID);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@coid", CountryID);
            objCommand.Parameters.AddWithValue("@dis", Disability);
            objCommand.Parameters.AddWithValue("@disdetails", DisabilityDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            return true;
        }

        /// <summary>
        /// This method connects to the database and runs the stored procedure DeleteStudent.
        /// The procedure deletes a student from the table based on the ID that is passsed through.
        /// DELETE FROM student WHERE StudentID = @sid;
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteStudent", objConnection);

            objCommand.Parameters.AddWithValue("@sid", studentID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            objConnection.Close();
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
        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateStudent", objConnection);
            objCommand.Parameters.AddWithValue("@sid", StudentID);
            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@subid", SuburbID);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@coid", CountryID);
            objCommand.Parameters.AddWithValue("@dis", Disability);
            objCommand.Parameters.AddWithValue("@disdetails", DisabilityDescription);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            objConnection.Close();
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
        public bool Search()
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
                suburbID = Convert.ToInt32(objDataReader[6]);
                suburbName = objDataReader[7].ToString();
                postCode = objDataReader[8].ToString();
                phoneNumber = objDataReader[9].ToString();
                email = objDataReader[10].ToString();
                countryID = Convert.ToInt32(objDataReader[11]);
                countryName = objDataReader[12].ToString();
                disability = objDataReader[13].ToString();
                disabilityDescription = objDataReader[14].ToString();
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

            string strSQL = "select * from student";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Student ID";
                dgv.Columns[1].HeaderText = "First Name";
                dgv.Columns[2].HeaderText = "Last Name";
                dgv.Columns[3].HeaderText = "Gender";
                dgv.Columns[4].HeaderText = "D.O.B.";
                dgv.Columns[5].HeaderText = "Street Address";
                dgv.Columns[6].HeaderText = "Suburb";
                dgv.Columns[7].HeaderText = "Post Code";
                dgv.Columns[8].HeaderText = "Phone No.";
                dgv.Columns[9].HeaderText = "Email";
                dgv.Columns[10].HeaderText = "Nationality";
                dgv.Columns[11].HeaderText = "Disability";
                dgv.Columns[12].HeaderText = "Disability Description";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no students");
                objConnection.Close();
            }
        }

        public void Load(ComboBox[] cmb)
        {
            string strSql = "select * from suburb";
            clsDatabase.CreateConnection();
            DataTable objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[0].DataSource = objDataTable;
            cmb[0].DisplayMember = "suburbid";
            cmb[0].ValueMember = "suburbid";
            cmb[0].SelectedIndex = -1;
            cmb[0].Text = "";

            objDataTable = null;
            //strSql = "select * from suburb";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[1].DataSource = objDataTable;
            cmb[1].DisplayMember = "suburbname";
            cmb[1].ValueMember = "suburbid";
            cmb[1].SelectedIndex = -1;
            cmb[1].Text = "Select a suburb";

            objDataTable = null;
            //strSql = "select * from suburb";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[2].DataSource = objDataTable;
            cmb[2].DisplayMember = "suburbpostcode";
            cmb[2].ValueMember = "suburbid";
            cmb[2].SelectedIndex = -1;
            cmb[2].Text = "Post Code";

            objDataTable = null;
            strSql = "select * from country";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[3].DataSource = objDataTable;
            cmb[3].DisplayMember = "countryid";
            cmb[3].ValueMember = "countryid";
            cmb[3].SelectedIndex = -1;
            cmb[3].Text = "";

            objDataTable = null;
            //strSql = "select * from country";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[4].DataSource = objDataTable;
            cmb[4].DisplayMember = "countryname";
            cmb[4].ValueMember = "countryid";
            cmb[4].SelectedIndex = -1;
            cmb[4].Text = "Select a country";
        }
    }
}
