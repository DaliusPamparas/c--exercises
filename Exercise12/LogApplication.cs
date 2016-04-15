using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class LogApplication
    {
        private ILogger _logger;

        public LogApplication(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            var input = "";
            do
            {
                Console.WriteLine("1. Add meseage to log");
                Console.WriteLine("2. Print log");
                Console.WriteLine("3. Finish");
                Console.WriteLine("Your choise>");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Write your meseage:");
                        _logger.Log(Console.ReadLine());
                        break;
                    case "2":
                        foreach (var enpost in _logger.LogPosts)
                        {
                            Console.WriteLine(enpost);
                        }
                        break;
                    default:
                        break;
                }
            } while (input !="3");


        }
    }
}
