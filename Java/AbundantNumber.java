//ABUNDANT NUMBER
import java.util.Scanner;

public class AbundantNumber {
    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        int number;
        int abundantNumber;
        int divisor = 0;
        System.out.println("Abundant Number");
        System.out.print("Enter a number:");
        if (scanner.hasNextInt() == true) {
            number = scanner.nextInt();
            if (number <= 0) {
                System.out.println("Input error, zero or negative number input is not allowed.");
            } else {
                for (int counter = 1; counter <= number; counter++) {
                    if (number % counter == 0 ) {
                        divisor = divisor + counter;
                        if(counter == number) {
                            if(number * 2 < divisor) {
                                abundantNumber = divisor - 2 * number;
                                System.out.println(number + " is an abundant number.");
                                System.out.println("The abundance is " + String.format("%,d", abundantNumber) + ".");
                            } else {
                                System.out.println(String.format("%,d", number) + " is not an abundant number.");
                            }
                        }
                    } 
                }
            }
        } else {
            System.out.println("Invalid input, letters or special symbols are not allowed.");
        }
    }
}
