using System;
using UniqueMotorcarCollector;

class Program
{


    /* 


// TO DOs:
//Save to the database
{
//Next Step...

}*/

    public static void Main()
    {
        //Unique Motorcar Collector Restorations V. 1.01

        //Gather info
        Console.WriteLine("Welcome! Unique Motorcar Collector Restorations! " + "\n");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Owner info: " + "\n");
        Console.ResetColor();

        Console.Write("Name: ");
        var name = Console.ReadLine();

        Console.Write("Address: ");
        var address = Console.ReadLine();


        Console.Write("Phone: ");
        var phone = Console.ReadLine();

        Console.Write("Email: ");
        var eMail = Console.ReadLine();
        Console.Write("\n");


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Vehicle info: ");
        Console.ResetColor();

        Console.Write("Make: ");
        var make = Console.ReadLine();

        Console.Write("Modal: ");
        var modal = Console.ReadLine();

        Console.Write("Year: ");
        var year = Console.ReadLine();
        Console.Write("\n");

        Console.Write("Date submited to UMCR: " + "\n");
        var subDate = Console.ReadLine();
        Console.Write("\n");

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Cost estimate and deposit. Note: Min. 20% required: " + "\n");
        Console.ResetColor();

        Console.Write("Total cost estimate: ");
        var costEst = Console.ReadLine();
        Console.Write("\n");

        Console.Write("Deposit: ");
        var minDeposit = Console.ReadLine();
        Console.Write("\n");
    }
}
