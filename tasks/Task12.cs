using System;
// Задан массив из n целых чисел. Найти сумму и количество чисел, больших среднего арифметического элементов массива.

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[x];

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"Enter {i} element: ");

                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < x; i++)
            {
                if (b[i] > 0)
                {
                    Console.WriteLine(b[i]);
                }
            }
        }
    }
}
