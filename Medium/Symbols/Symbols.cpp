#include <iostream>
using namespace std;

int main() {
    string line;
    string temp = "";
    getline(cin, line);
    for (int i = 0; i < line.size(); ++i) {
        if ((line[i] >= 'a' && line[i] <= 'z') || (line[i] >= 'A' && line[i] <= 'Z') ||  (line[i] >= '0' && line[i] <= '9') || line[i] == ' '  ) {
            temp +=line[i];
        }
    }
    cout << temp;
    return 0;
}
