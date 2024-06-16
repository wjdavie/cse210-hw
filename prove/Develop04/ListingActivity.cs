using System;

class ListingActivity : Activity
{
    Random random = new Random();

    List<string> prompts = new List<string>()
    {
        "Who are the people who support you the most? ",
        "Who are the people that inspire you? ",
        "When have you felt the spirit in your life this month? ",
        "What activities do you enjoy doing? ",
        "What have you accomplished that you are proud of? ",
        "What are the things you like best about yourself? ",
        "What tender mercies have you experienced this month? "
    };

    public ListingActivity(): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ")
    {
    }

    public string GeneratePrompt()
    {
        string randomPrompt = prompts[random.Next(prompts.Count)];
        return randomPrompt;
    }

    public void RunActivity()
    {
        base.StartActivity();

        string prompt = GeneratePrompt();

        Console.WriteLine("List as many responses as you can to the following prompt. ");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        Countdown();
        Console.WriteLine("");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        int responseCount = 0;

        while (DateTime.Now < end)
        {
            Console.Write(">");
            Console.ReadLine();
            responseCount++; 
        }

        Console.WriteLine($"You listed {responseCount} items! ");
        
        base.EndActivity();
    }
}