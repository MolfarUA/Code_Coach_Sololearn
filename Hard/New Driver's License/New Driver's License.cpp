#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    string names[5]; 
    string yrname; 
    cin>>yrname;
    names[0] = yrname;
    int nagents; 
    cin>>nagents;    
    for(int i=1;i<5;++i) 
        cin >> names[i];
    
    sort(begin(names), end(names));
    
    auto pos = find(begin(names), end(names),yrname);
    auto mypos = pos-begin(names)+1;

    if(mypos==1 || nagents > 4) {
        cout << 20;
    }
    else if(mypos==2) {
        if (nagents==1) cout<<40;
        else if(nagents==2)cout<<20;
        else if(nagents==3)cout<<20;
        else if(nagents==4)cout<<20;
        else if(nagents==5)cout<<20;
    }
    else if(mypos==3){
        if(nagents==1) cout << 60;
        else if(nagents==2)cout<<40;
        else if(nagents==3)cout<<20;
        else if(nagents==4)cout<<20;
        else if(nagents==5)cout<<20;
    }
    else if(mypos==4){
        if(nagents==1) cout << 80;
        else if(nagents==2)cout<<40;
        else if(nagents==3)cout<<40;
        else if(nagents==4)cout<<20;
        else if(nagents==5)cout<<20;
    }
    else if(mypos==5){
        if(nagents==1) cout << 100;
        else if(nagents==2)cout<<60;
        else if(nagents==3)cout<<40;
        else if(nagents==4)cout<<40;
        else if(nagents==5)cout<<20;
    }    
}
