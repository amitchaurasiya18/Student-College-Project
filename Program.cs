using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Amit", "Vashi, Navi Mumbai", Convert.ToDateTime("08 / 06 / 2003"));
            Person student1 = new Student(2, "Harsh", "Nerul, Navi Mumbai", Convert.ToDateTime("19 / 07 / 2001"), "Computer Science");
            Person professor1 = new Professor(3, "Vinayak", "Rabale, Navi Mumbai", Convert.ToDateTime("20 / 10 / 1976"), 45250);

            PrintDetails(person1);
            PrintDetails(student1);
            PrintDetails(professor1);
        }

        public static void PrintDetails(Person person)
        {
            Console.WriteLine($"Printing {person.GetType().Name} Details...");
            Console.WriteLine(person.PrintPersonDetails());
            Console.WriteLine();
        }
    }
}
