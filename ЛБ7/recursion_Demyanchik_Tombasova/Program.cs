
namespace recursion_Demyanchik_Tombasova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Факториал до 40");
            for (int i = 1; i <= 40; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }
            double Factorial(int n)
            {
                // 1! = 1
                // 0! = 1
                if (n == 1) return 1;
                else return n * Factorial(n - 1);
            }

            Console.WriteLine();
            Console.WriteLine("Числа фибоначи");
            int Fibonacci(int n)
            {
                if (n == 1 || n == 2) return 1;
                else return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Числа от N до 1");
            Console.WriteLine("Введите число N");
            int N = int.Parse(Console.ReadLine());
            NaturalNums_NtoOne(N);
            int NaturalNums_NtoOne(int n)
            {
                Console.Write(n + " ");
                if (n == 1) return 1;
                else
                    return NaturalNums_NtoOne(n - 1);
            }
            Console.WriteLine();
            Console.WriteLine("Числа от 1 до N");
            Console.WriteLine("Введите число N");
            N = int.Parse(Console.ReadLine());
            NaturalNums_OneToN(N);
            void NaturalNums_OneToN(int n)
            {

                if (n > 0)
                {
                    NaturalNums_OneToN(n - 1);
                    Console.Write(n + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Числа от M до N");
            Console.WriteLine("Введите число M");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N");
            N = int.Parse(Console.ReadLine());
            fromMtoN(M, N);
            void fromMtoN(int m, int n)
            {
                if (n != m - 1)
                {

                    fromMtoN(m, n - 1);
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма чисел от M до N");
            Console.WriteLine("Введите число M");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(SummfromMtoN(M, N));
            int SummfromMtoN(int m, int n)
            {
                if (n != m - 1)
                {
                    return n + SummfromMtoN(m, n - 1);
                }
                else return 0;
            }
            Console.WriteLine();
            Console.WriteLine("Сумма цифр числа N");
            Console.WriteLine("Введите число N");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(N));
            int SumDigits(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                else
                {
                    return (n % 10) + SumDigits(n / 10);
                }
            }
        }



    }
}