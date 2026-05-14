//REPEATED ELEMENTS IN AN ARRAY
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Repeated Elements in an Array");
        System.out.print("Enter size of array, [3 - 10] only: ");
        if (scanner.hasNextInt()) {
            int size = scanner.nextInt();
            if ((size > 10) || (size < 3)) {
                System.out.println("Input error, input number must be from 3 to 10 only.");
            } else {
                int[] myArray = new int[size];
                System.out.println("Input " + size + " elements in the array:");
                for (int index = 0; index < size; index++) {
                    System.out.print("Element " + (index + 1) + ": ");
                    if (scanner.hasNextInt()) {
                        myArray[index] = scanner.nextInt();
                    } else {
                        System.out.println("Invalid input, please input a numeric value in element " + (index + 1) + ".");
                        return;
                    }
                }
                int count = 0;
                for(int counterOne= 0; counterOne< myArray.length - 1; counterOne++){
                    boolean repeated = false;
                    for (int counterTwo = 0; counterTwo < counterOne; counterTwo++){
                        if (myArray[counterOne] == myArray[counterTwo]){ 
                            repeated = true;
                            break; 
                        }
                    }
                    if (!repeated) { 
                        for (int counterTwo = counterOne+ 1; counterTwo < myArray.length; counterTwo++){
                            if (myArray[counterOne] == myArray[counterTwo]){ 
                                count++;
                                break; 
                            }
                        }
                    }
                }
                System.out.println("The number of repeated elements is " + count + ".");
            }
        } else {
            System.out.println("Invalid input, please input a numeric value.");
        }
    }
}