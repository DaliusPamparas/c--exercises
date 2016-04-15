using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i =0; i<50; i++)
            {
                
                Console.WriteLine(Lottery.Generate() + " min lycklig number");

            }
            
            Console.ReadKey();
        }
    }
}
