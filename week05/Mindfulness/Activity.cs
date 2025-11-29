using System;
using System.Threading;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration=0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        Console.WriteLine($"You've completed {_duration} seconds of the {_name} Activity!");
    }
    public void ShowSpinner(int seconds)
    {
        Console.CursorVisible = false;
        string[] frames = { "—", "/", "|", "\\" };
        int index = 0;
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < seconds)
        {
            Console.Write(frames[index]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            index = (index + 1) % frames.Length;
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}