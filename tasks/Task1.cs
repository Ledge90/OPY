using System;

class HelloWorld 
{
    
  static void Main(string[] args)
  {
    double A = Convert.ToDouble(Console.ReadLine()); # объявляем переменные
    double B = Convert.ToDouble(Console.ReadLine());
    double C = Convert.ToDouble(Console.ReadLine());
    
    if ((A > B) && (A > C)) # Если А больше других то выводим А
    {
        Console.WriteLine(A);
    }
    else if ((B > A) && (B > C)) # Если B больше других то выводим B
    {
        Console.WriteLine(B);
    }
    else 
    {
        Console.WriteLine(C); # Если С больше других то выводим С
    }
    
    
  }
  
}
