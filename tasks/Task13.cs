using System;
// Проверить является введенный пользователем палиндромом или нет. Пробелы и регистр символов в строке игнорировать.

class task13
{
    static void Main()
    {
        int count = 0;
        string text = Convert.ToString(Console.ReadLine());
        text = text.Trim();
        text = text.ToUpper();

        for (int i = 0; i < (text.Length); i++)
        {
            if (text[i] == text[text.Length - 1 - i])
            {
                count = 1;
            }
            if (count == 0)
            {
                Console.WriteLine("This is not Polindrom");
                break;
            }
        }
        if (count == 1)
        {
            Console.WriteLine("This is Polindrom");
        }
    }
}