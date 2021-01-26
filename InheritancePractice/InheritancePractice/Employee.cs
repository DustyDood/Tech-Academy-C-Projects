using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Employee : Person
    {
        public int ID { get; set; }
        //How strange... We give Employee the ID property but we don't actually call it this assignment
    }
}
