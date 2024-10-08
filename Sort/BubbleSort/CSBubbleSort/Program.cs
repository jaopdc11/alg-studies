using System;
using System.Collections.Generic;

class Program {
    // Function to perform bubble sort
    static List<int> BubbleSort(List<int> arr) {
        int n = arr.Count;  // Get the size of the list

        // Outer loop for each element in the list
        for (int i = 0; i < n; i++) {
            // Inner loop to compare adjacent elements
            for (int j = 0; j < n - i - 1; j++) {
                // Swap if the current element is greater than the next
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];  // Temporary variable for swapping
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;  // Swap
                }
            }
        }
        return arr;  // Return the sorted list
    }

    static void Main() {
        List<int> arr = new List<int> {12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9};

        // Print the sorted list
        Console.WriteLine("Sorted list: " + string.Join(", ", BubbleSort(arr)));
    }
}
