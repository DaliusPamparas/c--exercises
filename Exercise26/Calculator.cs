using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    class Calculator
    {
        private static int _memory;
        public  int Memory
        {
            get
            { return _memory; }
        }


       public static int Add(int a, int b)
        {
            return a + b;

        }
        public static int Subtract(int a,int b)
        {
            return a - b;
        }

        public void Add(int a)
        {
            _memory += a;

        }
        public void Subtract(int a)
        {
            _memory = _memory - a;
            
        }
    }
}
