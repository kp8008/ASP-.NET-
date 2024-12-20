using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; } // Constructor to initialize the data members
        public Rectangle(double length, double width) 
        {
            Length = length; 
            Width = width;  
        }
        public double CalculateArea() 
        { 
            return Length * Width; 
        }
    }
}
