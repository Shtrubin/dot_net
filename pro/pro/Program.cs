using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            God g = new Ram();
            God g2 = new Shiva();
            Console.WriteLine(g.GodName());
            Console.WriteLine(g2.GodName());
            Console.ReadLine();
        }

    }
    public class God
    {
        public virtual string GodName()
        {
            return "God";
        }
    }
    public class Ram: God
    {
        public override string GodName()
        {
            return "Ram";
        }
    }
    public class Shiva: God
    {
        public override string GodName()
        {
            return "Shiva";
        }
    }
}
