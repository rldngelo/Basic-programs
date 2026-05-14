using System;

class PalindromicNumber
{
    static void Main(string[] args)
    {
        int number;
        int originalNumber = 0;
        int checker = 0;
        int container = 0;

        Console.WriteLine("Palindromic Number");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            if (number < 10)
            {
                Console.WriteLine("Input error, input number must be greater than 9.");
            }
            else
            {
                originalNumber = number;
                while (number > 0)
                {
                    container = number % 10;
                    checker = checker * 10 + container;
                    number = number / 10;
                }

                if (checker == originalNumber)
                {
                    Console.WriteLine(originalNumber.ToString("N0") + " is a palindromic number.");
                }
                else
                {
                    Console.WriteLine(originalNumber.ToString("N0") + " is not a palindromic number.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input, letters or special symbols are not allowed.");
        }
    }
}
