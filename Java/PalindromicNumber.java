//PALINDROMIC NUMBER

import java.util.Scanner;

public class PalindromicNumber {
  static Scanner scanner = new Scanner(System.in);
  public static void main(String[] args) {
    int number;
    int originalNumber = 0;
    int checker = 0;
    int container = 0;
    System.out.println("Palindromic Number");
    System.out.print("Enter a number: ");
    if (scanner.hasNextInt() == true) {
      number = scanner.nextInt();
      if (number < 10) {
        System.out.println("Input error, input number must be greater than 9.");
      } else {
          originalNumber = number;
          while(number > 0) {
            container = number % 10;
            checker = checker * 10 + container;
            number = number / 10; 
          }
          if (checker == originalNumber) {
            System.out.println(String.format("%,d", originalNumber) + " is a palindromic number.");
          } else {
              System.out.println(String.format("%,d", originalNumber) + " is not a palindromic number.");
        }
      }
    } else {
          System.out.println("Invalid input, letters or special symbols are not allowed.");
    }
  }
}
