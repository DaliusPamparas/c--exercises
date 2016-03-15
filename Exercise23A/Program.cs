using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23A
{
    class Program
    {
        static void Main(string[] args)
        {
            var chkEmploee = new Checkbox { Description = "Emploee " };
            if(chkEmploee.Checked.HasValue)
            {

                var ischecked = chkEmploee.Checked.Value;
                if (ischecked)
                    Console.WriteLine("Emploee is checked");
                else
                    Console.WriteLine("Emploee is not checked");


            }
            else
            {
                Console.WriteLine("Value not checkt on emploee checkbox");
            }

        }
    }
}
