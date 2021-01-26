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
            employee.sayName();


            Console.ReadLine();

            employee.Quit();


            //Using polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable quittable = new Employee();           
            quittable.Quit();

        }
    }
}
