using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Exception1
    {
       public void exception()
        {
            try
            {
                Console.Write("Enter number 1 :");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter number 2 :");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ans:"+(a / b));

            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }

    
}
