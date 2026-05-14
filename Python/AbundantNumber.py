print("Abundant Number")
input_str = input("Enter a number:")

if input_str.lstrip('-').isdigit():
    number = int(input_str)
    if number <= 0:
        print("Input error, zero or negative number input is not allowed.")
    else:
        divisor = 0
        for counter in range(1, number + 1):
            if number % counter == 0:
                divisor += counter
                if counter == number:
                    if number * 2 < divisor:
                        abundant_number = divisor - 2 * number
                        print(str(number) + " is an abundant number.")
                        print("The abundance is " + f"{abundant_number:,}" + ".")
                    else:
                        print(f"{number:,} is not an abundant number.")
else:
    print("Invalid input, letters or special symbols are not allowed.")
