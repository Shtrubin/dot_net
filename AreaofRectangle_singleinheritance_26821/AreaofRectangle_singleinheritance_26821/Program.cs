using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofRectangle_singleinheritance_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect= new Rectangle();
            rect.setHeight(10);
            rect.setWidth(9);
            Console.WriteLine("The area is " + rect.getArea());
            Console.ReadLine();
        }
    }
    class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    class Rectangle: Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

}
