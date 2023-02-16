//  Решение задачи №2 (на вход два числа,на выход макс и мин)
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x;
        
        x = (int) inputValue();
        Console.WriteLine(x);
        int y;
        
        y = (int) inputValue();
        Console.WriteLine(y);
        if (x > y)
        {
            Console.WriteLine("max=x");
            Console.WriteLine("min=y");
        }
        else
        {
            Console.WriteLine("max=y");
            Console.WriteLine("min=x");
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
