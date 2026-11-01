# Programming Basics — Task 1

Console applications for three exercises, implemented separately in Python and C#:

1. Two-number calculator (with division-by-zero handling)
2. Celsius/Fahrenheit converter
3. Student grade average and pass/fail check

## Run Python

```bash
python Python/calculator.py
python Python/temperature_converter.py
python Python/student_grades.py
```

## Run C#

Requires .NET 8 SDK.

```bash
dotnet run --project CSharp/Calculator
dotnet run --project CSharp/TemperatureConverter
dotnet run --project CSharp/StudentGrades
```

## Example results

- Calculator: 10, 20, + → Result: 30
- Converter: C, 0 → 0 C = 32 F
- Grades: 4 grades (5, 3, 4, 2) → Average: 3.50; The student passed.

## Git branches

To demonstrate branching, create `feature/python-solutions` and `feature/csharp-solutions`, commit the corresponding code in each branch, and merge each through a pull request into `main`. The ZIP is not itself a Git repository and does not include fabricated commit history.

The LaTeX source and compiled PDF are in `Documentation/`.
