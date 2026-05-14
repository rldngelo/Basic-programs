using System;

class ArrayFinal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smallest and Largest Element in an Array");
        Console.Write("Enter size of array, [3 - 10] only: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int size))
        {
            if (size > 10 || size < 3)
            {
                Console.WriteLine("Input error, input less than 3 or greater than 10 is not allowed.");
            }
            else
            {
                int[] myArray = new int[size];
                Console.WriteLine("Enter the " + size + " elements below");

                for (int index = 0; index < size; index++)
                {
                    Console.Write("Enter element " + (index + 1) + ": ");
                    string elementInput = Console.ReadLine();

                    if (int.TryParse(elementInput, out int element))
                    {
                        myArray[index] = element;

                        if (index == size - 1)
                        {
                            int smallContainer = myArray[0];
                            int bigContainer = myArray[0];

                            for (int counter = 0; counter < size; counter++)
                            {
                                if (myArray[counter] < smallContainer)
                                {
                                    smallContainer = myArray[counter];
                                }
                                else if (myArray[counter] > bigContainer)
                                {
                                    bigContainer = myArray[counter];
                                }
                            }

                            Console.WriteLine("Smallest element in array set is " + smallContainer.ToString("N0") + ".");
                            Console.WriteLine("Largest element in array set is " + bigContainer.ToString("N0") + ".");
                        }
                    }
                    else
                    {
                        Console.Write("Invalid input, please input an integer value in element " + (index + 1) + ".");
                        break;
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
