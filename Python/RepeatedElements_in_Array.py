print("Repeated Elements in an Array")
size_input = input("Enter size of array, [3 - 10] only: ")

if size_input.lstrip('-').isdigit():
    size = int(size_input)
    if size > 10 or size < 3:
        print("Input error, input number must be from 3 to 10 only.")
    else:
        my_array = []
        print("Input " + str(size) + " elements in the array:")
        valid = True

        for index in range(size):
            element_input = input("Element " + str(index + 1) + ": ")
            if element_input.lstrip('-').isdigit():
                my_array.append(int(element_input))
            else:
                print("Invalid input, please input a numeric value in element " + str(index + 1) + ".")
                valid = False
                break

        if valid:
            count = 0
            for counter_one in range(len(my_array) - 1):
                repeated = False
                for counter_two in range(counter_one):
                    if my_array[counter_one] == my_array[counter_two]:
                        repeated = True
                        break

                if not repeated:
                    for counter_two in range(counter_one + 1, len(my_array)):
                        if my_array[counter_one] == my_array[counter_two]:
                            count += 1
                            break

            print("The number of repeated elements is " + str(count) + ".")
else:
    print("Invalid input, please input a numeric value.")
