def count_characters(characters):
    count_vowels = 0
    count_consonants = 0
    count_number = 0
    count_special = 0
    white_space = 0

    for ch in characters:
        if ch.isdigit():
            count_number += 1
        elif ch.isalpha():
            if ch.upper() in 'AEIOU':
                count_vowels += 1
            else:
                count_consonants += 1
        elif ch.isspace():
            white_space += 1
        else:
            count_special += 1

    total = count_number + count_vowels + count_consonants + white_space + count_special
    print("Number of vowels:", count_vowels)
    print("Number of consonants:", count_consonants)
    print("Number of digits:", count_number)
    print("Number of white spaces:", white_space)
    print("Number of special characters:", count_special)
    print("Total number of characters:", total)


print("Count the Characters v2")
user_input = input("Enter a string: ")

if user_input == "":
    print("No input, please input a string.")
else:
    count_characters(user_input)
