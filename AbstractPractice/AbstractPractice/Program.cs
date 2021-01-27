using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //We've added the generic T to the class for Employee.
            //Now when we instantiate an instance of Employee, we must include 
            //a data type in the <...> so the list knows of what type to be!
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>();

            employee.things.Add("Hello");
            employee.things.Add("Testing");

            employee.listThings();

            //employee.firstName = "Sample";
            //employee.lastName = "Student";
            //employee.ID = "123";
            //employee.sayName();

            Employee<int> newEmployee = new Employee<int>();
            newEmployee.things = new List<int>();

            newEmployee.things.Add(10);
            newEmployee.things.Add(130);

            newEmployee.listThings();

            //newEmployee.firstName = "Another";
            //newEmployee.lastName = "Student";
            //newEmployee.ID = "456";

            //bool IDCheck = employee == newEmployee;
            
            //Console.WriteLine(employee == newEmployee);
            //Console.ReadLine();

            //Console.WriteLine(employee != newEmployee);
            //Console.ReadLine();

            //Console.ReadLine();

            //employee.Quit();


            ////Using polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //IQuittable quittable = new Employee();           
            //quittable.Quit();

        }
    }
}
