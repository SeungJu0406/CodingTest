using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        if (s.Length >= 2)
        {
            bool aSuccess = int.TryParse(s[0], out int a);
            bool bSuccess = int.TryParse(s[1], out int b);

            if (aSuccess && bSuccess)
            {
                for (int i = 0; i < b; i++) 
                {
                    for(int j = 0; j < a; j++)
                    {
                        Console.Write("*");
                    }     
                    Console.WriteLine("");
                }
            }
        }
    }
}