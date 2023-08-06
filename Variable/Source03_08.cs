using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool A, B;

        A = true;
        B = false;

        Console.WriteLine(A && A);
        Console.WriteLine(A && B);

        Console.WriteLine(A || B);
        Console.WriteLine(B || B);

        Console.WriteLine(!A);
    }
}