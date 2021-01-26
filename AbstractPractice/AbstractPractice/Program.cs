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
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = "123";
            employee.sayName();

            Employee newEmployee = new Employee();
            newEmployee.firstName = "Another";
            newEmployee.lastName = "Student";
            newEmployee.ID = "456";

            //bool IDCheck = employee == newEmployee;
            
            Console.WriteLine(employee == newEmployee);
            Console.ReadLine();

            Console.WriteLine(employee != newEmployee);
            Console.ReadLine();

            //Console.ReadLine();

            //employee.Quit();


            ////Using polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //IQuittable quittable = new Employee();           
            //quittable.Quit();

        }
    }
}
