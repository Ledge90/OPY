using System;
// Написать программу для получения реверсированной строки.

class task14
{
    static void Main()
    {
        string text = Convert.ToString(Console.ReadLine());

        char[] textReverse = text.ToCharArray();
        Array.Reverse(textReverse);
        text = new string(textReverse);
        Console.WriteLine(text);
    }
}