using System;

class Program
{
    static void Main(string[] args)
    {
        // main assignment
        Assignment a1 = new Assignment("Alex Mori", "Integrals");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine("");
        //derived
        MathAssignment a2 = new MathAssignment("Laura Silva", "Algebra", "5.2", "10-24");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment a3 = new WritingAssignment("John Doe", "Modern Literature", "Symbolism in 20th Century Poetry");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine("");
    }
}