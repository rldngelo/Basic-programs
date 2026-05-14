def count_characters(input_str, character_input):
    count = 0
    for ch in input_str:
        if ch.lower() == character_input.lower():
            count += 1
    return count


print("Count the Characters v3")
word = input("Enter a string:")

if word == "":
    print("No input, please input a string.")
else:
    letter = input("Enter a character to count in [" + word + "]:")
    if letter == "":
        print("No input, please input a character to count.")
    else:
        final_letter = letter[0]
        result = count_characters(word, final_letter)
        print(letter + " occurs " + str(result) + " times in " + word + ".")
