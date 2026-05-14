print("Tuition")
tuition_fee = float(input("Enter tuition: "))

if tuition_fee < 5000:
    print("Input error, amount less than 5,000 pesos is not allowed.")
else:
    print("Mode of payment")
    print("[1] Full payment - 20% Discount")
    print("[2] Installment A - 5% Interest")
    print("[3] Installment B - 10% Interest")
    mode_of_payment = int(input("Enter mode of payment: "))

    if mode_of_payment == 1:
        full_payment = tuition_fee - (tuition_fee * 0.20)
        print("The tuition to pay is " + f"{full_payment:.2f}" + " pesos.")
    elif mode_of_payment == 2:
        installment_a = tuition_fee * 1.05
        print("The tuition to pay is " + f"{installment_a:.2f}" + " pesos.")
    elif mode_of_payment == 3:
        installment_b = tuition_fee * 1.10
        print("The tuition to pay is " + f"{installment_b:.2f}" + " pesos.")
    else:
        print("Input error, please input from 1 - 3 only.")
