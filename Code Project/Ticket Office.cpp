#include <iostream>
using namespace std;

double findYoungest(int arr[]){
   double min = arr[0];
   for(int i=0; i<5; i++) {
      if(min>arr[i]) {
         min=arr[i];
      }
   }
   return min;
}

int main() {
    int ages[5];

    for (int i = 0; i < 5; ++i) {
        cin >> ages[i];
    }

    
double discount = 50 - (findYoungest(ages)*0.5);
    cout<< discount;
    
    return 0;
}
