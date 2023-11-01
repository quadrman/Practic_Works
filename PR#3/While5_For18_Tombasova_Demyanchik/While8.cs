using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While5_For18_Tombasova_Demyanchik
{
    public class While8
    {
        public static void While()
        {
            Console.WriteLine("Задание While5.Дано целое число N (> 0), являющееся некоторой степенью числа 2: N = 2K. Найти целое число K — показатель этой степени.");
            Console.WriteLine("Введите число N, являющееся некоторой степенью числа 2");
            float N = float.Parse(Console.ReadLine());
            int k = 0;
            if (N < 0)
            {
                Console.WriteLine("Неправильно ввели число, повторите попытку.");
                While();
            }
            else
            {
                while(N != 1)
                {
                    N /= 2;
                    k++;
                }
                Console.WriteLine("Степень данного числа равна: "+k.ToString());
            }

        }
    }
}
