#include <iostream>
using namespace std;

int main() {

    string s, a, pig;
    getline(cin, s);
    for(int i = 0; s[i] != '\0'; i++){
        a += s[i];
        if(s[i+1] == ' ' || s[i+1] == '\0'){
        a = a.substr(1) + a[0] + "ay";
        pig += a + ' ';
        i++;
        a = "";
        }
    }
        cout << pig;
    return 0;
}
