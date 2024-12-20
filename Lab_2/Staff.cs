using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        public void GetStaffDetails()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Department: ");
            Department = Console.ReadLine();
            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();
            Console.Write("Enter Experience (in years): ");
            Experience = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            Salary = double.Parse(Console.ReadLine());
        }
        public void DisplayHODDetails()
        {
            if (Designation.ToUpper() == "HOD")
            {
                Console.WriteLine($"Name: {Name}, Salary: {Salary}");
            }
        }
    }
}
