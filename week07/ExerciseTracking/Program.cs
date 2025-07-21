using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2023, 12, 25), 60, 3.7)); 
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 20));
        activities.Add(new Swimming(new DateTime(2025, 03, 4), 30, 12));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}