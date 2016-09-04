using System;
using System.Collections.Generic;

/* Лекция 3 домашнее задание 2 слайд 15
 * Считывать с консоли числа, пока не будет введено число “-1”, 
 * среди введенных чисел вывести все дублирующиеся.
 */

namespace L3_HW2
{
    class Program
    {
        private static HashSet<double> ReadDoublesAndCreateDuplicateHashSet(out HashSet<double> doubles)
        {
            var duplicates = new HashSet<double>();
            doubles = new HashSet<double>();
            while (true)
            {
                string value = Console.ReadLine();
                if (value != "-1")
                    try
                    {
                        var number = Convert.ToDouble(value);
                        if (!duplicates.Contains(number) && doubles.Contains(number))
                        {
                            duplicates.Add(number);
                        }
                        doubles.Add(number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to convert '{value}' to a Double.");
                    }
                else
                {
                    return duplicates;
                }
            }
        }

        static void Main()
        {
            HashSet<double> doubles;
            Console.WriteLine("Enter numbers (for the end of entry enter -1): ");
            var duplicates = ReadDoublesAndCreateDuplicateHashSet(out doubles);

            if (duplicates.Count != 0)
            {
                Console.WriteLine("Duplicates: ");
                foreach (var duplicate in duplicates)
                {
                    Console.WriteLine(duplicate);
                }
            }
            else Console.WriteLine("Entering numbers haven't duplicates");

            Console.ReadKey();
        }
    }
}