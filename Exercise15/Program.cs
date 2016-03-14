using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Dictionary<char, string> dict = new Dictionary<char, string>();
            string sentence = "Hello world and some more words, yes and some words.";
            CountLetters countLetters = new CountLetters(dict, sentence);

            countLetters.AllSymbols(dict, sentence);
            countLetters.Print(dict);

            dict.Clear();
            Console.WriteLine("\n\n\n");

            countLetters.Alphabetics(dict, sentence);
            countLetters.Print(dict);


            Console.ReadKey();
             

        }
    }
}
