//Count the Characters v3

import java.util.Scanner;

public class Characters{
  public int countCharacters(String input, char characterInput){
    int count = 0;
    int length = input.length();
    for(int counter = 0; counter < length; counter++){
      char container= input.charAt(counter);
      char smallContainer = Character.toLowerCase(container);
      char smallCharacter = Character.toLowerCase(characterInput);
      if(smallContainer == smallCharacter){
        count++;
      }
    }
    return count;
  }
  public static void main(String[] args){
    Scanner scanner = new Scanner(System.in);
    Characters characters = new Characters();
    System.out.println("Count the Characters v3");
    System.out.print("Enter a string:");
    String word = scanner.nextLine();
    if(word.equals("")){
      System.out.println("No input, please input a string.");
    } else{
      System.out.print("Enter a character to count in [" + word + "]:");
      String letter = scanner.nextLine();
      if(letter.isEmpty()){
        System.out.println("No input, please input a character to count.");
      } else{
        char finalLetter = letter.charAt(0);
        int result = characters.countCharacters(word, finalLetter);
        System.out.println(letter + " occurs " + result + " times in " + word + ".");
      }
    }
  }
}