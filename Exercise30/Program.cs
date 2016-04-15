using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = new wheather();
            DateTime idag = DateTime.Today;

            today.Forecast(idag);
            Console.WriteLine(today);
        }
    }
}
