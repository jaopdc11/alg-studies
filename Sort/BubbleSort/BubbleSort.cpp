#include <iostream>
#include <vector>

// Function to perform bubble sort
std::vector<int> bubbleSort(std::vector<int>& arr) {
    int n = arr.size();  // Get the size of the list

    // Outer loop for each element in the list
    for (int i = 0; i < n; i++) {
        // Inner loop to compare adjacent elements
        for (int j = 0; j < n - i - 1; j++) {
            // Swap if the current element is greater than the next
            if (arr[j] > arr[j + 1]) {
                std::swap(arr[j], arr[j + 1]);  // Swap
            }
        }
    }
    return arr;  // Return the sorted list
}

int main() {
    std::vector<int> arr = {12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9};

    // Print the sorted list
    std::cout << "Sorted list: ";
    for (const int& num : bubbleSort(arr)) {
        std::cout << num << " ";  // Print each number in the sorted list
    }
    return 0;
}
