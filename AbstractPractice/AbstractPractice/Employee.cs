using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    public class Employee : Person
    {
        //I feel like I'm doing this part incorrectly... since the class is abstract,
        // C# won't recognize these properties unless they're repeated here. This seems
        // redundant and inefficient coding wise, so I think I'm missing something.

        //public string firstName { get; set; }
        //public string lastName { get; set; }

        //Ah, there we go... If we make the properties public and virtual, it gives
        // our inheriting class the option to override the properties, if desired. If not,
        // it'll function just as it does in our abstract Person class. Thus, we don't need 
        // to call firstName and lastName here, as it is covered by the Person class.

        public override void sayName()
        {

            Console.WriteLine("My name is {0} {1}, yeah?", this.firstName, this.lastName);

        }
    }
}
