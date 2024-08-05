using System;

public class Example
{
    public static void Main()
    {
        if(int.TryParse(Console.ReadLine(),out int number)){
        for(int y=0;y<number;y++){
            for(int x=0; x<=y;x++){
                Console.Write("*");
            }
            Console.WriteLine();
          }
        }
    }
}