using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name:\n");
            string name = Console.ReadLine();

            Console.WriteLine("Write your birth year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your birth month:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your birth day:");
            int day = int.Parse(Console.ReadLine());

            DateTime birthdate = new DateTime(year, month, day);
            TimeSpan currentAge = new TimeSpan();
            currentAge = DateTime.Now - birthdate;
            int myAge = currentAge.Days / 365;
           

            TimeSpan daysToBirthday = new TimeSpan();
            
            DateTime nexBirthDate = new DateTime(, month, day);




            Console.WriteLine("Hello, " + name + " .\n" + "You are " 
                + myAge + " years old and will turn age " + (myAge + 1) + " in"+
               daysToBirthday + "days");
            Console.ReadKey();
          


        }
    }
}
