#include <iostream>
using namespace std;

int main() {
    cout << "Smallest and Largest Element in an Array" << endl;
    cout << "Enter size of array, [3 - 10] only: ";

    int size;
    if (cin >> size) {
        if (size > 10 || size < 3) {
            cout << "Input error, input less than 3 or greater than 10 is not allowed." << endl;
        } else {
            int myArray[10];
            cout << "Enter the " << size << " elements below" << endl;

            for (int index = 0; index < size; index++) {
                cout << "Enter element " << (index + 1) << ": ";
                if (cin >> myArray[index]) {
                    if (index == size - 1) {
                        int smallContainer = myArray[0];
                        int bigContainer = myArray[0];

                        for (int counter = 0; counter < size; counter++) {
                            if (myArray[counter] < smallContainer) {
                                smallContainer = myArray[counter];
                            } else if (myArray[counter] > bigContainer) {
                                bigContainer = myArray[counter];
                            }
                        }

                        cout << "Smallest element in array set is " << smallContainer << "." << endl;
                        cout << "Largest element in array set is " << bigContainer << "." << endl;
                    }
                } else {
                    cout << "Invalid input, please input an integer value in element " << (index + 1) << ".";
                    break;
                }
            }
        }
    } else {
        cout << "Invalid input, letters or special symbols are not allowed." << endl;
    }

    return 0;
}
