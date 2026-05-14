using System;

class Main
{
    static void CountCharacters(string characters)
    {
        int size = characters.Length;
        int countVowels = 0;
        int countConsonants = 0;
        int countNumber = 0;
        int countSpecial = 0;
        int whiteSpace = 0;
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
                input = char.ToUpper(input);
                if (input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
                {
                    countVowels++;
                }
                else
                {
                    countConsonants++;
                }
            }
            else if (char.IsWhiteSpace(input))
            {
                whiteSpace++;
            }
            else
            {
                countSpecial++;
            }
        }

        total = countNumber + countVowels + countConsonants + whiteSpace + countSpecial;
        Console.WriteLine("Number of vowels: " + countVowels);
        Console.WriteLine("Number of consonants: " + countConsonants);
        Console.WriteLine("Number of digits: " + countNumber);
        Console.WriteLine("Number of white spaces: " + whiteSpace);
        Console.WriteLine("Number of special characters: " + countSpecial);
        Console.WriteLine("Total number of characters: " + total);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Count the Characters v2");
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
