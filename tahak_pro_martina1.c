#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int generateRandomNumber(int lower, int upper) {
    return (rand() % (upper - lower + 1)) + lower;
}

int main() {
    int lower, upper;
    
    srand(time(0));
    
    printf("Enter the lower limit: ");
    scanf("%d", &lower);
    printf("Enter the upper limit: ");
    scanf("%d", &upper);
    
    int randomNum = generateRandomNumber(lower, upper);
    printf("Generated Random Number: %d\n", randomNum);
    
    return 0;
}
