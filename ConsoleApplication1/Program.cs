using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultat = 0;
            //skriver in data
            Console.WriteLine("Select an operator:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("A. Addition (+)");
            Console.WriteLine("B. Subtraction (-)");
            Console.WriteLine("C. Multiplication (*)");
            Console.WriteLine("D. Division (/)");
            string menu = Console.ReadLine();
            Console.WriteLine("Choise :  " + menu.ToUpper());
            Console.Write("Write number 1:  ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Write number 2:  ");
            int number2 = int.Parse(Console.ReadLine());
             //vi gör operation + - * /
            switch (menu.ToUpper())
            {
                case "A":
                    resultat = number1 + number2;
                    break;
                case "B":
                    resultat = number1 - number2;
                    break;
                case "C":
                    resultat = number1 * number2;
                    break;
                case "D":
                    resultat = number1 / number2;
                    break;


             }
            Console.WriteLine("Result: " + resultat);
            Console.ReadKey();

        }
    }
}
