// Составить программу для графического изображения делимости чисел от 1 до n (значение n вводится с клавиатуры). В каждой строке надо напечатать очередное число и столько символов «+», сколько делителей у этого числа. Например, если n = 4, то на экране должно быть напечатано:
// 1+
// 2++
// 3++
// 4+++

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}{new string('+', Deliteli(i))}");
            }
        }

        private static int Deliteli(int n)
        {
            return numbs(1, n + 1).Count(i => n % i == 0);
        }

        private static Enumerable<int> numbs(int start, int stop)
        {
            for (int i = start; i < stop; i++)
            {
                yield return i;
            }
        } 
    }
}
