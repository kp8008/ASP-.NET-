using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class LongWord
    {
        public void FindLong(String str) 
        {
            String maxWidthWord = "";
            int maxWidth = 0;
            Console.WriteLine("Split result: ");
            string[] words = str.Split(' ');
            foreach (var word in words)
            {
                if (word.Length > maxWidth)
                {
                    maxWidth = word.Length;
                    maxWidthWord = word;
                }
            }
            Console.WriteLine($"The word with the maximum width is: '{maxWidthWord}' with length {maxWidth}");
        }
    
    }
}
