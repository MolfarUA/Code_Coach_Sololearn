#include <iostream>
using namespace std;

int main() {
    
    int total;
    cin >> total;  //get input
    
    int a = total % 50;
    int b = 50 - a;
    cout << b;

    return 0;
}
