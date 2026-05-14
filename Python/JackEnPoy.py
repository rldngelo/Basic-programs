print("Jack 'en Poy")
print("Select your option")
print("[1] Paper")
print("[2] Rock")
print("[3] Scissor")

player_one_input = input("Player one input: ")

if player_one_input.lstrip('-').isdigit():
    player_one = int(player_one_input)
    if player_one >= 1 and player_one <= 3:
        player_two_input = input("Player two input: ")
        if player_two_input.lstrip('-').isdigit():
            player_two = int(player_two_input)
            if player_two >= 1 and player_two <= 3:
                if ((player_one == 1 and player_two == 2)
                        or (player_one == 2 and player_two == 3)
                        or (player_one == 3 and player_two == 1)):
                    print("Player one wins.")
                else:
                    print("Player two wins.")
            elif player_two < 0:
                print("Input error, please enter a correct player two input.")
        else:
            print("Invalid input, letters or special characters are not allowed.")
    else:
        print("Input error, please enter a correct player one input.")
else:
    print("Invalid input, letters or special characters are not allowed.")
