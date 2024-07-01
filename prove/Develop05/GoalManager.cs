using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;
    private string _fileName;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    public void AddGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine(" 1. Simple Goal ");
        Console.WriteLine(" 2. Eternal Goal ");
        Console.WriteLine(" 3. Checklist Goal ");

        Console.Write("Which type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string _name = Console.ReadLine();

        Console.Write("Give a short description of your goal: ");
        string _description = Console.ReadLine();

        Console.Write("How many points will be awarded when this goal is completed? ");
        int _points = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case 1:
                _goals.Add(new SimpleGoal(_name, _description, _points));
                break;
            case 2:
                _goals.Add(new EternalGoal(_name, _description, _points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be completed to receive a bonus? ");
                int _target = int.Parse(Console.ReadLine());

                Console.Write("How many points are rewarded for the bonus? ");
                int _bonusPoints = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(_name, _description, _points, _bonusPoints, _target));
                break;
            default:
                Console.WriteLine("Invalid selection. ");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Goal has been added. ");

        //Pause for 3 seconds and then return to the main menu.
        Thread.Sleep(3000);

        Console.Clear();
    }

    public void DisplayGoals()
    {
        Console.WriteLine();
        Console.WriteLine("Your goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].MarkCompleted();

            Console.Write($"{_goals[i].GetName()} ({_goals[i].GetDescription()}) ");

            if (_goals[i] is ChecklistGoal checklistGoal)
            {
                Console.Write($"-- Currently completed: {checklistGoal.GetProgress()}/{checklistGoal.GetTarget()} ");
            }

            Console.WriteLine();
        }
    }

    public void SaveFile()
    {
        Console.Write("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal)
                {
                    outputFile.WriteLine($"{goal.GetType().Name}: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, {goal.IsCompleted()} ");
                }
                else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"{goal.GetType().Name}: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()} ");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine($"{goal.GetType().Name}: {checklistGoal.GetName()}, {checklistGoal.GetDescription()}, {checklistGoal.GetPoints()}, {checklistGoal.GetBonusPoints()}, {checklistGoal.GetTarget()}, {checklistGoal.GetProgress()} ");
                }
            }
        }

        Console.WriteLine("File has been saved. ");

        //Pause for 3 seconds and then return to the main menu.
        Thread.Sleep(3000);

        Console.Clear();
    }

    public void LoadFile()
    {
        Console.Write("What is the file name for the goal file? ");
        _fileName = Console.ReadLine();

        if (!File.Exists(_fileName))
        {
            Console.WriteLine("File not found. ");
            return;
        }

        _goals.Clear();

        try
        {
            string[] lines = File.ReadAllLines(_fileName);

            if (lines.Length > 0)
            {
                _totalPoints = int.Parse(lines[0].Trim());
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string goalType = parts[0].Trim();

                string [] goalDetails = parts[1].Trim().Split(',');

                switch (goalType)
                {
                    case "SimpleGoal":
                        if (goalDetails.Length >= 4)
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(goalDetails[0].Trim(), goalDetails[1].Trim(), int.Parse(goalDetails[2].Trim()), bool.Parse(goalDetails[3].Trim()));
                            _goals.Add(simpleGoal);
                        }
                        break;
                    case "EternalGoal":
                        if (goalDetails.Length >= 3)
                        {
                            EternalGoal eternalGoal = new EternalGoal(goalDetails[0].Trim(), goalDetails[1].Trim(), int.Parse(goalDetails[2].Trim()));
                            _goals.Add(eternalGoal);
                        }
                        break;
                    case "ChecklistGoal":
                        if (goalDetails.Length >= 6)
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal(goalDetails[0].Trim(), goalDetails[1].Trim(), int.Parse(goalDetails[2].Trim()), int.Parse(goalDetails[3].Trim()), int.Parse(goalDetails[4].Trim()), int.Parse(goalDetails[5].Trim()));
                            _goals.Add(checklistGoal);
                        }
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("File loaded successfully. ");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("Your goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetName()} ");
        }

        Console.Write("Which goal did you complete? ");
        int recordChoice = int.Parse(Console.ReadLine());

        if (recordChoice >= 1 && recordChoice <= _goals.Count)
        {
            Goal selectedGoal = _goals[recordChoice - 1];

            selectedGoal.RecordProgress();

            int _pointsEarned = selectedGoal.CalculatePoints();

            _totalPoints += _pointsEarned;

            Console.WriteLine();
            Console.WriteLine($"Congratulations! You have earned {_pointsEarned} points! ");
            Console.WriteLine($"You now have {_totalPoints} points. ");
        }
        else
        {
            Console.WriteLine("Invalid selection. ");
        }
    }
}