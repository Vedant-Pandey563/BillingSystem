using System;

class Program
{
    static void Main()
    {
        int amount = 500;
        int discount = 100;

        Console.WriteLine("Billing System");
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Amount: " + (amount - discount));
    }
}
