namespace While5_For18_Tombasova_Demyanchik
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание.Дано вещественное число A и целое число N (> 0). Используя один цикл, найти значение выражения");
            Console.WriteLine("Введите число X");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            if (N < 0)
            {
                Console.WriteLine("Неправильно ввели число, повторите попытку.");
                Main();
            }
            else
            {
                for (int i = 0; i <= N; i++)
                {
                    sum += Math.Pow(-X, i);
                }
                Console.WriteLine(sum);
                Console.WriteLine();
                While8.While();
            }
        }
    }
}