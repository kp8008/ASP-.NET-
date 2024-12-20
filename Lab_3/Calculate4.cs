using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public interface Calculate4
    {
        int Addition(int a, int b); 
        int Subtraction(int a, int b); 
    }

    public class Result : Calculate4
    {
        
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }

}
