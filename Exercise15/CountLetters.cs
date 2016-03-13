using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class CountLetters
    {
        private Dictionary<string, string> dict;
        private string sentence;

        public CountLetters(Dictionary<string, string> dict)
        {
            this.dict = dict;
        }

        public CountLetters(Dictionary<string, string> dict, string sentence) : this(dict)
        {
            this.sentence = sentence;
        }
    }
}
