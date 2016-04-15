using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_uml
{
    interface IPersonRegistry
    {
        void AddPerson();
        bool HasPerson();
        string FindPerson();
        List<string> GetListWithNames();

        
    }
}
