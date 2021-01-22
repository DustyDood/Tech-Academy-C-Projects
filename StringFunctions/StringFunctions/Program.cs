using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "This is the first string! ";
            string two = "This is the second string! ";
            string three = "Finally, this is the third string!";

            Console.WriteLine(one + two + three);
            Console.ReadLine();

            string upperCaseMeCaptain = "How come ToUpper looks like yelling but ToLower doesn't look like whispering?";
            Console.WriteLine(upperCaseMeCaptain.ToUpper());
            Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("By appending to a StringBuilder ");
            stringBuilder.Append("you can join multiple lines ");
            stringBuilder.Append("of text into one object!");

            Console.WriteLine(stringBuilder);
            Console.ReadLine();

            //Strings are immutable! They can't be changed once issued.
            //string name = "Jesse";
            //name = "Joe";

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Jesse");


            //Console.WriteLine(sb);
            //Console.ReadLine();

            //string name = "Jesse";
            //string quote = "The man said, \"Hello.\" \nHello on a new line. \t Hello on a tab.";
            //string filename = @"C:\Users\Jesse";

            //Console.WriteLine(quote);
            //Console.ReadLine();

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();
        }
    }
}
