using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings user.");
        Console.WriteLine("Please, input your grade percentage:");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string gradeLetter = "";
        if (percentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (percentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (percentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course.");
        }
    }
}