using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameterPractice
{
    class VoidMathClass
    {
        public void mathMagic(int firstNumber, int secondNumber)
        {
            //I feel like I may be misreading the instructions, but it says do a math operation on the first and display the second...
            //Here's the math operation. Is this one not supposed to be displayed at all..?
            Console.WriteLine("Watch as we add 104 to your first number!");
            Console.WriteLine("{0} + 104 = {1}", firstNumber, firstNumber + 104);

            //And here's the 2nd number, which will just match what the user put in...
            Console.WriteLine("Also, here is your second number: {0}", secondNumber);
            Console.ReadLine();
        }
    }
}
