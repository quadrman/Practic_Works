using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7._1
{
    internal class Recursion_Task2
    {
        static public void Task2()
        {
            Console.WriteLine("Введите значение N");
            int N = int.Parse(Console.ReadLine()); // Задайте значение N
            Console.WriteLine("Введите значение x");
            int x = int.Parse(Console.ReadLine()); // Задайте значение x

            double sum = CalculateSum(N, x);

            Console.WriteLine("Сумма: " + sum);
            Console.ReadKey();
        }
        
            
        

    static double CalculateSum(int n, int x)
    {
        if (n == 0)
            return 1;

        double term = Math.Pow(x, n) / Factorial(n);
        return term + CalculateSum(n - 1, x);
    }

    static double Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
        
    }
}

}