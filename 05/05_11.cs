﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("나눌 숫자를 입력하세요. : ");
        int divider = int.Parse(Console.ReadLine());
        Console.WriteLine(10 / divider);
    }
}