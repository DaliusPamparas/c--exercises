using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31
{
    class CountWords
    {
        
        public static int Count (string sentence)
        {
            string[] words = sentence.Split(' ');
           return words.Length;
        }
    }
}
