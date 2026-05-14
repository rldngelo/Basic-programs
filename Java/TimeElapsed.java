//TIME ELAPSED

import java.util.*;

public class TimeElapsed {
    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        int hours;
        int minutes;
        int seconds;
        int convertedTime;
        System.out.println("Time Elapsed");
        System.out.print("Enter time in hours (0-24): ");
        if (scanner.hasNextInt() == true){
            hours = scanner.nextInt();
            if ((hours < 0) || (hours > 24)) {
                System.out.println("Input error, please input a correct hours value.");
            } else if(hours == 24) {
                System.out.println("The equivalent time in seconds is 86,400.");
            }
            else {
                System.out.print("Enter time in minutes (0-60): ");
                if(scanner.hasNextInt() == true) {
                    minutes = scanner.nextInt();
                    {
                        if((minutes < 0) || (minutes > 60) || (hours + minutes == 84)){
                            System.out.println("Input error, please input a correct minutes value.");
                        } else if(hours + minutes == 83) {
                            System.out.println("The equivalent time in seconds is 86,400.");
                        } else {
                            System.out.print("Enter time in seconds (0-60): ");
                            if(scanner.hasNextInt() == true) {
                                seconds = scanner.nextInt();
                                if((seconds < 0) || (seconds > 60) || (hours * 3600 + minutes * 60 + seconds > 86400)) {
                                    System.out.println("Input error, please input a correct seconds value.");
                                }
                                else{
                                    convertedTime = hours * 3600 + minutes * 60 + seconds;
                                    System.out.println("The equivalent time in seconds is " + String.format("%,d", convertedTime) + ".");
                                }
                            } 
                            else {
                                System.out.println("Invalid input, letters or special characters for seconds are not allowed.");
                            }

                        }
                    }
                } else {
                    System.out.println("Invalid input, letters or special characters for minutes are not allowed.");
                }
            }

        } else {
            System.out.println("Invalid input, letters or special characters for hours are not allowed.");
        }
    }
}
