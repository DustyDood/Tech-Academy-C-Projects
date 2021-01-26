using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    public class Employee : Person, IQuittable
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

        public void Quit()
        {
            Console.WriteLine("You can't tell me what to do! I quit!");
            Console.ReadLine();
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //Wait it's actually calling!
            Console.WriteLine("Checking if two employee IDs are equal...");
            return (employee1.ID == employee2.ID);
        }

        //So we call this overload if someone's checking if the two employes (and therefore IDs) aren't equal.
        //The issue is... why is this required? If the first one returns false, shouldn't that be sufficient?
        //Why does C# require both a == and a != operator overload?
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            Console.WriteLine("Checking if the two IDs don't match");
            return (employee1.ID != employee2.ID);
        }

    }
}
