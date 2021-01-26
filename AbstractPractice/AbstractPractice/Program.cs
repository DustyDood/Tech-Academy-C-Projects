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
        }
    }
}
