using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace count__words_Character_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a sample string for counting words and characters.";
            int wordCount = CountWords(inputString);
            int charCount = inputString.Length;
            Console.WriteLine("Total number of words: " + wordCount);
            Console.WriteLine("Total number of characters: " + charCount);
            Console.ReadLine();
        }

        private static int CountWords(string input)
        {
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
