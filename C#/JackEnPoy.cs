using System;

class Jackenpoy
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jack 'en Poy");
        Console.WriteLine("Select your option");
        Console.WriteLine("[1] Paper");
        Console.WriteLine("[2] Rock");
        Console.WriteLine("[3] Scissor");

        Console.Write("Player one input: ");
        string inputOne = Console.ReadLine();

        if (int.TryParse(inputOne, out int playerOne))
        {
            if (playerOne >= 1 && playerOne <= 3)
            {
                Console.Write("Player two input: ");
                string inputTwo = Console.ReadLine();

                if (int.TryParse(inputTwo, out int playerTwo))
                {
                    if (playerTwo >= 1 && playerTwo <= 3)
                    {
                        if ((playerOne == 1 && playerTwo == 2)
                            || (playerOne == 2 && playerTwo == 3)
                            || (playerOne == 3 && playerTwo == 1))
                        {
                            Console.WriteLine("Player one wins.");
                        }
                        else
                        {
                            Console.WriteLine("Player two wins.");
                        }
                    }
                    else if (playerTwo < 0)
                    {
                        Console.WriteLine("Input error, please enter a correct player two input.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, letters or special characters are not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Input error, please enter a correct player one input.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, letters or special characters are not allowed.");
        }
    }
}
