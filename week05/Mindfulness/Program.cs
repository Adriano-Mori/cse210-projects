using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the mindfulness program!\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflecting activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4.Quit");
            string userChoice = Console.ReadLine();
            Console.Clear();
            if (userChoice == "1")
            {
                BreathingActivity a1 = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing."
                    );
                a1.Run();
                Console.Clear();
            }
            else if (userChoice == "2")
            {
                ReflectingActivity a2 = new ReflectingActivity(
                    "Reflecting",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life."
                    );
                a2.Run();
                Console.Clear();
            }
            else if (userChoice == "3")
            {
                ListingActivity a3 = new ListingActivity(
                                "Listing",
                                "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area."
                                );
                a3.Run();
                Console.Clear();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}