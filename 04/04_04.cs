using System;

class Cat
{
    public string Name = null;
    public int Weight = 0;

    public Cat(string name)
    {
        Name = name;
        Console.WriteLine("고양이의 이름은 "+ Name +"입니다. ");
    }
}