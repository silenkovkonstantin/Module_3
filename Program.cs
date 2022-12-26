using System;

class MainClass
{
    public static void Main(string[] args)
    {

        const string myName = "Kostya";

        Console.WriteLine(myName);
        Console.WriteLine("Привет, \n мир!");
        Console.WriteLine("\u0023");
        Console.WriteLine(true);
        Console.WriteLine(false);
        Console.WriteLine(5);
        Console.WriteLine(0x0A);
        Console.WriteLine(0b11);
        Console.WriteLine(5.5);

        Console.ReadKey();
    }
}