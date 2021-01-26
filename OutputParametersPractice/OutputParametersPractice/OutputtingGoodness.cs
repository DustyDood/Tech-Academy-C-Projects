using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParametersPractice
{
    class OutputtingGoodness
    {
        //Creating a void method that outputs an int.
        public void MathTime(int firstNumber, out int secondNumber)
        {
            secondNumber = firstNumber / 2;

        }

        //Creating a method with output parameters for step 4.
        public void MultiplicationTime(int firstNumber, out int returnNumber, out string mathType)
        {
            returnNumber = firstNumber * 3;
            mathType = "Multiplication";
        }

        //Creating an overload for a method for step 5.
        public void MultiplicationTime(int firstNumber, int secondNumber, out int returnNumber, out string mathType)
        {
            returnNumber = firstNumber * secondNumber;
            mathType = "Multiplication of each other!";
        }

    }
}
