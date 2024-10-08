using System;
using System.Collections.Generic;

public class Program {
    // Function to perform linear search
    static int LinearSearch(List<int> lista, int target) {
        // Iterate through each element in the list
        for (int i = 0; i < lista.Count; i++) {
            // Check if the current element matches the target
            if (lista[i] == target) {
                return i;  // Return the index if found
            }
        }
        return -1;  // Return -1 if the target is not found
    }

    public static void Main(string[] args) {
        List<int> lista = new List<int> {1, 2, 3, 4, 6, 7, 9, 12, 100, 291, 710};
        int target = 7;
        int resultado = LinearSearch(lista, target);

        // Check if the result is found
        if (resultado != -1) {
            Console.WriteLine($"Element '{target}' found at index [{resultado}].");
        }
        else {
            Console.WriteLine("Element not found.");
        }
    }
}
