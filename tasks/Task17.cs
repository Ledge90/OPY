using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                Console.WriteLine("Enter the three sides of the triangle: ");
                int katet_1 = int.Parse(Console.ReadLine());
                int katet_2 = int.Parse(Console.ReadLine());
                int resolt = int.Parse(Console.ReadLine());
                Perimetr(katet_1, katet_2, resolt);
            }
        }
        static void Perimetr(int a, int b, int c)
        {

            int p = a + b + c;
            Console.WriteLine($"The perimeter is: { p}");
            Console.ReadLine();
        }

    }
}