using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class squareandrectangle
    {
        public void area(int a)
        {
            Console.WriteLine("Area of Square :" + (a *a));

        }
        public void area(int x, int y)
        {
            Console.WriteLine("Area of Rectangle :" + (x * y));
        }
    }
}
