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

//
            int daysToBirtday = 0;
            DateTime fromToday = DateTime.Now;
            int thisYear = fromToday.Year;
            DateTime nexBirthDate = new DateTime(thisYear, month, day);

            if (nexBirthDate < fromToday)
            {
                nexBirthDate.AddYears(1);
            }

            while (fromToday < nexBirthDate)
            {
                daysToBirtday = daysToBirtday + 1;
                fromToday.AddDays(1);
            }

//
            Console.WriteLine("Hello, " + name + " .\n" + "You are " 
                + myAge + " years old and will turn age " + (myAge + 1) + " in"+
               daysToBirtday + "days");
            Console.ReadKey();
          


        }
    }
}
