using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator _promptGen = new PromptGenerator();
        Console.WriteLine("Welcome to the Journal Program, where you can record the most remarkable moments of your life!");
        string _choice = "";
        while (_choice != "5")
        {
            Console.WriteLine("Please select one the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                string _prompt = _promptGen.GetRandomPrompt();
                Console.WriteLine(_prompt);
                Console.Write("> ");
                string _answer = Console.ReadLine();
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = _prompt;
                entry._answer = _answer;
                journal.AddEntry(entry);
            }

            else if (_choice == "2")
            {
                journal.DisplayAll();
            }
            else if (_choice == "3")
            {
                Console.Write("Enter filename: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (_choice == "4")
            {
                Console.Write("Enter filename: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (_choice != "5")
            {
                Console.WriteLine("Not a valid option.");
            }
        }
        Console.WriteLine("Thank you.");
    }
}