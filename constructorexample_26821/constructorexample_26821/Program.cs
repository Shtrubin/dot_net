//write a c# prg to add the number using comstructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorexample_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first digit");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd digit");
            int b = Convert.ToInt32(Console.ReadLine());   
            Utilities utl=new Utilities(a, b);
            int c = utl.Add();
            Console.WriteLine("sum:" + c);
            Console.ReadLine();
        }
    }
    public class Utilities
    {   
        int first=0, second=0;
        public Utilities(int a, int b)   //constructor
        {
            first= a;
            second= b;
        }

        public int Add()
        {
            return first+second;
        }
                    //method add
    }
}
