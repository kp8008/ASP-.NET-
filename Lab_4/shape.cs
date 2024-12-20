using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class shape
    {
        public void area(int a)
        {
            Console.WriteLine("area of square:" + (a * a));

        }
        public void area(int x, int y)
        {
            Console.WriteLine("area of rectangle:" + (x * y));
        }

        public void area(double r)
        {
            Console.WriteLine("area of circle:" + (3.14 * r * r));
        }

    }
}
