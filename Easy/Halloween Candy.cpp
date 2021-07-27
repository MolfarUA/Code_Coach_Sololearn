#include <iostream>
using namespace std;

int main() {
    int houses;
    cin>>houses;

   int high=(2*100)/houses;
int per=(2*100)/houses;
if(high>per+.5)
  
    cout<<per+1;
else{
  if(per+1==21)
    cout<<"20";
  else
    cout<<per+1;}
    
    return 0;
}
