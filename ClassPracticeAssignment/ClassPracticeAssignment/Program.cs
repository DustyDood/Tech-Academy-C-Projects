using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do some math on?");
            int numberTesting = Convert.ToInt32(Console.ReadLine());

            int addResult = MathTesting.AdditionTesting(numberTesting);
            Console.WriteLine("If we add 20 to your number, we get " + addResult);

            int subtractResult = MathTesting.SubtractionTesting(numberTesting);
            Console.WriteLine("If we subtract 17 from your number, we get " + subtractResult);

            int multiplicationResult = MathTesting.MultiplicationTesting(numberTesting);
            Console.WriteLine("Finally, if we multiply your number by 4, we get " + multiplicationResult);

            Console.ReadLine();

        }


    }
}
