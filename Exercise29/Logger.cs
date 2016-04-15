using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise29
{
    interface Ilogger
    {
        void Log(string message);
    }
    class Logger : Ilogger
    {
        public void Log(string message)
        {
            
        }
        public string GetLog()
        {
            StreamReader my = new StreamReader(@"C:\Users\Dalius\Desktop\my.txt");
            string line;
            while((line = my.ReadLine()) !=null )
           {
                text
            }


            return 
        }
    }
}
