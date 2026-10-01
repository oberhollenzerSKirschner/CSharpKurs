using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    public class EmployeeToYoungEception : Exception
    {
        public EmployeeToYoungEception(string message) : base(message)
        {
            //this.Message += " Der Mitarbeiter ist zu jung.";
        }
        public EmployeeToYoungEception(string message, Exception innerException) : base(message, innerException)
        {
        }   

    }
}
