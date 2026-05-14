print("Smallest and Largest Element in an Array")
size_input = input("Enter size of array, [3 - 10] only: ")

if size_input.lstrip('-').isdigit():
    size = int(size_input)
    if size > 10 or size < 3:
        print("Input error, input less than 3 or greater than 10 is not allowed.")
    else:
        my_array = []
        print("Enter the " + str(size) + " elements below")

        for index in range(size):
            element_input = input("Enter element " + str(index + 1) + ": ")
            if element_input.lstrip('-').isdigit():
                my_array.append(int(element_input))
                if index == size - 1:
                    small_container = my_array[0]
                    big_container = my_array[0]

                    for counter in range(size):
                        if my_array[counter] < small_container:
                            small_container = my_array[counter]
                        elif my_array[counter] > big_container:
                            big_container = my_array[counter]

                    print("Smallest element in array set is " + f"{small_container:,}" + ".")
                    print("Largest element in array set is " + f"{big_container:,}" + ".")
            else:
                print("Invalid input, please input an integer value in element " + str(index + 1) + ".", end="")
                break
else:
    print("Invalid input, letters or special symbols are not allowed.")
