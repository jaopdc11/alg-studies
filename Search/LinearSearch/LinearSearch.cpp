#include <iostream>
#include <vector>

// Function to perform linear search
int linearSearch(const std::vector<int>& lista, int target) {
    // Iterate through each element in the list
    for (int i = 0; i < lista.size(); i++) {
        // Check if the current element matches the target
        if (lista[i] == target) {
            return i;  // Return the index if found
        }
    }
    return -1;  // Return -1 if the target is not found
}

int main() {
    std::vector<int> lista = {1, 2, 3, 4, 6, 7, 9, 12, 100, 291, 710};
    int target = 7;
    int resultado = linearSearch(lista, target);

    // Check if the result is found
    if (resultado != -1) {
        std::cout << "Element '" << target << "' found at index [" << resultado << "].";
    }
    else {
        std::cout << "Element not found.";
    }
}
