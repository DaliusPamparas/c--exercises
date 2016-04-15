using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Bicycle : Vehicle
    {
        public bool dinamoON { get; set; } 
        public Bicycle() : base("bicycle")
        {

        }
        public void DinamoON()
        {
            dinamoON = true;
        }
        public void Dinamoff()
        {
            dinamoON = false;
        }
    }

}
