using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const__Var__and_Constructors
{
    public class ConstructorTesting
    {
        public ConstructorTesting(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public ConstructorTesting(string name) : this(name, 10)
        {

        }

        public string Name { get; set; }
        public int Count { get; set; }
        
        public void Boast()
        {
            Console.WriteLine("My name is {0}. I can count to {1}!", Name, Count);
            Console.ReadLine();
        }
    }
}
