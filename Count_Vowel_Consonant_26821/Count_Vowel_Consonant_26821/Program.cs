using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowel_Consonant_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello World Hello universe";
            inputString = inputString.ToLower();
            int vowelCount = 0;
            int consonantCount = 0;

            foreach (char character in inputString)
            {
                if (Char.IsLetter(character))
                {
                    if ("aeiou".Contains(character))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine("Vowels: " + vowelCount);
            Console.WriteLine("Consonants: " + consonantCount);
            Console.ReadLine();
         }
    }
}
