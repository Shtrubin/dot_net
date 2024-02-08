using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Delegates_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GodDelegate godMethod;
            godMethod = new Ram().GodName;
            godMethod(); 
            godMethod = new Shiva().GodName;
            godMethod(); 
            Console.ReadLine();
        }
    }
    delegate void GodDelegate();
    class Ram
    {
        public void GodName()
        {
            Console.WriteLine("God Ram");
        }
    }
    class Shiva
    {
        public void GodName()
        {
            Console.WriteLine(" God Shiva");
        }
    }
}
