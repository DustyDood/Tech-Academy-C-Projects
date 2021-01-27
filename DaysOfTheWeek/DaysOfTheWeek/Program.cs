using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week.");
            string dayEntered = Console.ReadLine();

            bool dayFound = false;

            try
            {
                //This attempts to take the user entry and convert the string entered to the matching enum.
                //If it fails to find a relevant enum, then the catch block is called!
                DaysOfTheWeek parsedEntry = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayEntered.ToLower());
                Console.WriteLine("Day found!");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            //This was for converting the enum to string. The instrctions say string to enum,
            //so we'll just comment this out for now.
            //foreach (string day in Enum.GetNames(typeof(DaysOfTheWeek)))
            //{
            //    Console.WriteLine(day);
            //    if (dayEntered.ToLower() == day.ToLower())
            //    {
            //        dayFound = true;
            //    }
            //}

            if (dayFound)
            {

            }
            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
