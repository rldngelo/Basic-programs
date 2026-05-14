//JACKENPOY

import java.util.Scanner;

public class JackEnPoy {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    System.out.println("Jack 'en Poy");
    System.out.println("Select your option");
    System.out.println("[1] Paper");
    System.out.println("[2] Rock");
    System.out.println("[3] Scissor");

    System.out.print("Player one input: ");
    if (scanner.hasNextInt() == true) {
      int playerOne = scanner.nextInt();
      if (playerOne >= 1 && playerOne <= 3) {
        System.out.print("Player two input: ");
        if (scanner.hasNextInt() == true) {
          int playerTwo = scanner.nextInt();
          if (playerTwo >= 1 && playerTwo <= 3) {
            if ((playerOne == 1 && playerTwo == 2)
                || (playerOne == 2 && playerTwo == 3)
                || (playerOne == 3 && playerTwo == 1)) {
              System.out.println("Player one wins.");
            } else {
              System.out.println("Player two wins.");
            }
          } else if (playerTwo < 0) {
            System.out.println("Input error, please enter a correct player two input.");
          }
        } else {
          System.out.println("Invalid input, letters or special characters are not allowed.");
        }
      } else {
        System.out.println("Input error, please enter a correct player one input.");
      }
    } else {
      System.out.println("Invalid input, letters or special characters are not allowed.");
    }
  }
}