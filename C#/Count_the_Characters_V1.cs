using System;

class Main
{
    static void CountCharacters(string characters)
    {
        int size = characters.Length;
        int countLetter = 0;
        int countNumber = 0;
        int countSpecial = 0;
        int total = 0;
        char input;

        for (int counter = 0; counter < size; counter++)
        {
            input = characters[counter];
            if (char.IsDigit(input))
            {
                countNumber++;
            }
            else if (char.IsLetter(input))
            {
                countLetter++;
            }
            else
            {
                countSpecial++;
            }
        }

        total = countNumber + countLetter + countSpecial;
        Console.WriteLine("Letter count: " + countLetter);
        Console.WriteLine("Number count: " + countNumber);
        Console.WriteLine("Special character count: " + countSpecial);
        Console.WriteLine("Total number of characters: " + total);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Count the Characters v1");
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("No input, please input a string.");
        }
        else
        {
            CountCharacters(userInput);
        }
    }
}
