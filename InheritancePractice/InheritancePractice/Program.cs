using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Dusty = new Person
            {
                FirstName = "Dusty",
                LastName = "Zoland"
            };

            Dusty.SayName();

            Person Sample = new Person
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            Sample.SayName();
        }
    }
}
