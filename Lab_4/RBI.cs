using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class RBI
    {
        public virtual void calculateInterest(int p, int r, int n)
        {
            Console.WriteLine(p * r * n +"RBI");

        }
    }
    public class HDFC : RBI
    {
        public override void calculateInterest(int p, int r, int n)
        {
            Console.WriteLine(p * r * n + "HDFC");

        }
    }
    public class SBI : RBI
    {
        public override void calculateInterest(int p, int r, int n)
        {
            Console.WriteLine(p * r * n + "SBI");
        }
    }
    public class ICICI : RBI
    {
        public override void calculateInterest(int p, int r, int n)
        {
            Console.WriteLine(p * r * n + "ICIC");

        }

    }
}
