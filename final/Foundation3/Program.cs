using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1640 Riverside Drive", "Hill Valley", "CA", "12345");
        Lecture lecture1 = new Lecture("Possibilities of Time Travel", "Learn the science behind time travel from the world's top scientist.", "10/26/2024", "8:30 AM", address1, "Dr. Emmet Brown", 200);

        Address address2 = new Address("129 West 81st Street", "New York City", "NY", "67890");
        Reception reception1 = new Reception("Seinfeld Wedding Reception", "It's a wedding about nothing. ", "5/14/2025", "7:00 PM", address2, "email@kramerica.net");

        Address address3 = new Address("2121 Jump Street", "Greendale", "CO", "98765");
        OutdoorGathering gathering1 = new OutdoorGathering("Community Picnic", "Enjoy food, laser tag, and a spirit of community.", "6/2/2025", "11:00 AM", address3, "Temperature: 85 Degrees. Sunny with some clouds rolling in later in the day");

        //Display Messages
        Console.WriteLine("Lecture Marketing Messages ");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Marketing Messages ");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Marketing Messages ");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(gathering1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(gathering1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(gathering1.GetShortDescription());
    }
}