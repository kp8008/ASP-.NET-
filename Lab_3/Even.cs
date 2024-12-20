using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Even
    {
        public void CheckEvenNumber(int number)
        {
            try
            {
                if (number % 2 != 0)
                {
                    throw new ArgumentException("The number is not an even number.");
                }
                Console.WriteLine("The number is even.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

    }
}
