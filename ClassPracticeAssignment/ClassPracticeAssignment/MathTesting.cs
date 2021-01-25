using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeAssignment
{
    class MathTesting
    {
        public static int AdditionTesting(int addNumber)
        {
            int numberToReturn = addNumber;
            numberToReturn += 20;
            return numberToReturn;
        }

        public static int SubtractionTesting(int subtractNumber)
        {
            int numberToReturn = subtractNumber;
            numberToReturn -= 17;
            return numberToReturn;
        }

        public static int MultiplicationTesting(int multiplierNumber)
        {
            int numberToReturn = multiplierNumber;
            numberToReturn *= 4;
            return numberToReturn;
        }
    }
}
