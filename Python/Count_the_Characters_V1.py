def count_characters(characters):
    count_letter = 0
    count_number = 0
    count_special = 0

    for ch in characters:
        if ch.isdigit():
            count_number += 1
        elif ch.isalpha():
            count_letter += 1
        else:
            count_special += 1

    total = count_number + count_letter + count_special
    print("Letter count:", count_letter)
    print("Number count:", count_number)
    print("Special character count:", count_special)
    print("Total number of characters:", total)


print("Count the Characters v1")
user_input = input("Enter a string: ")

if user_input == "":
    print("No input, please input a string.")
else:
    count_characters(user_input)
