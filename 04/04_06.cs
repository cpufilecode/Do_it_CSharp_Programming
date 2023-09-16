using System;

class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot: Robot
{
    public void Clean()
    {
        Console.WriteLine("청소를 시작합니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot cleanRobot = new CleanRobot();
        cleanRobot.Move();
        cleanRobot.Clean();
    }
}