using System;
// Задана последовательность целых чисел. Подсчитать количество элементов, у которых четные соседи.

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " ";
            str = Console.ReadLine();
            var array = Array.ConvertAll(str.Split(' '), s => int.Parse(s));
            int Length_array = array.Length;
            int count = 0;

            for (int i = 1; i < Length_array - 1; i++)
            {
                if (array[i - 1] % 2 == 0 && array[i + 1] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
