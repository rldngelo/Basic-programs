using System;

class UglyNumber
{
    static void Main(string[] args)
    {
        int number;
        int counter;

        Console.WriteLine("Ugly Number");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            if (number < 1 || number > 10000)
            {
                Console.WriteLine("Input error, input number less than 1 or greater than 10,000 is not allowed.");
            }
            else
            {
                counter = number;
                while (counter != 1)
                {
                    if (counter % 2 == 0)
                    {
                        while (counter % 2 == 0)
                        {
                            counter /= 2;
                        }
                    }
                    else if (counter % 3 == 0)
                    {
                        while (counter % 3 == 0)
                        {
                            counter /= 3;
                        }
                    }
                    else if (counter % 5 == 0)
                    {
                        while (counter % 5 == 0)
                        {
                            counter /= 5;
                        }
                    }
                    else
                    {
                        Console.WriteLine(number.ToString("N0") + " is not an ugly number.");
                        break;
                    }
                }

                if (counter == 1)
                {
                    Console.WriteLine(number.ToString("N0") + " is an ugly number.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input, letters or special symbols are not allowed.");
        }
    }
}
