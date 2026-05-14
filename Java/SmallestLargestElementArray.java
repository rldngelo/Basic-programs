
//SMALLEST AND LARGEST ELEMENT USING ARRAY
import java.util.Scanner;

public class SmallestLargestElementArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Smallest and Largest Element in an Array");
        System.out.print("Enter size of array, [3 - 10] only: ");
        if (scanner.hasNextInt() == true) {
            int size = scanner.nextInt();
            if ((size > 10) || (size < 3)) {
                System.out.println("Input error, input less than 3 or greater than 10 is not not allowed.");
            } else {
                int[] myArray = new int[size];
                System.out.println("Enter the " + size + " elements below");
                for (int index = 0; index < size; index++) {
                    System.out.print("Enter element " + (index + 1) + ": ");
                    if (scanner.hasNextInt() == true) {
                        myArray[index] = scanner.nextInt();
                        if (index == size - 1) {
                            // traverse each element then compare
                            int smallContainer = myArray[0];
                            int bigContainer = myArray[0];
                            for (int counter = 0; counter < size; counter++) {
                                if (myArray[counter] < smallContainer) {
                                    smallContainer = myArray[counter];
                                } else if (myArray[counter] > bigContainer) {
                                    bigContainer = myArray[counter];
                                }
                            }
                            System.out.println(
                                    "Smallest element in array set is " + String.format("%,d", smallContainer) + ".");
                            System.out.println(
                                    "Largest element in array set is " + String.format("%,d", bigContainer) + ".");
                        }
                    } else {
                        System.out
                                .print("Invalid input, please input an integer value in element " + (index + 1) + ".");
                        break;
                    }
                }
            }
        } else {
            System.out.println("Invalid input, letters or special symbols are not allowed.");
        }
    }
}
