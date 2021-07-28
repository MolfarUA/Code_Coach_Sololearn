#include <iostream>
using namespace std;

int main() {

string str, str2;
int j=0;
cin >> str;

int y = str.length();

for (int i=y-1; i>=0; i--){
    if (str[i]=='/' || str[i]=='='){
        break;
    }
    str2[j]=str[i];
    j++;
}
j--;
for (int i=j; i>=0; i--){
    cout << str2[i];
}
    return 0;
}
