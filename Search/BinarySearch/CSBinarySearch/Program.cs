using System;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {
        List<int> arr = new List<int> {1, 2, 3, 4, 6, 7, 9, 12, 100, 291, 710};
        int target = 7;
        int resultado = BinarySearch(arr, target);

        // Check if the result is found
        if (resultado != -1) {
            Console.WriteLine($"Element found at index: '{resultado}'.");
        }
        else {
            Console.WriteLine("Element not found.");
        }
    }

    // Function to perform binary search
    static int BinarySearch(List<int> arr, int target) {
        int left = 0;  // Start of the list
        int right = arr.Count - 1;  // End of the list

        // Continue searching while left pointer is less than or equal to right pointer
        while (left <= right) {
            int middle = (left + right) / 2;  // Calculate the middle index

            // Check if the middle element is the target
            if (arr[middle] == target) {
                return middle;  // Return the index if found
            }
            else if (arr[middle] < target) {
                left = middle + 1;  // Move the left pointer to search in the right half
            }
            else {
                right = middle - 1;  // Move the right pointer to search in the left half
            }
        }

        return -1;  // Return -1 if the target is not found
    }
}
