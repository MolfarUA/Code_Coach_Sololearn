#include<iostream>
#include<string>
using namespace std;
int main(){
    string s;
    getline(cin,s);
    for(int i=0;i<s.length();i++){
        char c=s[i];
         if(s[i]=='1'&&s[i+1]=='0'){ s.replace(i,2
         ,"ten");  }
        
         else if(c=='0'){   s.replace(i,1,"zero"); }
         else if(c=='1'){  s.replace(i,1,"one");    }
         else if(c=='2'){  s.replace(i,1,"two");    }
         else if(c=='3'){  s.replace(i,1,"three");  }
         else if(c=='4'){  s.replace(i,1,"four");   }
         else if(c=='5'){  s.replace(i,1,"five");   }
         else if(c=='6'){  s.replace(i,1,"six");    }
         else if(c=='7'){  s.replace(i,1,"seven");  }
         else if(c=='8'){  s.replace(i,1,"eight");  }
         else if(c=='9'){  s.replace(i,1,"nine");   } 
         
         }
         cout<<s;
    return 0;
}
