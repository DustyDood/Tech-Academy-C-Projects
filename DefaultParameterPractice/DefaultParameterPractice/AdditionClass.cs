using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterPractice
{
    class AdditionClass
    {
        public int timeToAdd(int firstInt, int secondInt = 2)
        {

            return firstInt * secondInt;
        }
    }
}
