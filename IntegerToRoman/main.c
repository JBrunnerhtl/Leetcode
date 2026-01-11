#include <stdio.h>


int getValue(char s) {
    int value = 0;
    switch (s) {
        case 'I':
            value = 1;
            break;
        case 'V':
            value = 5;
            break;
        case 'X':
            value = 10;
            break;
        case 'L':
            value = 50;
            break;
        case 'C':
            value = 100;
            break;
        case 'D':
            value = 500;
            break;
        case 'M':
            value = 1000;
            break;
    }
    return value;
}

int romanToInt(char* s) {
    int output = 0;
    for (int i = 0; s[i] != '\0'; i++) {
        if (s[i+ 1] == '\0') {
            output += getValue(s[i]);
            break;
        }
        const int firstValue = getValue(s[i]);
        const int secondValue = getValue(s[i + 1]);
        if (firstValue >= secondValue) {
            output += firstValue;
        }
        else {
            output -= firstValue;
        }
    }
    return output;
}

int main(void) {
    printf("Hello, World!\n");
    int result = romanToInt("MCMXCIV");
    printf("Result: %i\n", result);
    return 0;
}