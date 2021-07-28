#include<iostream>
#include<string>
using namespace std;
main(){
    string s;
    getline(cin,s);
    while(s.find("Grr")!=-1){
        int a;
        a=s.find("Grr");
        s.replace(a,3,"Lion");
    }
    while(s.find("Rawr")!=-1){
        int a;
        a=s.find("Rawr");
        s.replace(a,4,"Tiger");
    }
    while(s.find("Ssss")!=-1){
        int a;
        a=s.find("Ssss");
        s.replace(a,4,"Snake");
    }
    while(s.find("Chirp")!=-1){
        int a;
        a=s.find("Chirp");
        s.replace(a,5,"Bird");
    }
    cout<<s;
}
