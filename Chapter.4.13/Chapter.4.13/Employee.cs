using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter._4._13
{

    /*
     * 4.13 (Employee Class) Create a class called Employee that includes three pieces of information as
    either instance variables or automatic properties—a first name (type string), a last name (type
    string) and a monthly salary (decimal). Your class should have a constructor that initializes the
    three values. Provide a property with a get and set accessor for any instance variables. If the monthly
    salary is negative, the set accessor should leave the instance variable unchanged. Write a test app
    named EmployeeTest that demonstrates class Employee’s capabilities. Create two Employee objects
    and display each object’s yearly salary. Then give each Employee a 10% raise and display each Employee’s
    yearly salary again.*/
    class Employee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        public Employee()
        {
            FirstName = fname;
            LastName = lname;
            Salary = sal;
        }
    }
}
