//TUITION

import java.util.*;

public class Tuition {
    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int modeOfPayment;
        float tuitionFee;
        float fullPayment;
        float installmentA;
        float installmentB;

        System.out.println("Tuition");
        System.out.print("Enter tuition: ");
        tuitionFee = scanner.nextFloat();

        if (tuitionFee < 5000) {
            System.out.println("Input error, amount less than 5,000 pesos is not allowed.");
        } else {
            System.out.println("Mode of payment");
            System.out.println("[1] Full payment - 20% Discount");
            System.out.println("[2] Installment A - 5% Interest");
            System.out.println("[3] Installment B - 10% Interest");
            System.out.print("Enter mode of payment: ");
            modeOfPayment = scanner.nextInt();

            switch (modeOfPayment) {
                case 1:
                    fullPayment = tuitionFee - (tuitionFee * 0.20f);
                    System.out.println("The tuition to pay is " + String.format("%.2f", fullPayment) + " pesos.");
                    break;
                case 2:
                    installmentA = tuitionFee * 1.05f;
                    System.out.println("The tuition to pay is " + String.format("%.2f", installmentA) + " pesos.");
                    break;
                case 3:
                    installmentB = tuitionFee * 1.10f;
                    System.out.println("The tuition to pay is " + String.format("%.2f", installmentB) + " pesos.");
                    break;
                default:
                    System.out.println("Input error, please input from 1 - 3 only.");
            }
        }
    }
}
