using System;
using System.Collections.Generic;

class Program {
    // Function to perform quick sort
    static List<int> QuickSort(List<int> arr) {
        // Base case: if the list is empty or has one element, return it
        if (arr.Count <= 1) {
            return arr;
        }

        int pivot = arr[arr.Count - 1];  // Choose a pivot (the last element)
        List<int> left = new List<int>();  // List for elements less than the pivot
        List<int> right = new List<int>();  // List for elements greater than the pivot

        // Iterate through the list (excluding the pivot)
        for (int i = 0; i < arr.Count - 1; i++) {
            if (arr[i] < pivot) {
                left.Add(arr[i]);  // Append to the left list if less than pivot
            }
            else {
                right.Add(arr[i]);  // Append to the right list if greater or equal to pivot
            }
        }

        // Recursively sort the left and right lists, and concatenate the results with the pivot
        List<int> sortedList = QuickSort(left);
        sortedList.Add(pivot);
        sortedList.AddRange(QuickSort(right));
        
        return sortedList;  // Return the sorted list
    }

    static void Main() {
        List<int> arr = new List<int> {12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9};
        List<int> sortedList = QuickSort(arr);

        // Print the sorted list
        Console.WriteLine("Sorted list: " + string.Join(", ", sortedList));
    }
}
