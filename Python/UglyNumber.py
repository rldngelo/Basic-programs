print("Ugly Number")
input_str = input("Enter a number: ")

if input_str.lstrip('-').isdigit():
    number = int(input_str)
    if number < 1 or number > 10000:
        print("Input error, input number less than 1 or greater than 10,000 is not allowed.")
    else:
        counter = number
        ugly = True
        while counter != 1:
            if counter % 2 == 0:
                while counter % 2 == 0:
                    counter //= 2
            elif counter % 3 == 0:
                while counter % 3 == 0:
                    counter //= 3
            elif counter % 5 == 0:
                while counter % 5 == 0:
                    counter //= 5
            else:
                print(f"{number:,} is not an ugly number.")
                ugly = False
                break

        if ugly and counter == 1:
            print(f"{number:,} is an ugly number.")
else:
    print("Invalid input, letters or special symbols are not allowed.")
