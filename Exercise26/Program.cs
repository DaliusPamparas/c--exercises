using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int c = Calculator.Add(a, b);
            Console.WriteLine(c);
            a = Calculator.Subtract(c, b);
            Console.WriteLine(a);

            
            Calculator calc = new Calculator();
            calc.Add(5);
            Calculator calc1 = new Calculator();
            calc1.Add(10);
            calc.Subtract(6);
            Console.WriteLine(calc.Memory);

            Console.ReadKey();
        }
    }
}
