#include <iostream>
using namespace std;

int main() {
    int number;
    int abundantNumber;
    int divisor = 0;

    cout << "Abundant Number" << endl;
    cout << "Enter a number:";

    if (cin >> number) {
        if (number <= 0) {
            cout << "Input error, zero or negative number input is not allowed." << endl;
        } else {
            for (int counter = 1; counter <= number; counter++) {
                if (number % counter == 0) {
                    divisor = divisor + counter;
                    if (counter == number) {
                        if (number * 2 < divisor) {
                            abundantNumber = divisor - 2 * number;
                            cout << number << " is an abundant number." << endl;
                            cout << "The abundance is " << abundantNumber << "." << endl;
                        } else {
                            cout << number << " is not an abundant number." << endl;
                        }
                    }
                }
            }
        }
    } else {
        cout << "Invalid input, letters or special symbols are not allowed." << endl;
    }

    return 0;
}
