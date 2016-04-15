using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise20
{
    class ListLoader
    {

        public List<string> Loader()
        {
            List<string> result = new List<string>();
            
            var myWriter = new StreamReader("languages.txt");
            string line;

            while((line = reader.ReadLine()) != null)
            {
                result.Add(line);

            }
            return result;


        }
    }
}
