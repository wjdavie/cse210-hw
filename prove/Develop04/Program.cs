using System;

// This is my Mindfulness program. I beleive it meets all the core requirements, and for the Exceeding Requirements piece, I added code to make sure the questions in the reflection activity would not repeat until each question from the list was displayed.

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity= new ListingActivity();

        int selection = 0;

        Console.Clear();

        while (selection != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start Breathing Activity ");
            Console.WriteLine("  2. Start Reflection Activity ");
            Console.WriteLine("  3. Start Listing Activity ");
            Console.WriteLine("  4. Quit ");
            Console.Write("Please select an option from the menu: ");
            selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    //Using BreathingActivity class
                    breathingActivity.RunActivity();
                    break;
                
                case 2:
                    //Using ReflectionActivity class
                    reflectionActivity.RunActivity();
                    break;

                case 3:
                    //Using ListingActivity class
                    listingActivity.RunActivity();
                    break;

                case 4:
                    //Quit the program
                    Console.WriteLine("Thank you for using the Mindfulness Program! ");
                    return;

                default:
                    //If user enters an invalid selection.
                    Console.WriteLine("You have made an invalid selection, please try again. ");
                    break;
            }
        }
    }
}