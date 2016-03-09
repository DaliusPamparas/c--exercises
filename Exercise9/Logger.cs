using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Logger
    {
        

        public List<string> _LogPosts { get; private set; }

        public Logger()
        {
            _LogPosts = new List<string>();
        }

        public void Log(string message)
        {
            _LogPosts.Add(message);  
        }
    }
}
