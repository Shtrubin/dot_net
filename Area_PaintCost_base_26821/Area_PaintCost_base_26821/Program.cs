﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_PaintCost_base_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4,5);
            t.Display();
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {

            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width:  {0}", width);
            Console.WriteLine(" Area:  {0}", GetArea());
        }
    }//end class Rectangle
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w) { }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine(" Cost: {0} ", GetCost());
        }
    }
}

