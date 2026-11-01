using System;
using System.Globalization;

Console.Write("First number: ");
bool firstOk = double.TryParse(Console.ReadLine(),
    NumberStyles.Float, CultureInfo.InvariantCulture, out double a);
Console.Write("Second number: ");
bool secondOk = double.TryParse(Console.ReadLine(),
    NumberStyles.Float, CultureInfo.InvariantCulture, out double b);
Console.Write("Operation (+, -, *, /): ");
string op = Console.ReadLine()?.Trim() ?? "";

if (!firstOk || !secondOk)
{
    Console.WriteLine("Error: Invalid number.");
}
else if (op == "/" && b == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
}
else
{
    double result;
    if (op == "+") result = a + b;
    else if (op == "-") result = a - b;
    else if (op == "*") result = a * b;
    else if (op == "/") result = a / b;
    else
    {
        Console.WriteLine("Error: Unknown operation.");
        return;
    }
    Console.WriteLine($"Result: {result:G}");
}
