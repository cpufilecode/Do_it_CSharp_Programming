﻿using System;

class Cat
{
    public string Name = null;

    public Cat()
    {
        Console.WriteLine("생성자가 호출되었습니다.");
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Cat myCat = new Cat();
    }
}