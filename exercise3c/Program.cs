using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3c
{
    class Program
    {
        static void Main(string[] args)

        {
            //Vi beskriver våra procenter
            float saleTax = 1.25F;
            float foodTax = 1.12F;

            //input av ingående data
            Console.Write("Enter product name: ");
            string produktname = Console.ReadLine();
            Console.Write("Enter price per unit: ");
            var price = int.Parse(Console.ReadLine());
            Console.Write("Quantity bought: ");
            var quantity = int.Parse(Console.ReadLine());
            Console.Write("Food item(Y/N): ");
            string foodItem = Console.ReadLine();


            //räknar och skriv ut resultat
            Console.WriteLine("---Receipt---");
            Console.WriteLine("Product:" + produktname);
            var total = quantity * price;
            Console.WriteLine("Total amount to pay, exludind tax" + total);

            //vi ska kola är det food item
            // och trycker ut olika receipt variation beroende av procent

            if (foodItem.ToUpper() == "N".ToUpper())
                { 

                
                Console.WriteLine("Total amount to pay, excluding tax: "+ (total * saleTax));
                Console.WriteLine("Of which is tax:  "+ (total * saleTax - total));
            }
                    else
                    {
                     Console.WriteLine("Total amount to pay, excluding tax: "+ (total * foodTax));
                     Console.WriteLine("Of which is tax: "+ (total * foodTax - total));
                
                    }






            Console.ReadKey();



        }
    }
}
