#include <stdio.h>
#include <stdlib.h>
int main() {
    int fruit,banana,apple,pie;
    scanf("%d",&fruit);

    //your code goes here
    if(fruit>=6)
    {
    apple=fruit/2;
    pie=apple/3;
    printf("%d",pie);
    }
    else 
    printf("0");
    return 0;
}
