using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For loop
            Console.WriteLine("For Loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //For each loop
            Console.WriteLine("For each loop");
            int[] intarr = new int[] {1,2,3,4,5,6,7};
            foreach (var item in intarr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
