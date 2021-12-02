// Вводятся три числа — длины трех сторон треугольника. Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
// Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
// Указание 2: Метод не должен возвращать никакого значения, поэтому вы должны использовать ключевое слово void в сигнатуре:
// Не забудьте преобразовать введенные значения в целые числа.

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
