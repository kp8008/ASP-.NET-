using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Account_Details
    {
        public int Account_No { get; set; }
        public string Account_Name { get; set; }
        public double Balance { get; set; }
        public double Interest_Rate { get; set; }

        public void GetAccountDetails()
        {
            Console.Write("Enter Account No: ");
            Account_No = int.Parse(Console.ReadLine());
            Console.Write("Enter Account Name: ");
            Account_Name = Console.ReadLine();
            Console.Write("Enter Account Balance: ");
            Balance = double.Parse(Console.ReadLine());
            Console.Write("Enter Interest Rate (in %): ");
            Interest_Rate = double.Parse(Console.ReadLine());
        }

    }
    class Interest : Account_Details
    {
        public double CalculateInterest()
        {
            return Balance * (Interest_Rate / 100);
        }
        public void DisplayTotalInterest()
        {
            double interest = CalculateInterest();
            Console.WriteLine($"\nAccount No: {Account_No}");
            Console.WriteLine($"Account Name: {Account_Name}");
            Console.WriteLine($"Total Interest: {interest}");
        }
    }
}
