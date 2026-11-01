using System;
using System.Globalization;

Console.Write("Number of grades: ");
if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
{
    Console.WriteLine("Error: Enter a positive number of grades.");
    return;
}
double total = 0;
for (int i = 0; i < count; i++)
{
    Console.Write($"Grade {i + 1} (1-6): ");
    if (!double.TryParse(Console.ReadLine(), NumberStyles.Float,
        CultureInfo.InvariantCulture, out double grade) ||
        grade < 1 || grade > 6)
    {
        Console.WriteLine("Error: Grades must be between 1 and 6.");
        return;
    }
    total += grade;
}
double average = total / count;
Console.WriteLine($"Average: {average:F2}");
if (average >= 3.0)
    Console.WriteLine("The student passed.");
else
    Console.WriteLine("The student did not pass.");
