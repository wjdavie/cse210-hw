using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>(); 

        Running runningActivity = new Running("20 July 2024", 30, 3);

        Cycling cyclingActivity = new Cycling("15 July 2024", 90, 15);

        Swimming swimmingActivity = new Swimming("18 July 2024", 45, 40);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        Console.WriteLine("Activity Journal: ");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}