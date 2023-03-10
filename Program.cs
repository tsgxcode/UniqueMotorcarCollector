using System.Runtime.CompilerServices;

internal class Program
{
   public  static void Main(string[] args)
    {
        //Basic user input
        Console.WriteLine("Unique Motorcar Collector! "
            + "Please add your latest purchas to the Database: "
            + "");

        Console.Write("Make? ");
        var make = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Make? ");
        var modal = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Year: ");
        var year = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Price: ");
        var price = Console.ReadLine();
        Console.WriteLine();

        //Storing user input
        Console.WriteLine("Make: " + make + "\n" 
            + "Modal: " + modal + "\n"
            + "Year: " + year + "\n"
            + "Price: " + price);

        //Save to the database
    }
}