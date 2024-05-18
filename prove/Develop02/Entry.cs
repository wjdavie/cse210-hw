using System;

//This class is used to define the entries to be stored in the journal. 
public class Entry
{
    public string _prompt;
    public string _userResponse;
    public string _date;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} ");
        Console.WriteLine($"Prompt: {_prompt} ");
        Console.WriteLine($"{_userResponse} ");
        Console.WriteLine(); //Adding a blank line between entries.
    }
}
