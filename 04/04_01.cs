using System;

class Person
{
    public string Name = null;
    public string Bithday = null;
    public string a = null;

    public void eat()
    {
        Console.WriteLine(Name + "이(가) 아침을 먹었습니다.");
    }
    
    public void walk()
    {
        Console.WriteLine(Name + "이(가) 걷습니다.");
    }

    public void run()
    {
        Console.WriteLine(Name + "이(가) 뜁니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Person p1;
        p1 = new Person();
        p1.Name = "서준";
        p1.eat();
    }
}