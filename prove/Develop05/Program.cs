using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager= new GoalManager();

        bool quit = false;
        
        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points. ");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal ");
            Console.WriteLine("  2. List Goals ");
            Console.WriteLine("  3. Save Goals ");
            Console.WriteLine("  4. Load Goals ");
            Console.WriteLine("  5. Record Event ");
            Console.WriteLine("  6. Quit ");

            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    goalManager.AddGoal();
                    break;
                case 2:
                    goalManager.DisplayGoals();
                    break;
                case 3:
                    goalManager.SaveFile();
                    break;
                case 4:
                    goalManager.LoadFile();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("You have made an invalid selection. ");
                    break;
            }
        }
    }
}