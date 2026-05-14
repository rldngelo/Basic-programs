using System;

class Characters
{
    public int CountCharacters(string input, char characterInput)
    {
        int count = 0;
        int length = input.Length;

        for (int counter = 0; counter < length; counter++)
        {
            char container = input[counter];
            char smallContainer = char.ToLower(container);
            char smallCharacter = char.ToLower(characterInput);
            if (smallContainer == smallCharacter)
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Characters characters = new Characters();
        Console.WriteLine("Count the Characters v3");
        Console.Write("Enter a string:");
        string word = Console.ReadLine();

        if (word == "")
        {
            Console.WriteLine("No input, please input a string.");
        }
        else
        {
            Console.Write("Enter a character to count in [" + word + "]:");
            string letter = Console.ReadLine();

            if (string.IsNullOrEmpty(letter))
            {
                Console.WriteLine("No input, please input a character to count.");
            }
            else
            {
                char finalLetter = letter[0];
                int result = characters.CountCharacters(word, finalLetter);
                Console.WriteLine(letter + " occurs " + result + " times in " + word + ".");
            }
        }
    }
}
