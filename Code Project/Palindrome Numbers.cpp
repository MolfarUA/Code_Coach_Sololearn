#include <iostream>
using namespace std;

bool isPalindrome(int x) {
    //complete the function
     int  num, rem, rev=0;
    
     num=x; //to be able to save new values to compare original with
    while(x != 0)//to end loop once x=0
     { 
     rem = x%10; //1st step divides    number by 10 and makes the remainder the value of rem. Ex. 1234/10=123.4 rem=4
     rev= rev*10 + rem; //reverse number starts at 0 *10 + rem(4)=4
     x /= 10; //x becomes the value of x/10(123)
//these steps repeat. Rem=3, rev =4*10+3=43, x=123/10=12, until rev= 4321 and x=0.
     
        
    }
    
    if (rev==num)
    {
        return true;
        }
        else 
        {
            return false;
            
        }
    

}
int main() 
{

int n;
   cin >>n;
    
    
    if(isPalindrome(n)) {
        cout <<n<<" is a palindrome";
    }
    else {
        cout << n<<" is NOT a palindrome";
    }
    
    return 0;
}
