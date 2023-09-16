using System;

class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot : Robot
{
    public void Move()
    {
        Console.WriteLine("청소 로봇이 움직입니다.");
    }
}

class RescueRobot : Robot
{
    public void Move()
    {
        Console.WriteLine("구조 로봇이 이동합니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot cleanRobot = new CleanRobot();
        RescueRobot rescueRobot = new RescueRobot();
        cleanRobot.Move();
        rescueRobot.Move();
    }
}