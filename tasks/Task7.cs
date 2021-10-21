using System;

namespace ConsoleApp3
{
    class task7
    {
        static void Main(string[] args)
        {
            int i, x = 0, count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)

            {
                if (i % 2 == 0)
                {
                    count++;
                    x = x + i;

                }
                Console.WriteLine($"x = {x} count = {count}");
            }

        }
    }
}
