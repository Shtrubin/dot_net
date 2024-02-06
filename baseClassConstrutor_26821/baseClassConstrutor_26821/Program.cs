using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace baseClassConstrutor_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car cr = new car();
            Console.WriteLine("Car Model: {0}, Speed: {1} ", cr.model, cr.speed);
            Console.ReadLine();

        }
    }
    class Vehicle
    {
        public int speed;
        public Vehicle()
        {
            this.speed = 5;
        }

    }
    class car: Vehicle
    {
        public string model;
        public car() : base()
        {
            this.model = "BMW";
        }
    }
}
