using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class CountLetters
    {
        private Dictionary<char, string> dict;
        private string sentence;

        

        public CountLetters(Dictionary<char, string> dict, string sentence)
        {
            this.dict = dict;
            this.sentence = sentence;
        }

        public Dictionary<char, string> AllSymbols(Dictionary<char, string> dict, string sentence)
        {
            foreach (var symbol in sentence)
            {
                
                if (!dict.ContainsKey(symbol))
                {
                    dict.Add(symbol,"*");
                }
                else 
                {
                    dict[symbol] += "*";
                }
            }
            return dict;
        }

        public Dictionary<char, string> Alphabetics(Dictionary<char, string> dict, string sentence)
        {
            foreach (var symbol in sentence)
            {
                if(symbol != ' ' && symbol != '.' && symbol != '!' && symbol != ',')
                { 
                    if (!dict.ContainsKey(symbol))
                    {
                        dict.Add(symbol, "*");
                    }
                    else
                    {
                        dict[symbol] += "*";
                    }
                }
            }
            return dict;
        }

        public void Print(Dictionary<char, string> dict)
        {
            foreach (var i in  dict)
            {
                Console.WriteLine(i);


            }
        }
    }
}
