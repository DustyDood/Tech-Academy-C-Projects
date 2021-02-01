using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number! Any number!");

            //Typically we would convert strings to ints when using them for functions.
            //In this case, we're just writing to a text file, so no conversion is needed!
            string userInput = Console.ReadLine();

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Dusty Zoland\Desktop\Testing.txt", true))
            {
                streamWriter.WriteLine(userInput);
            }
            string fileOutput = File.ReadAllText(@"C:\Users\Dusty Zoland\Desktop\Testing.txt");
            Console.WriteLine(fileOutput);
            Console.ReadLine();
        }
    }
}
