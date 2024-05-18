using System;

//This class is used to generate a random prompt to display to the user.
public class PromptGenerator
{
    Random random = new Random();

    List<string> prompts = new List<string>()
    {
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What is one thing that I learned today? ",
        "Who or what do I need to add to my prayers this evening? ",
        "Did I meet anyone new today? ",
        "Is there anything I can do better tomorrow? ",
        "Did you make someone else's day better? " 
    };    
    
    public string GeneratePrompt()
    {
        string randomPrompt = prompts[random.Next(prompts.Count)];
        return randomPrompt;
    }
}