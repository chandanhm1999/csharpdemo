// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Array with index
       int[] rollNumber = {1, 2, 3, 4, 5};
       int total = rollNumber[0]+
       rollNumber[1]+
       rollNumber[2]+
       rollNumber[3]+
       rollNumber[4];
       
       Console.WriteLine("Total rollnumber exe:" + total);

        // to find array lenth
        Console.WriteLine("Length of array:" + rollNumber.Length);
    }
}
