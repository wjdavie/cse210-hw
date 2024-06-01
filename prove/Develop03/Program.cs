using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcome the user to the program and ask them for the scripture reference and text.
        /*
        //For the "showing creativity" part of the assignment I have added the code below which will prompt the user to enter their reference and scripture text. For ease of grading I 
        //have commented out the code and used a static scripture.
        Console.WriteLine("Welcome to the Scripture Memorizer Program! ");
        Console.WriteLine("");
        Console.Write("What book is the scripture in? ");
        string userBook = Console.ReadLine();
        Console.Write("What chapter is the scripture in? ");
        string userChapter = Console.ReadLine();
        Console.Write("What is the first verse in the scripture? ");
        string userVerse = Console.ReadLine();
        Console.Write("What is the last verse in the scripture? ");
        string userEnd = Console.ReadLine();
        Console.Write("Please enter the scripture you would like to memorize: ");
        string userScripture = Console.ReadLine();

        Console.Clear();

        Reference reference= new Reference(userBook, userChapter, userVerse, userEnd);
        Scripture scripture = new Scripture();
        scripture.ShowScripture(reference, userScripture);
        Console.WriteLine(scripture.GetScripture());
        */
        //This section creates the scripture with the reference.
        Reference reference= new Reference("2Nephi", "2", "24", "25");
        Scripture scripture= new Scripture();
        scripture.ShowScripture(reference, "But behold, all things have been done in the wisdom of him who knoweth all things. Adam fell that men might be; and men are, that they might have joy. ");
        
        Console.Clear(); //clears the console

        //Displays the scripture and reference
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("");

        while (true)
        {
            //Prompts the user to continue or quit.
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput == "quit" || scripture.AllHidden())
            {
                break; //If all the words are hidden the program will quit.
            }
            else if (userInput == "")
            {
                scripture.HideWords(); //Hides random words if the user hits "enter"

            }
            else
            {
                Console.WriteLine("You have made an invalid selection.");
                Console.Write("Press enter to continue or type 'quit' to finish: ");
            }

            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine("");
        }

    }
}