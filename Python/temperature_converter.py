try:
    direction = input("Convert from C or F? ").strip().upper()
    if direction not in ("C", "F"):
        raise ValueError("Choose C or F.")
    temperature = float(input("Temperature: "))

    if direction == "C":
        converted = temperature * 1.8 + 32
        print(f"{temperature:g} C = {converted:g} F")
    else:
        converted = (temperature - 32) / 1.8
        print(f"{temperature:g} F = {converted:g} C")
except ValueError as error:
    print(f"Error: {error}")
