//Count the Characters v2

import java.util.Scanner;

public class Main {
  public static void countCharacters (String characters){
    int size = characters.length();
    int countVowels = 0;
    int countConsonants = 0;
    int countNumber = 0;
    int countSpecial = 0;
    int whiteSpace = 0;
    int total = 0;
    char input;
    for(int counter = 0; counter < size; counter++){
      input = characters.charAt(counter);
      if(Character.isDigit(input) == true){
        countNumber++;
      } else if(Character.isLetter(input) == true){
          input = Character.toUpperCase(input);
          if(input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U'){
            countVowels++;
          }else{
            countConsonants++;
          }
      } else if(Character.isWhitespace(input)){
          whiteSpace++;
      } else{
        countSpecial++;
      }
    }
    total = countNumber + countVowels + countConsonants + whiteSpace + countSpecial;
    System.out.println("Number of vowels: " + countVowels);
    System.out.println("Number of consonants: " + countConsonants);
    System.out.println("Number of digits: " + countNumber);
    System.out.println("Number of white spaces: " + whiteSpace);
    System.out.println("Number of special characters: " + countSpecial);
    System.out.println("Total number of characters: " + total);
  }
  public static void main(String[] args){
    Scanner scanner = new Scanner(System.in);
    System.out.println("Count the Characters v2");
    System.out.print("Enter a string: ");
    String userInput = scanner.nextLine();
    if(userInput.equals("")){
      System.out.println("No input, please input a string.");
    } else {
      countCharacters(userInput);
    }
    scanner.close();
  }
}