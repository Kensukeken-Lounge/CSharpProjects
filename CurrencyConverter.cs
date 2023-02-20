using System;

class CurrencyConverter {
    static void Main() {
        Console.WriteLine("Welcome to Currency Converter");

        // Exchange rates
        const double USD_TO_EUR = 0.83;
        const double USD_TO_GBP = 0.72;
        const double USD_TO_JPY = 105.20;

        // Get user input
        Console.Write("Enter amount in USD: ");
        double usdAmount = double.Parse(Console.ReadLine());

        // Convert USD to other currencies
        double eurAmount = usdAmount * USD_TO_EUR;
        double gbpAmount = usdAmount * USD_TO_GBP;
        double jpyAmount = usdAmount * USD_TO_JPY;

        // Display results
        Console.WriteLine($"{usdAmount:C} is equivalent to:");
        Console.WriteLine($"{eurAmount:C} EUR");
        Console.WriteLine($"{gbpAmount:C} GBP");
        Console.WriteLine($"{jpyAmount:C} JPY");
    }
}
