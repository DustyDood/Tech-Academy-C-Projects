using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Step 1
            //string[] names = { "Dave", "Alvin", "Joe", "Bubba", "Tony" };

            //Console.WriteLine("What text do you want to add to each array item?");
            //string namesAppend = Console.ReadLine();

            //for (int i = 0; i < names.Length; i++) 
            //{
            //    names[i] = names[i] + namesAppend;
            //    Console.WriteLine(names[i]);
            //}

            //Console.ReadLine();


            ////Step 2
            //bool songEnd = false;
            //int songVerses = 0;

            //while (!songEnd)
            //{
            //    Console.WriteLine("This is the song that never ends!");
            //    //Now to add an end by making it so the while loop only goes 5 times.
            //    songVerses++;
            //    if (songVerses>4)
            //    {
            //        songEnd = true;
            //    }
            //}
            //Console.ReadLine();


            ////Step 3

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("I can count up to " + i);
            //}

            //for (int j = 10; j <= 20; j++)
            //{
            //    Console.WriteLine("I can count further up to " + j);
            //}
            //Console.ReadLine();


            //// Step 4
            //List<string> favoriteFoods = new List<string>() { "Thai", "Chinese", "Italian", "Mexican", "Japanese" };
            //Console.WriteLine("What text do you want to look for in my favorite foods list?");
            //string findFood = Console.ReadLine();
            //bool foodFound = false;

            //for (int i = 0; i < favoriteFoods.Count; i++)
            //{
            //    if (findFood.ToUpper() == favoriteFoods[i].ToUpper())
            //    {
            //        Console.WriteLine("Yes, I am a big fan of " + favoriteFoods[i] + "!");
            //        Console.WriteLine("That is item number " + i + " in my list.");
            //        foodFound = true;
            //        break;
            //    }
            //}

            //if (!foodFound)
            //{
            //    Console.WriteLine("I'm sorry, but that is not one of my favorite foods.");
            //}

            //Console.ReadLine();


            ////Step 5
            //List<string> bodyParts = new List<string>() { "Head", "Arm", "Arm", "Leg", "Leg", "Foot", "Foot" };
            //Console.WriteLine("What body part do you want to search for?");
            //string findBodyPart = Console.ReadLine();
            //bool bodyPartFound = false;

            //for (int i = 0; i < bodyParts.Count; i++)
            //{
            //    if (findBodyPart.ToUpper() == bodyParts[i].ToUpper())
            //    {
            //        Console.WriteLine("A(n) " + bodyParts[i] + " was found at index number " + i);
            //        bodyPartFound = true;
            //    } 
            //}

            //if (!bodyPartFound)
            //{
            //    Console.WriteLine("I'm sorry, but a " + findBodyPart + " was not included in my list.");
            //}
            //Console.ReadLine();


            //Step 6
            List<string> colors = new List<string>() { "red", "blue", "green", "red", "green", "green" };
            Console.WriteLine("What color do you want to look for?");
            string colorInput = Console.ReadLine();
            bool hasBeenFound = false;

            foreach (string color in colors)
            {
                if (color.ToUpper() == colorInput.ToUpper())
                {
                    Console.WriteLine("Yes, there is " + colorInput + " in this list!");
                    if (!hasBeenFound)
                    {
                        hasBeenFound = true;
                    }
                    else
                    {
                        Console.WriteLine("Hey, you already found " + colorInput + " in this list before!");
                    }
                }
            }
            Console.ReadLine();



        }
    }
}
