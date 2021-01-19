using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Look as I can include \" instaed of ending the string!");
            Console.Read();
        }
    }
}
