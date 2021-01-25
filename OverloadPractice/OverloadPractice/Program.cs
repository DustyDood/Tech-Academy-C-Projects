using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we start with an int
            VariousOverloads variousOverloads = new VariousOverloads();
            Console.WriteLine("Want to see some overloads in action? First give me a number!");
            int firstOverloadReturned = Convert.ToInt32(Console.ReadLine());
            //Since we don't have static on the class VariousOverloads's methods anymore, we can use this notation!
            //I was running into an error trying to use instance references for static properties, so removing static made this work.
            int firstAnswer = variousOverloads.overloadMethod(firstOverloadReturned);
            Console.WriteLine("Your number plus 26 returns: {0}", firstAnswer);
            Console.ReadLine();

            //Now for a decimal
            Console.WriteLine("Now we change a decimal around! Enter a number below.");
            decimal secondOverloadReturned = Convert.ToDecimal(Console.ReadLine());
            decimal secondAnswer = variousOverloads.overloadMethod(secondOverloadReturned);
            Console.WriteLine("Your decimal minus 42.24 returns {0}", secondAnswer);
            Console.ReadLine();

            //Lastly, a string! Which is kind of what we are already doing since Console.ReadLine() is a string normally...
            Console.WriteLine("Last but not least, give me one number to multiply!");
            string thirdOverloadReturned = Console.ReadLine();
            int thirdAnswer = variousOverloads.overloadMethod(thirdOverloadReturned);
            Console.WriteLine("Your number multiplied by 2 returns {0}", thirdAnswer);
            Console.WriteLine("And there we go! Isn't overloading fun?");
            Console.ReadLine();

        }
    }
}
