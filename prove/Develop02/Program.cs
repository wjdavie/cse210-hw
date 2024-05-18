using System;
using System.Collections.Generic;


// This is my journal program. I beleive it meets all the core requirements, and for the Exceeding Requirements piece, I added comma separators so it could be saved as a .csv file.
// I also added a header row to the file, although it does repeat itself each time it's saved. I didn't have time to figure out how to stop that from happening. This could be a future enhancement.
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator myPrompt = new PromptGenerator();
        Journal myJournal = new Journal();

        int selection = 0;
        
        //Display a welcome message
        Console.WriteLine("Welcome to the Journal Program! ");

        //Display the user menu
        while (selection != 5)
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine("1. Write in your journal ");
            Console.WriteLine("2. Display journal entries ");
            Console.WriteLine("3. Load journal ");
            Console.WriteLine("4. Save journal ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                //Using Entry class
                string newPrompt = myPrompt.GeneratePrompt();
                Console.WriteLine($"{newPrompt}");
                Console.Write(">");
                string response = Console.ReadLine();
                Entry myEntry = new Entry
                {
                    _prompt = newPrompt,
                    _userResponse = response,
                    _date = DateTime.Today.ToString("MM/dd/yyyy"),
                };
                myJournal.AddEntry(myEntry);  
            }

            else if (selection == 2)
            {
                //Using Journal class
                myJournal.DisplayEntries();
            }

            else if (selection == 3)
            {
                //Using Journal class
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                myJournal.LoadFile(fileName);
            }

            else if (selection == 4)
            {
                //Using Journal class
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                myJournal.SaveFile(fileName);
            }

            else if (selection == 5)
            {
                //Quit the program
                Console.WriteLine("Thank you for using the Journal Program! ");
                break;
            }

            else
            {
                //Inform the user that they have made an invalid selection.
                Console.WriteLine("You have made an invalid selection, please try again. ");
            }
        }
    }
}