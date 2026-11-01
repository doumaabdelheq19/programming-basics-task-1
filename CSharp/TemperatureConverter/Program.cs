using System;
using System.Globalization;

Console.Write("Convert from C or F? ");
string direction = (Console.ReadLine() ?? "").Trim().ToUpper();
if (direction != "C" && direction != "F")
{
    Console.WriteLine("Error: Choose C or F.");
    return;
}
Console.Write("Temperature: ");
if (!double.TryParse(Console.ReadLine(), NumberStyles.Float,
    CultureInfo.InvariantCulture, out double temperature))
{
    Console.WriteLine("Error: Invalid temperature.");
    return;
}
if (direction == "C")
{
    double fahrenheit = temperature * 1.8 + 32;
    Console.WriteLine($"{temperature:G} C = {fahrenheit:G} F");
}
else
{
    double celsius = (temperature - 32) / 1.8;
    Console.WriteLine($"{temperature:G} F = {celsius:G} C");
}
