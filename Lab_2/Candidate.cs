using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        int ID {  get; set; }
        string Name { get; set; }
        int Age { get; set; }
        int Weight {  get; set; }
        int Height {  get; set; }
       
        public string Description { get; set; }
        public void GetCandidateDetails() 
        {
            Console.WriteLine("Enter id:");
           ID=Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight:");
            Weight = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Height:"); 
            Height = Convert.ToInt32( Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Id:{ID} , \n Name:{Name} \n Agr:{Age} \n Weight:{Weight}\n Height:{Height}");
        }
    }
}
