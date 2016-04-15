using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var P = new ProductEntity(ProductStateEnum.InStock, "Kalaskulor", 42);
            Console.WriteLine(P);

        }
    }
}
