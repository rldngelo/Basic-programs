//UGLY NUMBER
import java.util.Scanner;

public class UglyNumber {
    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int number;
        int counter;
        System.out.println("Ugly Number");
        System.out.print("Enter a number: ");
        if (scanner.hasNextInt() == true) {
            number = scanner.nextInt();
            if ((number < 1) || (number > 10000)) {
                System.out.println("Input error, input number less than 1 or greater than 10,000 is not allowed.");
            } else {
                counter = number;
                while (counter != 1) {
                    if (counter % 2 == 0) {
                        while (counter % 2 == 0) {
                            counter /= 2;
                        }
                    } else if (counter % 3 == 0) {
                        while (counter % 3 == 0) {
                            counter /= 3;
                        }
                    } else if (counter % 5 == 0) {
                        while (counter % 5 == 0) {
                            counter /= 5;
                        }
                    } else {
                        System.out.println(String.format("%,d", number) + " is not an ugly number.");
                        break;
                    }
                }
                if (counter == 1) {
                    System.out.println(String.format("%,d", number) + " is an ugly number.");
                }
            }
        } else {
            System.out.println("Invalid input, letters or special symbols are not allowed.");
        }
    }
}