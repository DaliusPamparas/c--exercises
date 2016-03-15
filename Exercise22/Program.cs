using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            coordinate cord1 =new coordinate();
            cord1.x = 5;
            cord1.y = 5;

            coordinate cord2 = cord1;

            cord2.x = 30;
            cord2.y = 30;

            Console.WriteLine($"cord1.x ={cord1.x}, cord1.y ={cord1.y}");
            Console.WriteLine($"cord2.x ={cord2.x}, cord2.y ={cord1.y}");
        }
    }
}
