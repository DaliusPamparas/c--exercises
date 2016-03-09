using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            var företagRegister = new Register();
            string menu;
            do
            {
                Console.WriteLine(" 1. Add employee\n 2. Remove employee\n 3. Print entire registry\n 4. Exit\n Enter choice:\n > ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        // Add emploee
                        företagRegister.AddEmploeeToList();
                      
                        break;

                    case "2":
                        // Remove emploee
                        företagRegister.RemovePerson();
                        break;

                    case "3":
                        // Print entire registry
                        företagRegister.SkrivUtRegister();
                        break;
                        
                }
            } while (menu != "4");
            

        }
    }
}
