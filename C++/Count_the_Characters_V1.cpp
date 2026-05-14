#include <iostream>
#include <string>
#include <cctype>
using namespace std;

void countCharacters(string characters) {
    int size = characters.length();
    int countLetter = 0;
    int countNumber = 0;
    int countSpecial = 0;
    int total = 0;
    char input;

    for (int counter = 0; counter < size; counter++) {
        input = characters[counter];
        if (isdigit(input)) {
            countNumber++;
        } else if (isalpha(input)) {
            countLetter++;
        } else {
            countSpecial++;
        }
    }

    total = countNumber + countLetter + countSpecial;
    cout << "Letter count: " << countLetter << endl;
    cout << "Number count: " << countNumber << endl;
    cout << "Special character count: " << countSpecial << endl;
    cout << "Total number of characters: " << total << endl;
}

int main() {
    string userInput;
    cout << "Count the Characters v1" << endl;
    cout << "Enter a string: ";
    getline(cin, userInput);

    if (userInput == "") {
        cout << "No input, please input a string." << endl;
    } else {
        countCharacters(userInput);
    }

    return 0;
}
