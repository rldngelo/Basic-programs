#include <iostream>
#include <string>
#include <cctype>
using namespace std;

void countCharacters(string characters) {
    int size = characters.length();
    int countVowels = 0;
    int countConsonants = 0;
    int countNumber = 0;
    int countSpecial = 0;
    int whiteSpace = 0;
    int total = 0;
    char input;

    for (int counter = 0; counter < size; counter++) {
        input = characters[counter];
        if (isdigit(input)) {
            countNumber++;
        } else if (isalpha(input)) {
            input = toupper(input);
            if (input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U') {
                countVowels++;
            } else {
                countConsonants++;
            }
        } else if (isspace(input)) {
            whiteSpace++;
        } else {
            countSpecial++;
        }
    }

    total = countNumber + countVowels + countConsonants + whiteSpace + countSpecial;
    cout << "Number of vowels: " << countVowels << endl;
    cout << "Number of consonants: " << countConsonants << endl;
    cout << "Number of digits: " << countNumber << endl;
    cout << "Number of white spaces: " << whiteSpace << endl;
    cout << "Number of special characters: " << countSpecial << endl;
    cout << "Total number of characters: " << total << endl;
}

int main() {
    string userInput;
    cout << "Count the Characters v2" << endl;
    cout << "Enter a string: ";
    getline(cin, userInput);

    if (userInput == "") {
        cout << "No input, please input a string." << endl;
    } else {
        countCharacters(userInput);
    }

    return 0;
}
