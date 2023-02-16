// Решение задачи №6 (на вход число, на выход ответ,четное или нечетное)
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x;
        
        x = (int) inputValue();
        Console.WriteLine(x);
        if (x % 2 == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
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
