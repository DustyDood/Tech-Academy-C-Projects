using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> things { get; set; }

        //this works! I think without using keyword this, I would have the parameter be 
        //of the type List. Then, it would be foreach (T thing in things, where things
        //would be the list passed as an argument.
        public void listThings()
        {
            foreach (T thing in this.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }

        public override void sayName()
        {

            Console.WriteLine("My name is {0} {1}, yeah?", this.firstName, this.lastName);

        }

        public void Quit()
        {
            Console.WriteLine("You can't tell me what to do! I quit!");
            Console.ReadLine();
        }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            //Wait it's actually calling!
            Console.WriteLine("Checking if two employee IDs are equal...");
            return (employee1.ID == employee2.ID);
        }

        //So we call this overload if someone's checking if the two employes (and therefore IDs) aren't equal.
        //The issue is... why is this required? If the first one returns false, shouldn't that be sufficient?
        //Why does C# require both a == and a != operator overload?
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            Console.WriteLine("Checking if the two IDs don't match");
            return (employee1.ID != employee2.ID);
        }

    }
}
