using System;
using System.Collections;

class MainClass
{
    public static void Main(string[] args)
    {
        ArrayList al =  new ArrayList();

        al.Add(1);
        al.Add("Hello");
        al.Add(3.3);
        al.Add(true);

        foreach(var item in al)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        al.Remove("Hello");

        foreach(var item in al)
        {
            Console.WriteLine(item);
        }
    }
}