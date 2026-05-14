#include <iostream>
#include <string>
using namespace std;

int main() {
    int number;
    int originalNumber = 0;
    int checker = 0;
    int container = 0;

    cout << "Palindromic Number" << endl;
    cout << "Enter a number: ";

    if (cin >> number) {
        if (number < 10) {
            cout << "Input error, input number must be greater than 9." << endl;
        } else {
            originalNumber = number;
            while (number > 0) {
                container = number % 10;
                checker = checker * 10 + container;
                number = number / 10;
            }

            if (checker == originalNumber) {
                cout << originalNumber << " is a palindromic number." << endl;
            } else {
                cout << originalNumber << " is not a palindromic number." << endl;
            }
        }
    } else {
        cout << "Invalid input, letters or special symbols are not allowed." << endl;
    }

    return 0;
}
