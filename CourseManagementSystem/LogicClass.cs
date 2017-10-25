using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClass;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace CourseManagementSystem
{
    class LogicClass
    {
        public string tableName = "";
        public string[] procedureVariable;
        Type myType;
        public IList<PropertyInfo> prop = new List<PropertyInfo>();



        public void Add(int propAmount)
        {
            SqlConnection objConnection = clsDatabase.CreateConnection();
            SqlCommand objCommand = new SqlCommand("Insert"+tableName, objConnection); //This will be the name of the procedure

            for (int i = 0; i < propAmount; i++)
            {
                //prop[i] = Type.GetType("System.Type").GetProperties();
                objCommand.Parameters.AddWithValue(procedureVariable[i], prop[i]/*And whatever the class property is here*/);
                
            }
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
        }
    }
}
