using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7._1
{
    internal class Class1
    {
      
        internal class Program
        {
          static int[,] pic = new int[,]
{
    {0, 1, 1, 0, 0, 1, 1, 0},
    {1, 0, 0, 1, 1, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 1},
    {0, 1, 0, 0, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 1, 0, 0},
    {0, 0, 0, 1, 1, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0}
};

            public static void SecondPic(string[] args)
            {

                void printImage(int[,] image)
                {
                    for (int i = 0; i < image.GetLength(0); i++)
                    {
                        for (int j = 0; j < image.GetLength(1); j++)
                        {
                            if (image[i, j] == 0) Console.Write(" "); else Console.Write("+");
                        }
                        Console.WriteLine();
                    }
                }
                void FillImage(int row, int col)
                {
                    if (pic[row, col] == 0)
                    {
                        pic[row, col] = 1;
                        FillImage(row - 1, col);
                        FillImage(row, col - 1);
                        FillImage(row + 1, col);
                        FillImage(row, col + 1);
                    }
                }
                printImage(pic);
                FillImage(4, 4);
                printImage(pic);
                Console.ReadKey();
            }
        }
    }
}
