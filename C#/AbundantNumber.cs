using System;

class AbundantNumber
{
    static void Main(string[] args)
    {
        int number;
        int abundantNumber;
        int divisor = 0;

        Console.WriteLine("Abundant Number");
        Console.Write("Enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            if (number <= 0)
            {
                Console.WriteLine("Input error, zero or negative number input is not allowed.");
            }
            else
            {
                for (int counter = 1; counter <= number; counter++)
                {
                    if (number % counter == 0)
                    {
                        divisor = divisor + counter;

                        if (counter == number)
                        {
                            if (number * 2 < divisor)
                            {
                                abundantNumber = divisor - 2 * number;
                                Console.WriteLine(number + " is an abundant number.");
                                Console.WriteLine("The abundance is " + abundantNumber.ToString("N0") + ".");
                            }
                            else
                            {
                                Console.WriteLine(number.ToString("N0") + " is not an abundant number.");
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input, letters or special symbols are not allowed.");
        }
    }
}
