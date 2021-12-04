// Параметр Ref (параметры ввода-вывода) Выполнить: Создайте функцию MinmaxSeq(), которая принимает два аргумента по ссылке (ref аргументы)
// — минимальное и максимальное значение вводимой последовательности чисел. Запросите у пользователя ввести последовательность, которая должна
// закончиться 0 (если вводится 0, то ввод завершается). Функция должна выполнять поиск максимального и минимального значения последовательности и возвращать результат.

using System;

namespace task18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int? min = null, max = null;
            MinmaxSeq(ref min, ref max);
            Console.WriteLine($"min: {min}\n max:{max}");
        }

        private static void MinmaxSeq(ref int? min, ref int? max)
        {
            Console.WriteLine("Enter half-sequence and end with zero:");
            min = max = int.Parse(Console.ReadLine());
            
            if (min == 0) return;
            
            var x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
