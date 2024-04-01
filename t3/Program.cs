using System;

namespace AkkermanFun
{
class Program
{

    public static int CalculateAkkermanFunction(int m, int n)
    {
    if (m == 0) return n + 1;
    if (n == 0) 
        return CalculateAkkermanFunction(m - 1, 1); 
    
    return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
    }

    static void Main(string[] args)
    {
        System.Console.Write("Введите первое число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Введите второе число: ");
        int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(CalculateAkkermanFunction(m, n));
    }
}
}