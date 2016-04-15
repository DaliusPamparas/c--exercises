using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Vi börjar trycka ut från i
            // sum för samla summan 
            int i = 1;
            int sum = 0;

            //skriver in tal
            Console.WriteLine("Skriv in tal");
            int number = int.Parse(Console.ReadLine());
            // ska kola är det negativ
            if (number > 0)

                {
                //skriver genom loop 1+2+3...
                    while (i <= number)
                    {
                            if(i != number)
                            { 
                            Console.Write(i + "+");
                            }
                              else
                                {
                                  Console.Write(i);
                             }
                    sum = sum + i;
                            i++;
                }
                 //skriver ut summan
                        Console.WriteLine("=" + sum);
                        Console.ReadKey();
                }
            else
            {
                // om tal negativt skriver ut fellmedellande
                Console.WriteLine("Fel : Negative tal");
            }

            }
           
    }
}
