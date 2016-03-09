using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");
            myLogger.Log("Third post");

            foreach (var item in myLogger._LogPosts)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
