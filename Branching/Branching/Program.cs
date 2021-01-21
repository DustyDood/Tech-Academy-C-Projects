using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Console.WriteLine("Please enter your package's weight.");
            //double packageWeight = Convert.ToDouble(Console.ReadLine());

            //if (packageWeight > 50)
            //{
            //    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("What is your package's width?");
            //    double packageWidth = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("What is your package's height?");
            //    double packageHeight = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("What is your package's Length?");
            //    double packageLength = Convert.ToDouble(Console.ReadLine());

            //    double packageDimensions = packageWidth + packageHeight + packageLength;
            //    if (packageDimensions > 50)
            //    {
            //        Console.WriteLine("Package too big to be shipped via Package Express");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        double packageVolume = packageWidth * packageHeight * packageLength;
            //        decimal quoteAmount = Convert.ToDecimal(packageVolume) * Convert.ToDecimal(packageWeight) / 100.00m;
            //        Console.WriteLine("Your estimated total for shipping this package is: $" + quoteAmount);
            //        Console.WriteLine("Thank you!");
            //        Console.ReadLine();

            //    }
            //}

            Console.WriteLine("What day number is it? Monday is 1, Sunday is 7");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            switch (dayNumber)
            {
                case 4:
                    Console.WriteLine("It's Thursday! Our tradition is Thai Thursday.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Woohoo! It's the weekend.");
                    break;
                case 5:
                    Console.WriteLine("Friday! It's the final stretch");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Meh... The week has just begun.");
                    break;
                default:
                    Console.WriteLine("Wait, you shouldn't be reading this...");
                    break;
            }
            Console.ReadLine();

                












            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";
            //Console.WriteLine(result);
            //Console.ReadLine();


            //int currentTemperature = 71;
            //int roomTemperature = 70;
            //Console.WriteLine("hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("This should show up...");
            //}
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //} 
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It's not exactly room temperature");
            //}

            //string comparisonResult = currentTemperature == roomTemperature ? "It is exactly room temperature" : "It is not exactly room temperature";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();
        }
    }
}
