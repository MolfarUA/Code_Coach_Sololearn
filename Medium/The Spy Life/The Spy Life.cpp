#include <iostream>

using namespace std;

int main() {
    string abc = "abcdefghijklmnopqrstuvwxyz ",s = "6s1o2c3a4t5",rs;
    bool k = 1;

    getline(cin, s);
    for (int j=s.size()-1;j>=0;j--){

        if(isupper(s[j])){
            s[j]=tolower(s[j]);
            k=0;
        }
        for (long unsigned int i=0;i<abc.size();i++)
        {
            if (abc[i]==s[j]){
                if(k==0){
                    s[j]=toupper(s[j]);
                }
                rs = rs+s[j];
                k=1;
                break;
            }
            
        }
        
    }

    cout<<rs;
    return 0;
}
