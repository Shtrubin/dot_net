using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance_virtual_method_26821
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            God gd = new Ram();
            God gd2 = new Shiva();
            Console.WriteLine(gd.GodName());
            Console.WriteLine(gd2.GodName());
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
    public class Ram : God
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
