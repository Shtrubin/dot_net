using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classConstructor_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            cal.display();
            Console.ReadLine();
        }

    }
 public class Calculation
    {
        int i = 0;
        public Calculation() 
        {
            i = 5;
        }
        public void display()
        {
            Console.WriteLine(i);
        }
    }
}
