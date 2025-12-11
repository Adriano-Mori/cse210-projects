using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    protected int _score = 0;

    public void Start()
    {
        Console.WriteLine("Greetings user");
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1.Create New Goal");
            Console.WriteLine("  2.List Goals");
            Console.WriteLine("  3.Save Goals");
            Console.WriteLine("  4.Load Goals");
            Console.WriteLine("  5.Record Event");
            Console.WriteLine("  6.Quit");
            Console.Write("Please, select a choice from the menu: ");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
                ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                SaveGoals();
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                RecordEvent();
                DisplayPlayerInfo();
            }
            else if (userChoice == "6")
            {
                Console.Write("GoodBye!");
                break;
            }
            else
            {
                Console.Write("Please, enter a valid number from the menu options");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("\nGoal Names:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            string checkbox = g.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i}. {checkbox} {g.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type would you like to create? ");
        string goalChoice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalChoice == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (goalChoice == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (goalChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }


    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        ListGoalNames();

        Console.Write("Enter the number: ");
        int index = int.Parse(Console.ReadLine());
        Goal selected = _goals[index - 1];

        selected.RecordEvent();
        _score += selected.GetPoints();

        if (selected is ChecklistGoal c && c.IsComplete())
        {
            string[] data = c.GetStringRepresentation().Split('|');
            int bonus = int.Parse(data[5]);
            _score += bonus;
        }
    }


    public void SaveGoals()
    {
        using StreamWriter sw = new StreamWriter("goals.txt");
        sw.WriteLine(_score);

        foreach (Goal g in _goals)
        {
            sw.WriteLine(g.GetStringRepresentation());
        }

        Console.WriteLine("\nGoals saved!");
    }

    public void LoadGoals()
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                bool completed = bool.Parse(parts[4]);
                if (completed) g.RecordEvent();
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                var g = new ChecklistGoal(parts[1], parts[2],
                                          int.Parse(parts[3]),
                                          int.Parse(parts[4]),
                                          int.Parse(parts[5]));

                int completedCount = int.Parse(parts[6]);
                for (int x = 0; x < completedCount; x++)
                    g.RecordEvent();

                _goals.Add(g);
            }
        }

        Console.WriteLine("\nGoals loaded!");
    }
}