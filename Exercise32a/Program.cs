using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32a
{
    class Program
    {
        static void Main(string[] args)
        {
            object emp = new Emploee();
            object sup = new SuperUser();
            object user = new User();

            if(emp is SuperUser)
            {
                Console.WriteLine("emp Is superuser");
            }
            if(sup is SuperUser)
            {
                Console.WriteLine("sup is superuser");
            }
            Emploee nUser = sup as Emploee;
            Console.WriteLine(sup as Emploee);
            Console.ReadKey();
            Console.WriteLine( nUser is Emploee);
            Console.ReadKey();

           

        }
    }
}
