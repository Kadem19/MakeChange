using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purchase Amount: ");
            double purchasePrice;
            purchasePrice = double.Parse(Console.ReadLine());

            Console.Write("Payment Amount: ");
            double paymentAmount = double.Parse(Console.ReadLine());

            double changeDue = paymentAmount - purchasePrice;
            Console.WriteLine($"Change Due: ${changeDue}");
            changeDue += 0.00001;

            int twenties = (int)(changeDue / 20);
            Console.WriteLine($"Twenties: {twenties}");
            changeDue = changeDue - twenties * 20;

            int tens = (int)(changeDue / 10);
            Console.WriteLine($"Tens: {tens}");
            changeDue -= tens * 10;

            int fives = (int)(changeDue / 5);
            Console.WriteLine($"Fives: {fives}");
            changeDue = changeDue % 5;

            int ones = (int)(changeDue / 1);
            Console.WriteLine($"Ones: {ones}");
            changeDue %= 1;

            int quarters = (int)(changeDue / 0.25);
            Console.WriteLine($"Quarters: {quarters}");
            changeDue %= .25;

            int dimes = (int)(changeDue / 0.10);
            Console.WriteLine($"Dimes: {dimes}");
            changeDue %= .10;

            int nickels = (int)(changeDue / 0.05);
            Console.WriteLine($"Nickels: {nickels}");
            changeDue %= .05;

            int pennies = (int)(changeDue / 0.01);
            Console.WriteLine($"Pennies: {pennies}");
            changeDue %= .01;
        }
    }
}
