using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interfaces_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGod circle = new Ram();
            circle.GodName();
            IGod rectangle = new Shiva();
            rectangle.GodName();
            Console.ReadLine();
        }
    }
    interface IGod
    {
        void GodName();
    }
    class Ram : IGod
    {
        public void GodName()
        {
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