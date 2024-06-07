using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());
        Console.WriteLine();

        MathAssignment ma = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());
        Console.WriteLine();

        WrtingAssignment wa = new WrtingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
    }
}