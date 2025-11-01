using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber = -1;
        Console.WriteLine("Enter a number. To quit, type 0");
        while (inputNumber != 0)
        {
            Console.Write("Enter a number:");
            string answerNumber = Console.ReadLine();
            inputNumber = int.Parse(answerNumber);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        // sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is:{sum}");
        //avg
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // max number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}