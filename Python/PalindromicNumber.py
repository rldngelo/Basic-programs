print("Palindromic Number")
input_str = input("Enter a number: ")

if input_str.lstrip('-').isdigit():
    number = int(input_str)
    if number < 10:
        print("Input error, input number must be greater than 9.")
    else:
        original_number = number
        checker = 0
        while number > 0:
            container = number % 10
            checker = checker * 10 + container
            number = number // 10

        if checker == original_number:
            print(f"{original_number:,} is a palindromic number.")
        else:
            print(f"{original_number:,} is not a palindromic number.")
else:
    print("Invalid input, letters or special symbols are not allowed.")
