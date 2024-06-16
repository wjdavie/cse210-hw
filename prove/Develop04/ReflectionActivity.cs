using System;

class ReflectionActivity : Activity
{
    Random random= new Random();

    List<string> reflections = new List<string>()
    {
        "Think of a time when you completed a difficult task. ",
        "Think of a time when you helped someone in need. ",
        "Think of a time when you accomplished a goal you had set. ",
        "Think of a time when you got a job or promotion that you really wanted. ",
        "Think of a time when you stood up for yourself, or someone else. "
    };

    List<string> questions = new List<string>()
    {
        "How was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were less successful? ",
        "What is your favorite memory about this experience? ",
        "What could you learn from this experience to help you in the future? ",
        "How could this experience help you in other situations? ",
        "What did you learn about yourself through this experience? "
    };

    List<string> usedQuestions = new List<string>(); 
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you to recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public string GenerateReflection()
    {
        string randomReflection = reflections[random.Next(reflections.Count)];
        return randomReflection;
    }

    public string GenerateQuestion()
    {
        //To show creativity and exceed requirements I added code to make sure the questions would not repeat until each question from the list was displayed.
        if (questions.Count == 0)
        {
            questions.AddRange(usedQuestions);
            usedQuestions.Clear();
        }

        int index = random.Next(questions.Count);
        string question = questions[index];
        questions.RemoveAt(index);
        usedQuestions.Add(question);

        return question;
    }
    public void RunActivity()
    {
        base.StartActivity();

        string _reflection = GenerateReflection();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {_reflection} ---\n");

        Console.WriteLine("When you have something in mind press enter to continue. ");
        string userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
            Console.Write("You may begin in: ");
            Countdown();
            Console.Clear();
        }

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string _question = GenerateQuestion();
            Console.Write(_question);
            PauseActivity();
            Console.WriteLine();
        }        

        base.EndActivity();
    }
}