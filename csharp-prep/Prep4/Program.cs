using System;
using System.Collections.Generic;
//This program includes the core and stretch requirements
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //Creating the new list

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. "); //User will type in a list of numbers and chose 0 when finished.

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers) //Calculate the sum of the numbers in the list.
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum} ");

        float average = ((float)sum) / numbers.Count; //Calculate the average of the numbers in the list.

        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];

        foreach (int number in numbers) //Find the largest number in the list.
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {max} ");

        int min = int.MaxValue;

        foreach (int number in numbers) //Find the lowest positive number in the list.
        {
            if (number < min && number > 0 )
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest positive number is {min} ");

        numbers.Sort(); //Sorts the list.

        Console.WriteLine("The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number); //Displays the new sorted list.
        }
    }
}