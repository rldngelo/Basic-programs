#include <iostream>
#include <string>
using namespace std;

int main() {
    cout << "Jack 'en Poy" << endl;
    cout << "Select your option" << endl;
    cout << "[1] Paper" << endl;
    cout << "[2] Rock" << endl;
    cout << "[3] Scissor" << endl;

    int playerOne, playerTwo;
    cout << "Player one input: ";

    if (cin >> playerOne) {
        if (playerOne >= 1 && playerOne <= 3) {
            cout << "Player two input: ";
            if (cin >> playerTwo) {
                if (playerTwo >= 1 && playerTwo <= 3) {
                    if ((playerOne == 1 && playerTwo == 2)
                        || (playerOne == 2 && playerTwo == 3)
                        || (playerOne == 3 && playerTwo == 1)) {
                        cout << "Player one wins." << endl;
                    } else {
                        cout << "Player two wins." << endl;
                    }
                } else if (playerTwo < 0) {
                    cout << "Input error, please enter a correct player two input." << endl;
                }
            } else {
                cout << "Invalid input, letters or special characters are not allowed." << endl;
            }
        } else {
            cout << "Input error, please enter a correct player one input." << endl;
        }
    } else {
        cout << "Invalid input, letters or special characters are not allowed." << endl;
    }

    return 0;
}
