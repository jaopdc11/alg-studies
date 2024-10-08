#include <iostream>
#include <vector>

// Function to perform quick sort
std::vector<int> quickSort(std::vector<int>& arr) {
    // Base case: if the list is empty or has one element, return it
    if (arr.size() <= 1) {
        return arr;
    }

    int pivot = arr.back();  // Choose a pivot (the last element)
    std::vector<int> left;  // List for elements less than the pivot
    std::vector<int> right;  // List for elements greater than the pivot

    // Iterate through the list (excluding the pivot)
    for (size_t i = 0; i < arr.size() - 1; i++) {
        if (arr[i] < pivot) {
            left.push_back(arr[i]);  // Append to the left list if less than pivot
        }
        else {
            right.push_back(arr[i]);  // Append to the right list if greater or equal to pivot
        }
    }

    // Recursively sort the left and right lists, and concatenate the results with the pivot
    std::vector<int> sortedList = quickSort(left);
    sortedList.push_back(pivot);
    std::vector<int> rightSorted = quickSort(right);
    sortedList.insert(sortedList.end(), rightSorted.begin(), rightSorted.end());

    return sortedList;  // Return the sorted list
}

int main() {
    std::vector<int> arr = {12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9};
    std::vector<int> sortedList = quickSort(arr);

    // Print the sorted list
    std::cout << "Sorted list: ";
    for (const int& num : sortedList) {
        std::cout << num << " ";  // Print each number in the sorted list
    }
    return 0;
}
