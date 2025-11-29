using System;
using System.Threading;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            Console.Write("Breathe out... ");
            ShowCountDown(6);

            Console.WriteLine();
        }

        DisplayEndingMessage();
        Console.WriteLine();
        ShowSpinner(3);
        Console.Clear();
    }
}