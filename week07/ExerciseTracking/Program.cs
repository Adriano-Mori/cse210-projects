using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r = new Running("Running", "03 Nov 2022", 30, 4.8);
        Cycling c = new Cycling("Cycling", "04 Nov 2022", 40, 20.0);
        Swimming s = new Swimming("Swimming", "01 Nov 2022", 25, 30);

        activities.Add(r);
        activities.Add(c);
        activities.Add(s);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}