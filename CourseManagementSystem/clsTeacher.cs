using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;
using System.Data.SqlClient;
using System.Data;
using DatabaseClass;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class clsTeacher: ILogic
    {
        private int teacherID;
        private string firstName;
        private string lastName;
        private string gender;
        private string dateOfBirth;
        private string streetAddress;
        private int suburbID;
        private string suburbName;
        private string postCode;
        private string phoneNumber;
        private string email;
        private string commencementDate;
        private string department;
        //private string skills;
        private string leave;

        

        public clsTeacher()
        {
        }

        public clsTeacher(int teacherID)
        {
            this.TeacherID = teacherID;
        }

        public clsTeacher(string firstName, string lastName, string gender, string dateOfBirth, string streetAddress, int suburbID, string postCode, string phoneNumber, string email, string commencementDate, string department, string leave)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.StreetAddress = streetAddress;
            this.SuburbID = suburbID;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CommencementDate = commencementDate;
            this.Department = department;
            //this.Skills = skills;
            this.Leave = leave;
        }

        public clsTeacher(int teacherID, string firstName, string lastName, string gender, string dateOfBirth, string streetAddress, int suburbID, string postCode, string phoneNumber, string email, string commencementDate, string department, string leave)
        {
            this.TeacherID = teacherID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.StreetAddress = streetAddress;
            this.SuburbID = suburbID;
            this.PostCode = postCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CommencementDate = commencementDate;
            this.Department = department;
            //this.Skills = skills;
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

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        //public string Skills
        //{
        //    get
        //    {
        //        return skills;
        //    }

        //    set
        //    {
        //        skills = value;
        //    }
        //}

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

        public bool Add()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("InsertTeacher", objConnection);

            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@suburbid", SuburbID);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@commdate", CommencementDate);
            objCommand.Parameters.AddWithValue("@dept", Department);
            //objCommand.Parameters.AddWithValue("@skills", Skills);
            objCommand.Parameters.AddWithValue("@leave", Leave);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Delete()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("DeleteTeacher", objConnection);

            objCommand.Parameters.AddWithValue("@tid", teacherID);
            objCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader objDataReader = objCommand.ExecuteReader();
            return true;
        }

        public bool Update()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("UpdateTeacher", objConnection);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
            objCommand.Parameters.AddWithValue("@fname", FirstName);
            objCommand.Parameters.AddWithValue("@lname", LastName);
            objCommand.Parameters.AddWithValue("@gender", Gender);
            objCommand.Parameters.AddWithValue("@dob", DateOfBirth);
            objCommand.Parameters.AddWithValue("@staddress", StreetAddress);
            objCommand.Parameters.AddWithValue("@suburbid", SuburbID);
            objCommand.Parameters.AddWithValue("@postcode", PostCode);
            objCommand.Parameters.AddWithValue("@phoneno", PhoneNumber);
            objCommand.Parameters.AddWithValue("@email", Email);
            objCommand.Parameters.AddWithValue("@commdate", CommencementDate);
            objCommand.Parameters.AddWithValue("@dept", Department);
            //objCommand.Parameters.AddWithValue("@skills", Skills);
            objCommand.Parameters.AddWithValue("@leave", Leave);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            return true;
        }

        public bool Search()
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("SearchTeacher", objConnection);
            objCommand.Parameters.AddWithValue("@tid", TeacherID);
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
                commencementDate = objDataReader[11].ToString();
                department = objDataReader[12].ToString();
                //skills = objDataReader[13].ToString();
                leave = objDataReader[13].ToString();
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

            string strSQL = "select * from teacher";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(strSQL, objConnection);

            DataTable objDataTable = new DataTable();
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count != 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = objDataTable;
                dgv.AutoGenerateColumns = false;
                dgv.Columns[0].HeaderText = "Teacher ID";
                dgv.Columns[1].HeaderText = "First Name";
                dgv.Columns[2].HeaderText = "Last Name";
                dgv.Columns[3].HeaderText = "Gender";
                dgv.Columns[4].HeaderText = "D.O.B.";
                dgv.Columns[5].HeaderText = "Street Address";
                dgv.Columns[6].HeaderText = "Suburb ID";
                dgv.Columns[7].HeaderText = "Post Code";
                dgv.Columns[8].HeaderText = "Phone No.";
                dgv.Columns[9].HeaderText = "Email";
                dgv.Columns[10].HeaderText = "Commencement Date";
                dgv.Columns[11].HeaderText = "Department";
                //dgv.Columns[12].HeaderText = "Skills";
                dgv.Columns[12].HeaderText = "Sick Leave";
                dgv.AutoResizeColumns();
                dgv.AutoSize = false;
                dgv.Visible = true;
                objConnection.Close();
            }
            else
            {
                MessageBox.Show("There are no teachers");
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
            strSql = "select * from skill";
            objDataTable = clsDatabase.CreateDataTable(strSql);
            cmb[3].DataSource = objDataTable;
            cmb[3].DisplayMember = "skillName";
            cmb[3].ValueMember = "skillId";
            cmb[3].SelectedIndex = -1;
            cmb[3].Text = "";
        }
    }
}
