using System;
namespace RecursiveArrayTraversal
{
class Program
{
static void Main(string[] args)
{
int[] arr = new int[] { 1, 2, 3, 4, 5 };
RecursivePrintElements(arr, arr.Length - 1);
}
    static void RecursivePrintElements(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.Write(arr[index] + " ");
        RecursivePrintElements(arr, index - 1);
    }
}
}