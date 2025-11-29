using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _rand = new Random();
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }
    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
    public string GetListFromUser()
    {
        Console.Write("> ");
        return Console.ReadLine();
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt\n");
        Console.WriteLine($"--- {prompt} ---\n");
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like your session to last?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
        Console.Clear();
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = GetListFromUser();
            if (!string.IsNullOrWhiteSpace(item))
                _count++;
        }
        DisplayEndingMessage();
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(3);
        Console.Clear();

    }
}