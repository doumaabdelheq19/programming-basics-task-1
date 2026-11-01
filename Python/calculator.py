try:
    first = float(input("First number: "))
    second = float(input("Second number: "))
    operator = input("Operation (+, -, *, /): ").strip()

    if operator == "+":
        result = first + second
    elif operator == "-":
        result = first - second
    elif operator == "*":
        result = first * second
    elif operator == "/":
        if second == 0:
            raise ZeroDivisionError("Cannot divide by zero.")
        result = first / second
    else:
        raise ValueError("Unknown operation.")

    print(f"Result: {result:g}")
except (ValueError, ZeroDivisionError) as error:
    print(f"Error: {error}")
