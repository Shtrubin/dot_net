using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_MethodOverriding_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            God g = new Ram();
            God g1 = new Shiva();
            Console.WriteLine(g.GodName());
            Console.WriteLine(g1.GodName());
            Console.ReadLine();
        }

    }
    public class God

    {
        public virtual string GodName()
        {
            return " God ";
        }
    }
    public class Ram : God
    {
        public override string GodName()
        {
            return " Ram ";
        }
    }
    public class Shiva : God
    {
        public override string GodName()
        {
            return "Shiva";
        }
    }
}
