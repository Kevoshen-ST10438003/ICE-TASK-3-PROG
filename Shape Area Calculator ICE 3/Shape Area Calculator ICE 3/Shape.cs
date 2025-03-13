using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator_ICE_3
{
    
    abstract class Shape
    {
        public string Name { get; set; }

        
        protected Shape(string name)
        {
            Name = name;
        }

        
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}