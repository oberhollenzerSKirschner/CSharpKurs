using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    public class DepartmentChangedEventArgs: EventArgs
    {
        public Department OldDepartment { get; }

        public Department NewDepartment { get; }
        public DepartmentChangedEventArgs()
        {
              
        }
        public DepartmentChangedEventArgs(Department oldDepartment, Department newDepartment)
        {
            OldDepartment = oldDepartment;
            NewDepartment = newDepartment;
        }

    }
}
