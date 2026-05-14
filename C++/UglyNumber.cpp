#include <iostream>
using namespace std;

int main() {
    int number;
    int counter;

    cout << "Ugly Number" << endl;
    cout << "Enter a number: ";

    if (cin >> number) {
        if (number < 1 || number > 10000) {
            cout << "Input error, input number less than 1 or greater than 10,000 is not allowed." << endl;
        } else {
            counter = number;
            while (counter != 1) {
                if (counter % 2 == 0) {
                    while (counter % 2 == 0) {
                        counter /= 2;
                    }
                } else if (counter % 3 == 0) {
                    while (counter % 3 == 0) {
                        counter /= 3;
                    }
                } else if (counter % 5 == 0) {
                    while (counter % 5 == 0) {
                        counter /= 5;
                    }
                } else {
                    cout << number << " is not an ugly number." << endl;
                    break;
                }
            }

            if (counter == 1) {
                cout << number << " is an ugly number." << endl;
            }
        }
    } else {
        cout << "Invalid input, letters or special symbols are not allowed." << endl;
    }

    return 0;
}
