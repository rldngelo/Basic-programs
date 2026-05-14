using System;

class Tuition
{
    static void Main(string[] args)
    {
        int modeOfPayment;
        float tuitionFee;
        float fullPayment;
        float installmentA;
        float installmentB;

        Console.WriteLine("Tuition");
        Console.Write("Enter tuition: ");
        tuitionFee = float.Parse(Console.ReadLine());

        if (tuitionFee < 5000)
        {
            Console.WriteLine("Input error, amount less than 5,000 pesos is not allowed.");
        }
        else
        {
            Console.WriteLine("Mode of payment");
            Console.WriteLine("[1] Full payment - 20% Discount");
            Console.WriteLine("[2] Installment A - 5% Interest");
            Console.WriteLine("[3] Installment B - 10% Interest");
            Console.Write("Enter mode of payment: ");
            modeOfPayment = int.Parse(Console.ReadLine());

            switch (modeOfPayment)
            {
                case 1:
                    fullPayment = tuitionFee - (tuitionFee * 0.20f);
                    Console.WriteLine("The tuition to pay is " + fullPayment.ToString("F2") + " pesos.");
                    break;
                case 2:
                    installmentA = tuitionFee * 1.05f;
                    Console.WriteLine("The tuition to pay is " + installmentA.ToString("F2") + " pesos.");
                    break;
                case 3:
                    installmentB = tuitionFee * 1.10f;
                    Console.WriteLine("The tuition to pay is " + installmentB.ToString("F2") + " pesos.");
                    break;
                default:
                    Console.WriteLine("Input error, please input from 1 - 3 only.");
                    break;
            }
        }
    }
}
