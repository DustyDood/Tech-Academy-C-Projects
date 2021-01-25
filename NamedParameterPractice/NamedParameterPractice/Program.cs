using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMathClass voidMathClass = new VoidMathClass();

            //I guess we're showing that we can call the parameters in a different order as long as they're named?
            //Here's the first one, which is the default.
            voidMathClass.mathMagic(100, 20);

            //Now here's the second call, but I can switch the first and second by using named parameters?
            voidMathClass.mathMagic(secondNumber: 100, firstNumber: 20);

            //Success! Even though the number 100 comes first in both calls, since we give it the name secondNumber, it performs the secondNumber calls.
        }
    }
}
