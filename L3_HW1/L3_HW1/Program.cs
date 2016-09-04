using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лекция 3 домашнее задание 1 слайд 15
 * Считать строку с консоли. 
 * Создать словарь, где ключом будет символ строки, 
 * а значением - количество данных символов в считанной строке.
 */
namespace L3_HW1
{
    class Program
    {
        private static int CountOfSubstringInString(string value, string substring)
        {
            var count = (value.Length - value.Replace(substring, "").Length) / substring.Length;
            return count;
        }

        private static Dictionary<char, int> CountOfCharsInString(string value)
        {
            Dictionary <char, int> dictionary = new Dictionary<char, int>();
            foreach (var chars in value)
            {
                if (!dictionary.ContainsKey(chars))
                {
                    dictionary.Add(chars, CountOfSubstringInString(value, chars.ToString()));
                }
            }
            return dictionary;
        }

        private static void WriteDictionary(Dictionary<char, int> value)
        {
            foreach (var bit in value)
            {
                Console.WriteLine(bit.Key + " " + bit.Value);
            }
            Console.ReadKey();
        }

        static void Main()
        {
            Console.WriteLine("Введити строку: ");
            var ourString = Console.ReadLine();

            Console.WriteLine("Строка состоит из символов: ");
            WriteDictionary(CountOfCharsInString(ourString));
        }
    }
}
