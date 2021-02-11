using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudentDB.NETFramework
{
        class Program
        {
            static void Main(string[] args)
            {
                using (var db = new StudentContext())
                {
                    Console.WriteLine("Enter the student's first name.");
                    var firstName = Console.ReadLine();

                    Console.WriteLine("Enter the student's last name.");
                    var lastName = Console.ReadLine();

                    Console.WriteLine("Enter the student's e-mail address.");
                    var emailAddress = Console.ReadLine();

                    Console.WriteLine("Finally, enter the student's favorite class.");
                    var favoriteClass = Console.ReadLine();

                    var student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        EmailAddress = emailAddress,
                        FavoriteClass = favoriteClass
                    };

                    db.Students.Add(student);
                    db.SaveChanges();

                    // Using the MS Docs for helping to display each student

                    var query = from b in db.Students
                                select b;

                    Console.WriteLine("All students in our database:");
                    foreach (var item in query)
                    {
                        Console.WriteLine("\nName: {0} {1} \nE-mail Address: {2} \nFavorite Class: {3}\n", item.FirstName, item.LastName, item.EmailAddress, item.FavoriteClass);

                    }

                    Console.ReadKey();


                }
            }
        }

        public class Student
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
            public string FavoriteClass { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }
    }


