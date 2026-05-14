#include <iostream>
#include <string>
#include <cctype>
using namespace std;

int countCharacters(string input, char characterInput) {
    int count = 0;
    int length = input.length();

    for (int counter = 0; counter < length; counter++) {
        char container = input[counter];
        char smallContainer = tolower(container);
        char smallCharacter = tolower(characterInput);
        if (smallContainer == smallCharacter) {
            count++;
        }
    }

    return count;
}

int main() {
    string word;
    cout << "Count the Characters v3" << endl;
    cout << "Enter a string:";
    getline(cin, word);

    if (word == "") {
        cout << "No input, please input a string." << endl;
    } else {
        cout << "Enter a character to count in [" << word << "]:";
        string letter;
        getline(cin, letter);

        if (letter.empty()) {
            cout << "No input, please input a character to count." << endl;
        } else {
            char finalLetter = letter[0];
            int result = countCharacters(word, finalLetter);
            cout << letter << " occurs " << result << " times in " << word << "." << endl;
        }
    }

    return 0;
}
