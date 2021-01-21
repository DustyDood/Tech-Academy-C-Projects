using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.ReadLine();

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);
            //Console.ReadLine();

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);
            //Console.ReadLine();

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);
            //Console.ReadLine();

            Console.WriteLine("Car Insurance Approval");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Only enter true or false");
            bool DUICheck = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool eligibilityCheck = (age > 15) && (!DUICheck) && (tickets < 4);
            Console.WriteLine(eligibilityCheck);
            Console.ReadLine();


            if (age <= 15)
            {
                Console.WriteLine("I'm sorry, but you're too young to drive!");
            }
            else if (DUICheck || tickets >= 4)
            {
                Console.WriteLine("I'm sorry, but your previous driving record prevents approval");
            }
            else
            {
                Console.WriteLine("Congrats on getting approval!");
            }

            Console.ReadLine();

            var DUITernary = DUICheck != false ? ("You have a DUI") : ("You don't have a DUI");
            Console.WriteLine(DUITernary);

            Console.ReadLine();

        }
    }
}
