using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we initialize the class!
            AdditionClass additionClass = new AdditionClass();

            //Our first number is required!
            Console.WriteLine("Want to do some basic multiplication? Give me a number!");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            //The second number is optional!
            Console.WriteLine("Now give me a second number? If you don't give me a number, this will default to 2");
            int secondNumber;
            
            //We try to convert whatever was entered for the second number, running the multiplication code.
            try
            {
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Multiplying the two numbers together gives: {0}", additionClass.timeToAdd(firstNumber, secondNumber));
            }
            //If they didn't enter anything/they entered something that can't be converted, we don't pass in a 2nd parameter.
            //Due to the overload, this means the second number for multiplication will default to 2.
            catch
            {
                Console.WriteLine("We shall go with the default of 2");
                Console.WriteLine("Multiplying the two numbers together gives: {0}", additionClass.timeToAdd(firstNumber));
            }

            
            Console.ReadLine();

        }
    }
}
