#include <iostream>
using namespace std;

int main() {
    int hours, minutes, seconds, convertedTime;

    cout << "Time Elapsed" << endl;
    cout << "Enter time in hours (0-24): ";

    if (cin >> hours) {
        if (hours < 0 || hours > 24) {
            cout << "Input error, please input a correct hours value." << endl;
        } else if (hours == 24) {
            cout << "The equivalent time in seconds is 86,400." << endl;
        } else {
            cout << "Enter time in minutes (0-60): ";
            if (cin >> minutes) {
                if (minutes < 0 || minutes > 60 || hours + minutes == 84) {
                    cout << "Input error, please input a correct minutes value." << endl;
                } else if (hours + minutes == 83) {
                    cout << "The equivalent time in seconds is 86,400." << endl;
                } else {
                    cout << "Enter time in seconds (0-60): ";
                    if (cin >> seconds) {
                        if (seconds < 0 || seconds > 60 || hours * 3600 + minutes * 60 + seconds > 86400) {
                            cout << "Input error, please input a correct seconds value." << endl;
                        } else {
                            convertedTime = hours * 3600 + minutes * 60 + seconds;
                            cout << "The equivalent time in seconds is " << convertedTime << "." << endl;
                        }
                    } else {
                        cout << "Invalid input, letters or special characters for seconds are not allowed." << endl;
                    }
                }
            } else {
                cout << "Invalid input, letters or special characters for minutes are not allowed." << endl;
            }
        }
    } else {
        cout << "Invalid input, letters or special characters for hours are not allowed." << endl;
    }

    return 0;
}
