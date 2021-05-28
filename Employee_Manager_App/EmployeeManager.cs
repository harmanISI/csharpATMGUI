using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager_App
{
    
    

        static class EmployeeManager
        {
            public static List<Employee> entries = new List<Employee>()
        {
            new Employee("harman", "Singh", EmployeeType.PartTime ),
            new Employee("harish ", "Sharma", EmployeeType.PartTime ),
            new Employee("Joe", "singh", EmployeeType.FullTime ),
            new Employee("Braden", "Singh", EmployeeType.PartTime ),
            new Employee("Roonet ", "Kumar", EmployeeType.FullTime ),
            new Employee("Gamil ", "Abdel", EmployeeType.PartTime ),
            new Employee("Bruno", "Bucher", EmployeeType.FullTime ),
            new Employee("Vera ", "FAres", EmployeeType.PartTime ),

        };
        }



    }

