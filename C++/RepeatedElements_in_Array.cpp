#include <iostream>
using namespace std;

int main() {
    cout << "Repeated Elements in an Array" << endl;
    cout << "Enter size of array, [3 - 10] only: ";

    int size;
    if (cin >> size) {
        if (size > 10 || size < 3) {
            cout << "Input error, input number must be from 3 to 10 only." << endl;
        } else {
            int myArray[10];
            cout << "Input " << size << " elements in the array:" << endl;

            for (int index = 0; index < size; index++) {
                cout << "Element " << (index + 1) << ": ";
                if (cin >> myArray[index]) {
                } else {
                    cout << "Invalid input, please input a numeric value in element " << (index + 1) << "." << endl;
                    return 0;
                }
            }

            int count = 0;
            for (int counterOne = 0; counterOne < size - 1; counterOne++) {
                bool repeated = false;
                for (int counterTwo = 0; counterTwo < counterOne; counterTwo++) {
                    if (myArray[counterOne] == myArray[counterTwo]) {
                        repeated = true;
                        break;
                    }
                }

                if (!repeated) {
                    for (int counterTwo = counterOne + 1; counterTwo < size; counterTwo++) {
                        if (myArray[counterOne] == myArray[counterTwo]) {
                            count++;
                            break;
                        }
                    }
                }
            }

            cout << "The number of repeated elements is " << count << "." << endl;
        }
    } else {
        cout << "Invalid input, please input a numeric value." << endl;
    }

    return 0;
}
