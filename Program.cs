using System;

internal class Program
{
    public static void Main()
    {
        //Basic user input
        Console.WriteLine("Unique Motorcar Collector! "
            + "Please add your latest purchase to the Database: "
            + "");
        //Refactored: Import and store user input
        Console.Write("Make? ");
        var make = Console.ReadLine();
        Console.WriteLine(make);

        Console.Write("Modal? ");
        var modal = Console.ReadLine();
        Console.WriteLine(modal);

        Console.Write("Year? ");
        var year = Console.ReadLine();
        Console.WriteLine(year);

        // TO DOs:
        //Save to the database
        {
            //Next Step...

        }
    }
}