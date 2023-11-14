using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7._1
{
    internal class Recursion_Task1
    {
        public static void Task1()
        {
            Console.WriteLine("Введите число X:");
            int x=int.Parse(Console.ReadLine());
            int pows = x;
            Console.WriteLine("Введите число n");
            int n=int.Parse(Console.ReadLine());
            double Pow = Powering(n, x,pows);
            double fact = RecursionFactorial(n);
            double result = Pow / fact;
            Console.WriteLine(@$"Результат: {result:0.00000}");
            Console.ReadKey();

        }
        public static double Powering(int n, int x,int pows)
        {
            if (n == 1)
            {
                return x;
            }
                else 
            {
                return Powering(n - 1,x*pows,pows);
            }
        }
        public static int RecursionFactorial(int n) 
        {
            if (n > 0)
            {
                return n*RecursionFactorial(n-1);
            }
            else
            {
                return 1;
            }
        }
    }
}
