using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is this person's hourly rate?");
            double person1Rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours do they work per week?");
            double person1Hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is this person's hourly rate?");
            double person2Rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours do they work per week?");
            double person2Hours = Convert.ToDouble(Console.ReadLine());

            //We multiply salaries by 52 to account for all the weeks in the year!
            Console.WriteLine("Annual Salary of Person 1:");
            double person1Salary = person1Rate * person1Hours * 52;
            Console.WriteLine(person1Salary);

            Console.WriteLine("Annual Salary of Person 2:");
            double person2Salary = person2Rate * person2Hours * 52;
            Console.WriteLine(person2Salary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryComparsion = person1Salary > person2Salary;
            Console.WriteLine(salaryComparsion);
            Console.ReadLine();

        }
    }
}
