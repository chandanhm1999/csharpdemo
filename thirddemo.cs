// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        //caseSensite
        
        int username = 10;
        int userName = 20;
        Console.WriteLine ("username value is: " + username);
        Console.WriteLine ("userName value is: " + userName);

        // Lgical Operators
        bool result;
       int n1 = 10, n2 = 20;
       
       // OR operator
       
       result = (n1 == n2) || (n1 > 5);
       Console.WriteLine(result + "\n");
       
       // AND operator
       result = (n1 == n2) && (n1 > 5);
       Console.WriteLine("\n" + result);
    }
}
