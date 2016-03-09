using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5MedKlass
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("dalius", "Pamparas","19720827-0000","80");
            
            var emp2 = new Employee("19730200-7777");

            emp.SkrivUtEmploee();
            emp2.SkrivUtSsn();

            string myfullname = emp.FullName;
            Console.WriteLine(myfullname);


        Console.ReadKey();

        }
    }

}
