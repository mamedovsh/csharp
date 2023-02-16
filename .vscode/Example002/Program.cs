// Решение задачи №4 (на ввод 3 числа,показать максимальное) 
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x;
        
        Console.WriteLine("x=");
        x = (int) inputValue();
        int y;
        
        Console.Write("y=");
        y = (int) inputValue();
        int z;
        
        Console.WriteLine("z=");
        z = (int) inputValue();
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("max=x");
            }
            else
            {
                Console.WriteLine("max=z");
            }
        }
        else
        {
            if (y > z)
            {
                Console.WriteLine("max=y");
            }
            else
            {
                if (y < z)
                {
                    Console.WriteLine("max=z");
                }
                else
                {
                    Console.WriteLine("no max");
                }
            }
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
