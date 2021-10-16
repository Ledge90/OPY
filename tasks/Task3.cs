using System;

class HelloWorld 
{
    
  static void Main(string[] args)
  {
    int x = Convert.ToInt(Console.ReadLine()); # объявляем  переменные
    int y = Convert.ToInt(Console.ReadLine());
    int z = Convert.ToInt(Console.ReadLine());
    
    if (1 <= x <= 3)  # проверяем условие, и если оно истинно то выводим его
    {
        Console.WriteLine(x);
    }
    else if ((1 <= y <= 3)) 
    {
        Console.WriteLine(y);
    }
    else if(1 <= z <= 3)
    {
        Console.WriteLine(z);
    }
    
    
  }
  
}
