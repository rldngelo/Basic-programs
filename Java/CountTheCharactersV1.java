//COUNT THE CHARACTERS V1

import java.util.Scanner;

public class CountTheCharactersV1 {
  public static void countCharacters(String characters) {
    int size = characters.length();
    int countLetter = 0;
    int countNumber = 0;
    int countSpecial = 0;
    int total = 0;
    char input;
    for (int counter = 0; counter < size; counter++) {
      input = characters.charAt(counter);
      if (Character.isDigit(input) == true) {
        countNumber++;
      } else if (Character.isLetter(input) == true) {
        countLetter++;
      } else {
        countSpecial++;
      }
    }
    total = countNumber + countLetter + countSpecial;
    System.out.println("Letter count: " + countLetter);
    System.out.println("Number count: " + countNumber);
    System.out.println("Special character count: " + countSpecial);
    System.out.println("Total number of characters: " + total);
  }

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    System.out.println("Count the Characters v1");
    System.out.print("Enter a string: ");
    String userInput = scanner.nextLine();
    if (userInput.equals("")) {
      System.out.println("No input, please input a string.");
    } else {
      countCharacters(userInput);
    }
    scanner.close();
  }
}