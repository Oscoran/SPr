#include <iostream>
#include <cstdlib>
#include <ctime>

// Function to generate a random number in a given range
int generateRandomNumber(int lower, int upper) {
    return (rand() % (upper - lower + 1)) + lower;
}

int main() {
    int lower, upper;
    
    // Seed the random number generator
    srand(time(0));
    
    // Get range from user
    std::cout << "Enter the lower limit: ";
    std::cin >> lower;
    std::cout << "Enter the upper limit: ";
    std::cin >> upper;
    
    // Generate and print a random number
    int randomNum = generateRandomNumber(lower, upper);
    std::cout << "Generated Random Number: " << randomNum << std::endl;
    
    return 0;
}
