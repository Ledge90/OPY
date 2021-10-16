/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;


class HelloWorld {
    
    static void Main(string[] args) {
        double price = Convert.ToDouble(Console.ReadLine());
        double sale_3 = 0.97;
        double sale_5 = 0.95;
        
        if (price > 500 && price <= 1000) {
            price = price * sale_3;
        }
        else if (price > 1000) {
            price = price * sale_5;
        }
        
        Console.WriteLine(price);
    }
}
