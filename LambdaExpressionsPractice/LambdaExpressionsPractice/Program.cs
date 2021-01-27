using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //The first step doesn't specify how to make the 10 employees, but the fourth
            // step says with a lambda expression. I think the first one is manual, then?

            List<Employees> employees = new List<Employees>
            {
                //Here we go! The formatting changes a little bit when adding new employees to a list of Employees.
                //I was trying to use Employees employees1 = new Employees() etc., but that wasn't working.
                //Turns out I didn't need to declare a var name. I just need to put new Employees() and go from there!
                new Employees() {firstName = "Joe", lastName = "Bob", ID="1" },
                new Employees() {firstName = "Joseph", lastName = "Dood", ID="2" },
                new Employees() {firstName = "Broseph", lastName = "Guy", ID="3" },
                new Employees() {firstName = "Mojo", lastName = "Jojo", ID="4" },
                new Employees() {firstName = "Jojo", lastName = "Jostar", ID="5" },
                new Employees() {firstName = "Jonah", lastName = "Man", ID="6" },
                new Employees() {firstName = "Jonathan", lastName = "Guy", ID="7" },
                new Employees() {firstName = "Joe", lastName = "Joe", ID="8" },
                new Employees() {firstName = "Joe", lastName = "I'mRunningOutOfNames", ID="9" },
                new Employees() {firstName = "Dave", lastName = "Something", ID="10" }

            };

            //Ok! We've made a list of employees. Now we grab the Joe employees!
            List<Employees> joeEmployees = new List<Employees>();
            foreach (Employees employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }

            //Using breakpoints I confirmed that joeEmployees is correctly grabbing the 3 Joes!
            Console.WriteLine(joeEmployees);
            Console.ReadLine();

            //Ok, let's try it with a lambda expression this time!
            List<Employees> lambdaJoeEmployees = employees.Where(x => x.firstName == "Joe").ToList();

            Console.WriteLine(lambdaJoeEmployees);
            Console.ReadLine();

            //AH YES, SUCCESS! It's starting to click a little. But man, my head hurts.
           
            //Finally, we make a list of all employees with an ID greater than 5.
            List<Employees> highIDEmployees = employees.Where(x => Convert.ToInt32(x.ID) > 5).ToList();

            Console.WriteLine(highIDEmployees);
            Console.ReadLine();

            //Another success!!

        }
    }
}
