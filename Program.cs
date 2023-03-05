using System.Runtime.CompilerServices;

internal class Program
{
   public  static void Main(string[] args)
    {
        Console.WriteLine("Unique Motorcar Collector! "
            + "Please add your latest purchas to the Database: "
            + "");

        Console.Write("Make? ");
        var make = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Make? ");
        var modal = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Make: " + make + "\n" + "Modal: " + modal);
    }
}