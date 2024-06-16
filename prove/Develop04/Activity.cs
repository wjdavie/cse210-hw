using System;
using System.Reflection;
class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;


   public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    List<string> animations = new List<string>()
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\"
    };

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}. \n");
        Console.WriteLine($"{_description} \n");
        Console.Write("How many seconds would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready... ");
        PauseActivity();
        Console.WriteLine();
    }

    public void PauseActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    public void EndActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done! ");
        
        PauseActivity();
        Console.WriteLine("");

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}. ");

        PauseActivity();

        Console.Clear();
    }

        public void Countdown()
    {
        for (int i = 5; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}