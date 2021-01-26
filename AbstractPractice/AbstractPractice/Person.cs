using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    public abstract class Person
    {
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }

        public abstract void sayName();

    }
}
