using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParametersPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputtingGoodness outputtingGoodness = new OutputtingGoodness();

            Console.WriteLine("What number do you want to divide by 2?");
            int numToHalf = Convert.ToInt32(Console.ReadLine());
            outputtingGoodness.MathTime(numToHalf, out int resultingGoodness);
            Console.WriteLine("The result is {0}", resultingGoodness);
            Console.ReadLine();

            Console.WriteLine("You can call this overload to have two numbers.");
            Console.WriteLine("What is the first number?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the 2nd number? This parameter is optional!");

            try
            {
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                outputtingGoodness.MultiplicationTime(firstNumber, secondNumber, out int returnNumber, out string mathType);
                Console.WriteLine(returnNumber);
            }
            catch
            {
                Console.WriteLine("We can't read that second number... We'll just multiply by 3");
                outputtingGoodness.MultiplicationTime(firstNumber, out int returnNumber, out string mathType);
                Console.WriteLine(returnNumber);
            }
            Console.ReadLine();

            Console.WriteLine("Last but not least, we can call a static class's method without instantiation!");
            StaticClassGoodness.LookAtMe();
            Console.ReadLine();

        }
    }
}
