using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7._1
{
    internal class ReverseDigits
    {
        public static void Task3()
        {
            Console.WriteLine("Введите число X:");
            int Number = int.Parse(Console.ReadLine());
            ReverseNumber(Number);
        }
        static void ReverseNumber(int number)
        {
            if (number < 10)
            {
                Console.Write(number);
                return;
            }

            Console.Write(number % 10);
            ReverseNumber(number / 10);
        }

    }
}
