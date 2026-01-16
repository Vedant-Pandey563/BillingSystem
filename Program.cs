using System;

class Program
{
    static void Main()
    {
        int amount = 500;
        int tax = 50;
        int discount = 100;

        Console.WriteLine("Billing System");
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Tax: " + tax);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Amount: " + (amount + tax - discount));
    }
}

