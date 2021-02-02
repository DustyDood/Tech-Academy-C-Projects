using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const__Var__and_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greetingMessage = "Hello, and welcome!";
            Console.WriteLine(greetingMessage);
            Console.ReadLine();

            var testmessage = "How are you doing today?";
            Console.WriteLine(testmessage);
            Console.WriteLine("C# recognizes that this test message is a {0}", testmessage.GetType());
            Console.ReadLine();

            //This call uses a constructor call chain to call the constructor with
            //entering only a string!
            ConstructorTesting Bobby = new ConstructorTesting("Bobby");
            Bobby.Boast();
        }
    }
}
