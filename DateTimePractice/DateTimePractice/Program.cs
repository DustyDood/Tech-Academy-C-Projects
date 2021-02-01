using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("It is currently {0}", currentTime);
            
            Console.WriteLine("\nGive me a number!");
            double hoursToAdd = Convert.ToDouble(Console.ReadLine());

            //AddHours() requires a double!
            DateTime futureTime = currentTime.AddHours(hoursToAdd);
            Console.WriteLine("In {0} hours, the time shall be {1}", hoursToAdd, futureTime);
            Console.ReadLine();
        }
    }
}
