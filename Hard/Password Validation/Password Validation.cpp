#include <iostream>
using namespace std;

int main() {
int a=0,b=0,c=0,d=0;
string pswrd;
getline(cin,pswrd);
a=pswrd.length();
for(; b<a; b++){
    if(pswrd[b]=='$'||pswrd[b]=='&'||pswrd[b]=='@'||pswrd[b]=='%'||pswrd[b]=='#'||pswrd[b]=='*'||pswrd[b]=='!'){
    c++;}
        if(pswrd[b]=='1'||pswrd[b]=='2'||pswrd[b]=='3'||pswrd[b]=='4'||pswrd[b]=='5'||pswrd[b]=='6'||pswrd[b]=='7'||pswrd[b]=='8'||pswrd[b]=='9'||pswrd[b]=='0'){
    d++;}
}
    if(c>=2 && d>=2 && a>=7){
        cout << "Strong";
    
}else {
    cout << "Weak";
}
    return 0;
}
