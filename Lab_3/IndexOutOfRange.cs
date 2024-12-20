using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class IndexOutOfRange
    {

        public void indexout()
        {
            try
            {
                int []array = new int [5];
                for (int i = 0; i < array.Length+1; i++)
                {
                    Console.Write($"Enter number {i} :");
                    array[i]= int.Parse(Console.ReadLine());
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
