using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator_ICE_3
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea():F2}");
        }
    }
}