// Необходимо переделать предыдущую задачу, теперь функция периметр должна возвращать целое значение. Напомним задание: Вводятся три числа — длины трех сторон треугольника. Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
// Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
// Указание 2: Метод должен возвращать значение типа integer, поэтому вы должны использовать ключевое слово int в сигнатуре:
// Указание 3: Не забудьте преобразовать введенные значения в целые числа.

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
