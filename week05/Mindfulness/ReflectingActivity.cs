using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _unusedQuestions;
    private Random _rand = new Random();
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
        _unusedQuestions = new List<string>(_questions);
    }
    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = _rand.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];

        _unusedQuestions.RemoveAt(index);

        return question;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.Write("When you have something in mind, press [enter] to continue. ");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
        Console.WriteLine();
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
        Console.WriteLine("Now ponder on the following questions related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(8);
        }
        DisplayEndingMessage();
        ShowSpinner(3);
        Console.Clear();
    }
}