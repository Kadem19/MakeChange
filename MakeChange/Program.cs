using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchasePrice = GetAmount("Enter the Purchase Price");

            while (purchasePrice <= 0)
            {
                Console.WriteLine("Please enter a Purchase Price greater than 0!");
                purchasePrice = GetAmount("");
            }

            double paymentAmount = GetAmount("Enter the Payment Amount");

            while (paymentAmount < purchasePrice)
            {
                Console.WriteLine("Oops your payment amount does not cover the purchase Amount. Please try again!");

                purchasePrice = GetAmount("Enter the Purchase Price");


                while (purchasePrice <= 0)
                {
                    Console.WriteLine("Please enter a Purchase Price greater than 0!");
                    purchasePrice = GetAmount("");
                    continue;
                }

                paymentAmount = GetAmount("Enter the Payment Amount");
            }

            if (paymentAmount == purchasePrice)
            {
                Console.WriteLine("Thank you. No change needed!");
            }

            else

            {
                double changeDue;
                changeDue = getChange(paymentAmount, purchasePrice);

                changeDue = CalculateDenomination(changeDue, 20, "Twenties");

                changeDue = CalculateDenomination(changeDue, 10, "Tens");

                changeDue = CalculateDenomination(changeDue, 5, "Fives");

                changeDue = CalculateDenomination(changeDue, 1, "Ones");

                changeDue = CalculateDenomination(changeDue, 0.25, "Quarters");

                changeDue = CalculateDenomination(changeDue, 0.10, "Dimes");

                changeDue = CalculateDenomination(changeDue, 0.05, "Nickels");

                changeDue = CalculateDenomination(changeDue, 0.01, "Pennies");
            }
            
        }


        static double purchaseAmount()
        {
            Console.Write("Purchase Amount: ");
            double purchasePrice;
            purchasePrice = double.Parse(Console.ReadLine());
            return purchasePrice;
        }



        static double GetPaymentAmount()
        {
            Console.Write("Payment Amount: ");
            double paymentAmount;
            paymentAmount = double.Parse(Console.ReadLine());
            return paymentAmount; 
        }



        static double GetAmount(string prompt)
        {
            Console.WriteLine(prompt);
            double amount;
            amount = double.Parse(Console.ReadLine());
            return amount;
        }

        static void ComputeChange(double value1, double value2)
        {
            double changeDue = value1 - value2;
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
        
        static double getChange(double paymentAmount, double purchaseAmount)
        {
            double changeDue = paymentAmount - purchaseAmount;
            Console.WriteLine($"Change Due: ${changeDue}");
            return changeDue;
        }

        static double CalculateDenomination (double changeDue, double denomAmount, string denomTitle)
        {
            int denomName = 0;
            denomName = (int)(changeDue / denomAmount);
            
            if (denomName != 0)
            {
                Console.WriteLine("{0}: {1}", denomTitle, denomName);
                changeDue %= denomAmount;
                Console.WriteLine($"Change Due: ${changeDue}");
            }    
            return changeDue;  
        }
    }
}
