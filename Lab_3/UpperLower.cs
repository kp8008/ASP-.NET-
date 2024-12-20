using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class UpperLower
    {
        public  string GetUserInput()
        {
            Console.WriteLine("Enter a string:");
            return Console.ReadLine();
        }
        public  string ConvertCase(string input)
        {
            char[] modifiedString = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    modifiedString[i] = char.ToUpper(input[i]);
                }
                else if (char.IsUpper(input[i]))
                {
                    modifiedString[i] = char.ToLower(input[i]);
                }
                else
                {
                    modifiedString[i] = input[i];
                }
            }

            return new string(modifiedString);
        }

        
        public  void DisplayResult(string result)
        {
            Console.WriteLine("Modified string: " + result);
        }
    }

    
}
