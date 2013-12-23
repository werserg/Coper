using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Алгоритм_Флойда
{
    class Program
    {
        static void Main()
        {
            int[,] LNG = new int[5, 5] // задаем матрицу длин между вершинами (1000-обозначен путь между не соединенными вершинами)
 {{0,3,10,1000,1000},
 {3,0,1000,5,1000},
 {10,1000,0,6,15},
 {1000,5,6,0,4},
 {1000,1000,1000,4,0}};

            int i, j, k; // инициализация переменных
            for (k = 0; k < 5; k++)
                for (i = 0; i < 5; i++)
                    for (j = 0; j < 5; j++)
                        if (LNG[i, j] > LNG[i, k] + LNG[k, j])
                            LNG[i, j] = LNG[i, k] + LNG[k, j];

            // выведение конечной матрицы длин
            Console.WriteLine("Алгоритм Флойда : ");
            Console.WriteLine("   1 2 3 4 5 ");
            Console.WriteLine(" ____________");

            for (i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "| ");
                for (j = 0; j < 5; j++)
                    Console.Write("{0} ", LNG[i, j]);
                Console.WriteLine("\n |");
            }
            Console.ReadLine();
        }
    }
}