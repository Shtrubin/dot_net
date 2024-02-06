using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGod g1 = new Ram();
            g1.GodName();
            IGod g2 = new Shiva();
            g2.GodName();
            Console.ReadLine();
        }
    }
    interface IGod
    {
        void GodName();
    }
    class Ram: IGod
    {
        public void GodName() {
            Console.WriteLine("God Ram");
                }
    }
    class Shiva : IGod
    {
        public void GodName()
        {
            Console.WriteLine("God Shiva");
        }
    }
}
