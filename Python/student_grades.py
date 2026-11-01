try:
    count = int(input("Number of grades: "))
    if count <= 0:
        raise ValueError("Enter at least one grade.")

    total = 0.0
    for index in range(count):
        grade = float(input(f"Grade {index + 1} (1-6): "))
        if not 1 <= grade <= 6:
            raise ValueError("Grades must be between 1 and 6.")
        total += grade

    average = total / count
    print(f"Average: {average:.2f}")
    if average >= 3.0:
        print("The student passed.")
    else:
        print("The student did not pass.")
except ValueError as error:
    print(f"Error: {error}")
