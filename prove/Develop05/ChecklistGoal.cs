using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _target;
    private int _progress = 0;
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int target) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _target = target;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int target, int progress) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _target = target;
        _progress = progress;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetTarget()
    {
        return _target;
    }
    public int GetProgress()
    {
        return _progress;
    }

    public void SetProgress(int progress)
    {
        _progress = progress;
    }


    //To be used for the creativity section. Animation will be displayed when the user gets bonus points.
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
     public override int CalculatePoints()
    {
        if (_completed == true)
        {
            //This is my area showing creativity. I added a bonus celebration that is defined below.
            CelebrateBonus();

            return GetPoints() + _bonusPoints;

        }
        else if (_completed == false)
        {
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }
    public override void RecordProgress()
    {   
        _progress ++;

        if (_progress == _target)
        {
            _completed = true;
        }

        else
        {
            _completed = false;
        }
    }

    public override void MarkCompleted()
    {
        if (_progress == _target)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
    }

    //ShowAnimation to be used in Bonus Celebration for adding creativity
    public void ShowAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

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

    //This method is being created to show creativity in my code. It celebrates the user hitting their target goal.
    public void CelebrateBonus()
    {
        ShowAnimation();

        Console.WriteLine();
        Console.WriteLine($"*******You met your target! You know what this means!******* ");
        Thread.Sleep(3000);
        Console.WriteLine();
        Console.WriteLine("BONUS POINTS! ");
        Thread.Sleep(1000);
        Console.WriteLine("     BONUS POINTS! ");
        Thread.Sleep(1000);
        Console.WriteLine("          BONUS POINTS! ");

        ShowAnimation();
    }
}