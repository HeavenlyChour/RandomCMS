using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    public class clsExceptionHandling
    {
        public class StudentNotFoundException : Exception//inheriting Exception class
        {

            public StudentNotFoundException()
            {

            }

            public StudentNotFoundException(string message) : base(message)//using base method of the parent Exception class
            {

            }
        }

        public class CourseNotFoundException : Exception//inheriting Exception class
        {

            public CourseNotFoundException()
            {

            }

            public CourseNotFoundException(string message) : base(message)//using base method of the parent Exception class
            {

            }
        }

        public class ProcedureNotFoundException : Exception//inheriting Exception class
        {

            public ProcedureNotFoundException()
            {

            }

            public ProcedureNotFoundException(string message) : base(message)//using base method of the parent Exception class
            {

            }
        }

        public class ConnectToDatabaseException : Exception//inheriting Exception class
        {

            public ConnectToDatabaseException()
            {

            }

            public ConnectToDatabaseException(string message) : base(message)//using base method of the parent Exception class
            {

            }
        }
    }
}
