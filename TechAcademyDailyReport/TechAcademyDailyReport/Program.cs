using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Math for the next assignment!
            //int addition = 8 + 10;
            //Console.WriteLine(addition);

            //int subtraction = 19 - 2;
            //Console.WriteLine(subtraction);

            //int multiplication = 2 * 50;
            //Console.WriteLine(multiplication);

            //int division = 192 / 3;
            //Console.WriteLine(division);

            string firstString = "My favorite number is ";
            int mathNumberThing = 17;
            Console.WriteLine(firstString + mathNumberThing);




            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");


            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            //Converting to an int in case it's needed later
            int intPageNumber = Convert.ToInt32(pageNumber);


            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            //This is dangerous since it has to be exactly true or false...
            //They mentioned online using Boolean.Parse(needHelp) and accounting for the different combinations of saying true or false,
            //But I think that's a little overkill for the assignment...
            bool boolNeedHelp = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            //I found this online but can't figure out how it works... 
            //I couldn't find a way to convert directly from strings to floats, but using
            //the (float) ToDouble conversion did it...
            //float floatHoursStudied = (float) Convert.ToDouble(hoursStudied);
            double doubleHoursStudied = Convert.ToDouble(hoursStudied);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }

    }
}
