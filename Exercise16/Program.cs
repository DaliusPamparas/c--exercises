using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;using System.Collections.Generic;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            ArrayList list = new ArrayList();
            watch.Reset();
            watch.Start();
            for (var i = 0; i < 10000000 ;i++)
            {
                list.Add(i);

            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds+"ms");
            watch.Reset();
            watch.Start();
            List<int> genList = new List<int>();
            for (var i = 0; i < 10000000; i++)
            {
                genList.Add(i);

            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + "ms");
            watch.Reset();
            Console.ReadKey();

        }
    }
}
