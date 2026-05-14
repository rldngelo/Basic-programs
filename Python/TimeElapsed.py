print("Time Elapsed")
hours_input = input("Enter time in hours (0-24): ")

if hours_input.lstrip('-').isdigit():
    hours = int(hours_input)
    if hours < 0 or hours > 24:
        print("Input error, please input a correct hours value.")
    elif hours == 24:
        print("The equivalent time in seconds is 86,400.")
    else:
        minutes_input = input("Enter time in minutes (0-60): ")
        if minutes_input.lstrip('-').isdigit():
            minutes = int(minutes_input)
            if minutes < 0 or minutes > 60 or hours + minutes == 84:
                print("Input error, please input a correct minutes value.")
            elif hours + minutes == 83:
                print("The equivalent time in seconds is 86,400.")
            else:
                seconds_input = input("Enter time in seconds (0-60): ")
                if seconds_input.lstrip('-').isdigit():
                    seconds = int(seconds_input)
                    if seconds < 0 or seconds > 60 or hours * 3600 + minutes * 60 + seconds > 86400:
                        print("Input error, please input a correct seconds value.")
                    else:
                        converted_time = hours * 3600 + minutes * 60 + seconds
                        print("The equivalent time in seconds is " + f"{converted_time:,}" + ".")
                else:
                    print("Invalid input, letters or special characters for seconds are not allowed.")
        else:
            print("Invalid input, letters or special characters for minutes are not allowed.")
else:
    print("Invalid input, letters or special characters for hours are not allowed.")
