//Added a greeting message at the beggining of the program, if the user types another number that is not in the option menu, a message will appear.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}