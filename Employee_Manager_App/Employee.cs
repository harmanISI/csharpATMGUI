using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager_App
{
    public enum EmployeeType { FullTime, PartTime }
  public  class Employee
    {
        static int UniqueId = 0;
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public EmployeeType Type { get; private set; }
        public int EmployeeID { get; private set; }

        public Employee(string lastName, string firstName, EmployeeType _Type)
        {
            LastName = lastName;
            FirstName = firstName;
            Type = _Type;
            EmployeeID = UniqueId;
            UniqueId++;


        }
    }

}