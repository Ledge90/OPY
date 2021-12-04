// Найти все целые числа из промежутка от 1 до 300, у которых ровно пять делителей.

using System;

namespace Task21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 300; i++)
            {
                Console.Write(Deliteli(i) == 5 ? $"{i}\n" : "");
            }
        }

        public static int dividers(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }

            return count;
        }
    }
}