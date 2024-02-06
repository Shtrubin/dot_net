using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findPosition_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Finder f = new Finder();
            string str1 = "The quick brown fox jumps over the lazy dog" ;
            Console.WriteLine("Original string:" +str1);
            Console.WriteLine(" Position of the word 'fox': " + f.GetResult(str1, "fox"));
            Console.WriteLine(" Position of the word 'The': " + f.GetResult(str1, "The"));
            Console.WriteLine("Position of the word 'lazy': " + f.GetResult(str1, "lazy"));
            Console.ReadLine();

        }
    }
    public class Finder
    {
        public int GetResult(string text, string word)
        {
            // Split the input text into words and find the index (position) of the word
            // Adding +1 to make (starting from 1 instead of 0)
            string[] str = text.Split(' ');
            int a = Array.IndexOf(str, word) + 1;
            return a;
        }
    }
}
