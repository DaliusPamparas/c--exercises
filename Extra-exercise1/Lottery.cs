using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercise1
{
    class Lottery
    {
        private static Random r = new Random();
        public static int Generate()
        {
        
            int lycklig = r.Next(1, 36);
            // from 1-35
            return lycklig;
        }
    }
}
