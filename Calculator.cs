using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0.0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
