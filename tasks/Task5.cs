using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter the number: ");

                int number = Convert.ToInt32(Console.ReadLine());
                int summa = 0;

                for (int i = 1; i <= number; i++)
                {
                    summa += number;
                }

                Console.WriteLine($"Your number {number}. Your answer: {summa}");
                Console.ReadLine();
            }
        }
    }
}