using System;
using System.Collections.Generic;

public class Program {

    public static void Main(string[] args) {
        List<int> arr = new List<int> {12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9};

        List<int> sortedarr = MergeSort(arr);

        Console.WriteLine("Sorted arr: [" + string.Join(", ", sortedarr) + "]");

    }

    static List<int> MergeSort(List<int> arr) {
        if (arr.Count <= 1) {
            return arr;
        }

        int mid = arr.Count / 2;

        List<int> left = new List<int>(arr.GetRange(0, mid));
        List<int> right = new List<int>(arr.GetRange(mid, arr.Count - mid));

        return Merge(MergeSort(left), MergeSort(right));

    }

    static List<int> Merge(List<int> left, List<int> right) {
        List<int> result = new List<int>();

        int i = 0, j = 0;

        while (i < left.Count && j < right.Count) {
            if (left[i] < right[j]) {
                result.Add(left[i]);
                i++;
            }
            else {
                result.Add(right[j]);
                j++;
            }
        }

        while (i < left.Count) {
            result.Add(left[i]);
            i++;
        }

        while (j < right.Count) {
            result.Add(right[j]);
            j++;
        }

        return result;

    }

}
