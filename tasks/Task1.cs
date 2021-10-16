/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld 
{
    
  static void Main(string[] args)
  {
    double A = Convert.ToDouble(Console.ReadLine());
    double B = Convert.ToDouble(Console.ReadLine());
    double C = Convert.ToDouble(Console.ReadLine());
    
    if ((A > B) && (A > C)) 
    {
        Console.WriteLine(A);
    }
    else if ((B > A) && (B > C)) 
    {
        Console.WriteLine(B);
    }
    else 
    {
        Console.WriteLine(C);
    }
    
    
  }
  
}
