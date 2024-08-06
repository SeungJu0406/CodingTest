using System;

public class Example
{
    public static void Main()
    {
        string str=Console.ReadLine();
        string[] strArr = str.Split(' ');
        string str1=strArr[0];
        string str2=strArr[1];
        Console.WriteLine($"{str1}{str2}");
    }
}