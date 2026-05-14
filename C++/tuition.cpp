#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int modeOfPayment;
    float tuitionFee;
    float result;

    cout << "Tuition" << endl;
    cout << "Enter tuition: ";
    cin >> tuitionFee;

    if (tuitionFee < 5000) {
        cout << "Input error, amount less than 5,000 pesos is not allowed." << endl;
    } else {
        cout << "Mode of payment" << endl;
        cout << "[1] Full payment - 20% Discount" << endl;
        cout << "[2] Installment A - 5% Interest" << endl;
        cout << "[3] Installment B - 10% Interest" << endl;
        cout << "Enter mode of payment: ";
        cin >> modeOfPayment;

        switch (modeOfPayment) {
            case 1:
                result = tuitionFee - (tuitionFee * 0.20f);
                cout << fixed << setprecision(2) << "The tuition to pay is " << result << " pesos." << endl;
                break;
            case 2:
                result = tuitionFee * 1.05f;
                cout << fixed << setprecision(2) << "The tuition to pay is " << result << " pesos." << endl;
                break;
            case 3:
                result = tuitionFee * 1.10f;
                cout << fixed << setprecision(2) << "The tuition to pay is " << result << " pesos." << endl;
                break;
            default:
                cout << "Input error, please input from 1 - 3 only." << endl;
        }
    }

    return 0;
}
