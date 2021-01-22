using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {



            try
            {
                List<int> myNumbers = new List<int>() { 10, 20, 30, 50, 45 };
                Console.WriteLine("Give me a number to divide my list entries by!");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int number in myNumbers)
                {
                    Console.WriteLine(number + " divided by " + divisor + " equals " + number / divisor);

                }
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("You must enter an integer for this program to work!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by zero is never a good idea...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("I'm not sure how you're seeing this but you did something wrong...");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("This program has emerged from the try/catch block and will continue executing.");
            Console.ReadLine();



            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);

            //    Console.Read();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number.");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by 0...");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    Console.ReadLine();
            //}

            //Console.ReadLine();



        }
    }
}
