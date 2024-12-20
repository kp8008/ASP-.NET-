using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
        private double Basic;
        private double TA;
        private double DA;
        private double HRA;

        public Salary(double basic, double ta, double da = 5000, double hra = 3000)
        {
            Basic = basic;
            TA = ta;
            DA = da;
            HRA = hra;
        }

        public double CalculateSalary()
        {
            return Basic + TA + DA + HRA;
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"The total salary is: {CalculateSalary()}");
        }

    }
}
