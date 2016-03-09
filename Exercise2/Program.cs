using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in din namn");
            string namn = Console.ReadLine();
            Console.WriteLine("Var jobbar du");
            string jobb = Console.ReadLine();
            Console.WriteLine("Hur gammal du");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad jobbar du");
            string yrke = Console.ReadLine();
            var denAr = DateTime.Now.Year;
            var minBirdhDate = denAr - age;

            Console.WriteLine("Hello, {0}.\n You are {1} years old , which mean that you was born {2}.\n You work at {3}, where {4} is your title.", namn, age, minBirdhDate, jobb, yrke);
;            Console.ReadLine();

            
        }
    }
}
