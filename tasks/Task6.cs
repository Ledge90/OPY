using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            int c = 1;

            do
            {
                c *= b;
                ++b;
            }
            while (b <= a);

            Console.WriteLine(c);
        }
    }
}