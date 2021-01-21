using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool passwordGuessed = false;
            string password = "9999";
            do
            {
                Console.WriteLine("Guess my password! It's only four numbers");
                string passwordGuess = Console.ReadLine();
                if (passwordGuess == password)
                {
                    Console.WriteLine("You've guessed the right password. Amazing!");
                    passwordGuessed = true;
                }
                else
                {
                    Console.WriteLine("That's not the right password... Try 9999");

                }
                Console.WriteLine("Congrats, you did it!");
                Console.ReadLine();



            }
            while (!passwordGuessed);


            //bool isGuessed = false;
            //while (!isGuessed)
            //{
            //    Console.WriteLine("Guess a number!");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62! But that's wrong.");
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            break;
            //        case 55:
            //            Console.WriteLine("I like 55! But that's also wrong.");
            //            break;
            //        case 12:
            //            Console.WriteLine("12 is the correct number! Nice!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("Sorry, that's not the # we're looking for.");
            //            break;

            //    }
            //}
            //Console.WriteLine("If you're reading this, the loop is broken. Well done!");
            //Console.ReadLine();
        }
    }
}
