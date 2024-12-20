using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class AllmethodofString
    {
        public void allmethod(string str)
        {
            // 1
            Console.WriteLine("Length of string: " + str.Length);

            // 2
            Console.WriteLine("Uppercase: " + str.ToUpper());

            // 3
            Console.WriteLine("Lowercase: " + str.ToLower());

            // 4
            string strWithSpaces = "   " + str + "   ";
            Console.WriteLine("Trimmed string: '" + strWithSpaces.Trim() + "'");

            // 5
            if (str.Length > 5)
            {
                string substring = str.Substring(0, 5);
                Console.WriteLine("Substring: " + substring);
            }

            // 6
            string replacedString = str.Replace(" ", "_");
            Console.WriteLine("Replaced string: " + replacedString);

            // 7
            int index = str.IndexOf("a");
            Console.WriteLine("Index of 'a': " + (index >= 0 ? index.ToString() : "Not found"));

            // 8
            bool containsWord = str.Contains("hello", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Contains 'hello': " + containsWord);

            // 9
            string[] words = str.Split(' ');
            Console.WriteLine("Split result: ");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // 10
            bool startsWithHello = str.StartsWith("Hello", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Starts with 'Hello': " + startsWithHello);

            // 11
            bool endsWithExclamation = str.EndsWith("!", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ends with '!': " + endsWithExclamation);
        }
    }
}
