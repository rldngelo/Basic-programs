using System;

class Main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Repeated Elements in an Array");
        Console.Write("Enter size of array, [3 - 10] only: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int size))
        {
            if (size > 10 || size < 3)
            {
                Console.WriteLine("Input error, input number must be from 3 to 10 only.");
            }
            else
            {
                int[] myArray = new int[size];
                Console.WriteLine("Input " + size + " elements in the array:");

                for (int index = 0; index < size; index++)
                {
                    Console.Write("Element " + (index + 1) + ": ");
                    string elementInput = Console.ReadLine();

                    if (int.TryParse(elementInput, out int element))
                    {
                        myArray[index] = element;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please input a numeric value in element " + (index + 1) + ".");
                        return;
                    }
                }

                int count = 0;
                for (int counterOne = 0; counterOne < myArray.Length - 1; counterOne++)
                {
                    bool repeated = false;
                    for (int counterTwo = 0; counterTwo < counterOne; counterTwo++)
                    {
                        if (myArray[counterOne] == myArray[counterTwo])
                        {
                            repeated = true;
                            break;
                        }
                    }

                    if (!repeated)
                    {
                        for (int counterTwo = counterOne + 1; counterTwo < myArray.Length; counterTwo++)
                        {
                            if (myArray[counterOne] == myArray[counterTwo])
                            {
                                count++;
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine("The number of repeated elements is " + count + ".");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please input a numeric value.");
        }
    }
}
