using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string[] aFamily = { "Joe", "Shmoe", "Bubba", "Rudolph", "Billy" };
        Console.WriteLine("Choose a number between 0 and 4!");
        int aFamilyIndex = Convert.ToInt32(Console.ReadLine());
        //I used just if statements, but theoretically while loops with if statements would have
        //worked better, as the user would be able to try again if they didn't follow directions...
        if (0<=aFamilyIndex && aFamilyIndex<=4)
        {
            Console.WriteLine("The family member you chose is " + aFamily[aFamilyIndex]);
        }
        else
        {
            Console.WriteLine("I'm sorry, but please choose a number between 0 and 4.");
        }
        Console.ReadLine();



        int[] aRandomInts = { 01, 56, 2, 203, 5, 20, 117, 64 };
        Console.WriteLine("Choose a number between 0 and 7!");
        int aRandomIntsIndex = Convert.ToInt32(Console.ReadLine());
        if (0 <= aRandomIntsIndex && aRandomIntsIndex <= 7)
        {
            Console.WriteLine("The resulting number you've chosen is " + aRandomInts[aRandomIntsIndex]);

        }
        else
        {
            Console.WriteLine("I'm sorry, but you must choose a number between 0 and 7.");
        }
        Console.ReadLine();

        //String list time!
        List<string> stringList = new List<string>();
        stringList.Add("Gameboy");
        stringList.Add("Gameboy Color");
        stringList.Add("GBA");
        stringList.Add("DS");
        stringList.Add("3DS");
        stringList.Add("Switch");

        Console.WriteLine("Choose a number between 0 and 5 to display a Nintendo console.");
        int stringListInt = Convert.ToInt32(Console.ReadLine());

        if (0<= stringListInt && stringListInt <= 5)
        {
            Console.WriteLine("The list item you've chosen is " + stringList[stringListInt]);
        }
        else
        {
            Console.WriteLine("I'm sorry, but that index isn't in this list.");
        }
        Console.ReadLine();


        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(4);
        //intList.Add(10);
        //intList.Add(4);
        //intList.Remove(4);
        //Console.WriteLine(intList[0]);
        //Console.WriteLine(intList[1]);
        //Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////Don't have to use a pre
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();
        
    }
}

