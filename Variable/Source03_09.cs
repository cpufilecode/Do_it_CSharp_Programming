using System;
using System.Net.Sockets;

class MainClass
{
    public static void Main(string[] args)
    {
        int score = 85;

        if (score > 80)
            if (score <= 100)
                Console.WriteLine("A");
        if(score > 80 && score <=100)
            Console.WriteLine("A");
    }
}