using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetr
{
    internal class Program
    {
        static int Perimetr(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите три стороны треугольника: ");
                int katet1 = int.Parse(Console.ReadLine());
                int katet2 = int.Parse(Console.ReadLine());
                int resolt = int.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр равен: {Perimetr(katet1, katet2, resolt)}");
            }
        }
    }
}
