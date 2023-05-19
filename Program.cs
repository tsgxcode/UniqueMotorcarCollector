using System;

internal class Program
{
    public static void Main()
    {
        //Basic user input
        
        Console.WriteLine("Unique Motorcar Collector Restorations! "
            + "\n" + "Please add your latest purchase to the Database: "
            + "" + "\n");
        //Changing color of section to maked each a bit easier to read.
        
        Console.ForegroundColor = ConsoleColor.Yellow;

        //Refactored: Import and store user input
        Console.Write("Make: ");
        var make = Console.ReadLine();

        Console.Write("Modal: ");
        var modal = Console.ReadLine();

        Console.Write("Year: ");
        var year = Console.ReadLine();
        Console.Write("\n");



        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("Customer Info: ");
        var cusInfo = Console.ReadLine();
        //Send to teams for restoration stage




        // TO DOs:
        //Save to the database
        {
            //Next Step...

        }
    }
}