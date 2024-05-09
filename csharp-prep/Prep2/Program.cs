using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        string letter = "";
        string grade = "";
        int digit = (percent % 10);

        if (percent >= 90)
        {   
            letter = "A";
        }
        else if (percent >= 80)
        {   
            letter = "B";
        }
        else if (percent >= 70)
        {   
            letter = "C";
        }
        else if (percent >= 60)
        {   
            letter = "D";
        }
        else
        {   
            letter = "F";
        }

        if (digit >= 7 && letter != "A" && letter != "F")
        {
            grade = "+";
        }
        else if (digit < 3 && letter != "F")
        {
            grade = "-";
        }
        else
        {
            grade = " ";
        }

        Console.WriteLine($"Your grade is: {letter}{grade} ");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed! ");
        }
        else
        {
            Console.WriteLine("Better luck next time! ");
        }
    }
}