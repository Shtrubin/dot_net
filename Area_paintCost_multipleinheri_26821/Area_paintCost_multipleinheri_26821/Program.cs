using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Area_paintCost_multipleinheri_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            int area;
            rect.setHeight(55);
            rect.setWidth(11);
            area = rect.getArea();
            Console.WriteLine("area = " + rect.getArea());
            Console.WriteLine("Total Cost is " + rect.getCost(area));
            Console.ReadLine();
        }
    }

    class Shape
    {
        protected int height;
        protected int width;

        public void setHeight(int h)
        {
            height = h;
        }

        public void setWidth(int w)
        {
            width = w;
        }
    }

    public interface PaintCost
    {
        int getcost(int area);
    }

    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }

        public int getCost(int area)
        {
            return 90 * area;
        }

        public int getcost(int area)
        {
            throw new NotImplementedException();
        }
    }
}
