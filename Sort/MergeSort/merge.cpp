#include <iostream>
#include <vector>

std::vector<int> merge(const std::vector<int>& left, const std::vector<int>& right) {
    std::vector<int> result;

    int i = 0;
    int j = 0;

    while (i < left.size() && j < right.size()) {
        if (left[i] < right[j]) {
            result.push_back(left[i]);
            i++;
        } else {
            result.push_back(right[j]);
            j++;
        }
    }

    while (i < left.size()) {
        result.push_back(left[i]);
        i++;
    }

    while (j < right.size()) {
        result.push_back(right[j]);
        j++;
    }

    return result;
}

std::vector<int> mergeSort(std::vector<int>& arr) {
    if (arr.size() <= 1) {
        return arr;
    }

    int mid = arr.size() / 2;

    std::vector<int> left(arr.begin(), arr.begin() + mid);
    std::vector<int> right(arr.begin() + mid, arr.end());

    return merge(mergeSort(left), mergeSort(right));
}

int main() {
    std::vector<int> arr = {12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9};

    std::vector<int> sortedarr = mergeSort(arr);

    std::cout << "Sorted arr: [";
    for (int i = 0; i < sortedarr.size(); i++) {
        std::cout << sortedarr[i];
        if (i < sortedarr.size() - 1) {
            std::cout << ", ";
        }
    }

    std::cout << "]\n";

    return 0;
}
