using System;

class LambdaExpressions
{
    static void Main()
    {
        Console.WriteLine("Enter two double values:");

        // Read input from the user
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());

        // Lambda expression to add the numbers
        Func<double, double, double> add = (x, y) => x + y;

        // Lambda expression to multiply the numbers
        Func<double, double, double> multiply = (x, y) => x * y;

        // Lambda statement to compare and return the smaller value
        Func<double, double, double> smallerValue = (x, y) =>
        {
            if (x < y)
                return x;
            else
                return y;
        };

        // Use each lambda expression in Console.WriteLine statements
        Console.WriteLine($"Sum of {number1} and {number2} is: {add(number1, number2)}");
        Console.WriteLine($"Product of {number1} and {number2} is: {multiply(number1, number2)}");
        Console.WriteLine($"Smaller value between {number1} and {number2} is: {smallerValue(number1, number2)}");

        Console.ReadLine();
    }
}
