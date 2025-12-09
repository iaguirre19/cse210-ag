using System;

class Program
{
    static void Main(string[] args)
    {

        Activity running = new Running(new DateTime(2025, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2025, 11, 4), 40, 15.0);
        Activity swimming = new Swimming(new DateTime(2025, 11, 5), 25, 30);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
