using System;

public class Example
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if(n%2==0)
            Console.WriteLine($"{n} is even");
        else
            Console.WriteLine($"{n} is odd");
    }
}