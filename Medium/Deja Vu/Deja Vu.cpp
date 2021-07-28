#include <iostream>
using namespace std;


int main() {

string input;
getline(cin, input);
int input_length = input.length();
int i;
int j;
char a;
char b;
string z;
z="Unique";

for(i=0; i<input_length; i++)  {
  
  a=input[i];
    
for (j=i+1; j<input_length; j++) {

  b=input[j];
            
    if (a==b)
             z="Deja Vu";
        }
    }   
  cout<<z;   
     
    return 0;
}
