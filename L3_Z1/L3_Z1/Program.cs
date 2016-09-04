using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лекция 3 задание 1 слайд 10
 * Сделать методы для считывания целых чисел, дробных чисел. 
 * Сделать методы для вывода на консоль этих типов данных, 
 * массивов целых и дробных чисел (можно доработать любое ДЗ).
 */
namespace L3_Z1
{
    class Program
    {
        private static double ConsoleReadDouble()
        {
            double value;
            if (double.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            return 0;
        }

        private static double ConsoleReadInt()
        {
            int value;
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            return 0;
        }

        private static void ConsoleWrite(double value)
        {
            Console.WriteLine("double value = {0}", value);
        }

        private static void ConsoleWrite(int value)
        {
            Console.WriteLine("int value = {0}", value);
        }

        private static void ConsoleWrite(int[] value)
        {
            Console.Write("values of int array = ");
            foreach (var val in value)
            {
                Console.Write("{0} ", val);
            }
        }

        private static void ConsoleWrite(double[] value)
        {
            Console.Write("values of double array = ");
            foreach (var val in value)
            {
                Console.Write("{0} ", val);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
