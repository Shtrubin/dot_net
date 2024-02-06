using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addingtwono_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int y = Convert.ToInt32 (Console.ReadLine());
            int z = x + y;
            Console.WriteLine("Sum is " + z);
            Console.ReadLine();
        }
    }
}
