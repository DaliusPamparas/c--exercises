using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23B
{
    class Program
    {
        static void Main(string[] args)
        {
            coordinate? c1 = null;
            coordinate? c2 = new coordinate { x=5, y=10 };
            coordinate? c2 = new coordinate { x = 10, y = 10 };

            coordinate c4 = c1.Value;
            c4.x = 22;
            c4.y = 44;
            c1 = new coordinate { x = 22, y = 44 };
           
            Triangle t1 = new Triangle(coordinate c1, coordinate c2, coordinate c3);
        }
    }
}
