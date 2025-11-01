using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // part 1 - 2
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // part 3
        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1, 100);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed it!");
            }
        }
    }
}