using System;

class TimeElapsed
{
    static void Main(string[] args)
    {
        int hours;
        int minutes;
        int seconds;
        int convertedTime;

        Console.WriteLine("Time Elapsed");
        Console.Write("Enter time in hours (0-24): ");
        string inputHours = Console.ReadLine();

        if (int.TryParse(inputHours, out hours))
        {
            if (hours < 0 || hours > 24)
            {
                Console.WriteLine("Input error, please input a correct hours value.");
            }
            else if (hours == 24)
            {
                Console.WriteLine("The equivalent time in seconds is 86,400.");
            }
            else
            {
                Console.Write("Enter time in minutes (0-60): ");
                string inputMinutes = Console.ReadLine();

                if (int.TryParse(inputMinutes, out minutes))
                {
                    if (minutes < 0 || minutes > 60 || hours + minutes == 84)
                    {
                        Console.WriteLine("Input error, please input a correct minutes value.");
                    }
                    else if (hours + minutes == 83)
                    {
                        Console.WriteLine("The equivalent time in seconds is 86,400.");
                    }
                    else
                    {
                        Console.Write("Enter time in seconds (0-60): ");
                        string inputSeconds = Console.ReadLine();

                        if (int.TryParse(inputSeconds, out seconds))
                        {
                            if (seconds < 0 || seconds > 60 || hours * 3600 + minutes * 60 + seconds > 86400)
                            {
                                Console.WriteLine("Input error, please input a correct seconds value.");
                            }
                            else
                            {
                                convertedTime = hours * 3600 + minutes * 60 + seconds;
                                Console.WriteLine("The equivalent time in seconds is " + convertedTime.ToString("N0") + ".");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, letters or special characters for seconds are not allowed.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, letters or special characters for minutes are not allowed.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input, letters or special characters for hours are not allowed.");
        }
    }
}
