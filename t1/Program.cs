class Program 
{
static void Main(string[] args)

{
    int M = 2;
    int N = 10;
    PrintNumbersRecursive2(M,N);
}

private static void PrintNumbersRecursive2 (int m,int n)

{ 
    if (m==n)
    Console.WriteLine(m);
    else
    {
    PrintNumbersRecursive2(m+1,n);
    Console.WriteLine(m);  
    }
}
}