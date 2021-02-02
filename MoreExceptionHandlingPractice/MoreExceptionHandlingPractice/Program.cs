using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandlingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;
            bool userSuccess = false;

            try
            {
                Console.WriteLine("Hello! May I ask for your age?");
                userSuccess = int.TryParse(Console.ReadLine(), out userAge);
                if (!userSuccess) throw new AggregateException();
                if (userAge == 0) throw new DivideByZeroException();
                if (userAge < 0) throw new ArithmeticException();
                if (userAge > 150) throw new ArgumentOutOfRangeException();

                //Whoops! I missed the instruction telling us to give the year the user was born. My bad!
                DateTime dateTime = DateTime.Now;

                //After we get the dateTime for now, we subtract the user's age from the year currently.
                //This gives us a rough estimate for the year the user was born.
                int yearBorn = dateTime.Year - userAge;

                Console.WriteLine("You were probably born in the year {0}", yearBorn);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Aren't you a little young to be running this program?");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Very funny, but that means you wouldn't exist right now.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Sorry, but there's no way that you're this old.");
            }
            catch (AggregateException)
            {
                Console.WriteLine("Next time, please enter only digits and no decimals!");
            }
            catch (Exception)
            {
                Console.WriteLine("I'm sorry, but something went wrong. Please try again.");
            }
            Console.ReadLine();
        }
    }
}
