using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] array1 = new int[3];
        array1[0] = 10;
        array1[1] = 20;
        array1[2] = 30;

        int[] array2 = new int[] { 1, 2, 3 };

        int[] array3 = new int[] { 4, 5, 6 };

        Console.WriteLine(array1);
        Console.WriteLine(array2);
        Console.WriteLine(array3);
    }
}