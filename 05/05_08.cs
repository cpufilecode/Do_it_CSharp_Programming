using System;
using System.Collections;

class MainClass
{
    public static void Main(string[] args)
    {
        Queue qu = new Queue();

        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);

        while (qu.Count > 0)
        {
            Console.WriteLine(qu.Dequeue());
        }
    }
}