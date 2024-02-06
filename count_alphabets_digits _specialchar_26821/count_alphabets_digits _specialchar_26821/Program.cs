using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_alphabets_digits__specialchar_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello world 11 ! This is NCC Class ";

            // Counting alphabets, digits, and special characters
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach (char character in inputString)
            {
                if (Char.IsLetter(character))
                {
                    alphabetCount++;
                }
                else if (Char.IsDigit(character))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine("Alphabets: " + alphabetCount);
            Console.WriteLine("Digits: " + digitCount);
            Console.WriteLine("Special Characters: " + specialCharCount);
            Console.ReadLine();
        }
    }
}
    