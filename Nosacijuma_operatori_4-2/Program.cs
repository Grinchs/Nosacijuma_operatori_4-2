using System;

class Program
{
    static void Main()
    {
        Console.Write("Ievadiet x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Ievadiet y: ");
        double y = double.Parse(Console.ReadLine());

        if (y == 0)
        {
            Console.WriteLine("Dalīšana ar 0");
        }
        else
        {
            double rezultāts = x / y;
            Console.WriteLine("Rezultāts: " + Math.Round(rezultāts, 2));
        }
    }
}