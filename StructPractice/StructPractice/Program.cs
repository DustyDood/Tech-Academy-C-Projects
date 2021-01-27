using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of the Number struct.
            Number testing = new Number();
            //Assigning an amount to our new instance
            testing.Amount = 2.43m;
            //Writing the amount to the console.
            Console.WriteLine(testing.Amount);
            Console.ReadLine();

        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }

    }
}
