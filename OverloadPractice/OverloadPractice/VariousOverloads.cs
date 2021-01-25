using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadPractice
{
    class VariousOverloads
    {
        public int overloadMethod (int myInt)
        {
            int numberToReturn = myInt;
            numberToReturn += 26;
            return numberToReturn;
        }

        public decimal overloadMethod (decimal myDecimal)
        {
            decimal numberToReturn = myDecimal;
            numberToReturn -= 42.24m;
            return numberToReturn;
        }

        public int overloadMethod (string myString)
        {
            int prestoChangeO;
            string stringGiven = myString;
            try
            {
                prestoChangeO = Convert.ToInt32(stringGiven);
            }
            catch
            {
                Console.WriteLine("Whatever string you passed can't become an int, so I'm giving you the int 34!");
                prestoChangeO = 34;
            }

            prestoChangeO *= 2;
            return prestoChangeO;
        }
    }
}
