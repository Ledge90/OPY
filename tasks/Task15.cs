using System;
// Написать программу, которая осуществляет капитализацию введенного пользователем текста. В качестве разделителя слов использовать пробел.

namespace Task15
{
    class Program
    {
        public static string FirstUpper(string str)
        {
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
                else s[i] = s[i].ToUpper();
            }
            return string.Join(" ", s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUpper(Console.ReadLine()));
        }
    }
}
