def bubble_sort(arr):
    # Get the size of the list
    size = len(arr)
    # Outer loop for each element in the list
    for i in range(0, size):
        # Inner loop to compare adjacent elements
        for j in range(0, size - i - 1):
            # Swap if the current element is less than the next
            if arr[j] < arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]  # Swap
    return arr  # Return the sorted list

arr = [12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9]

# Print the sorted list
print(f'Sorted list: {bubble_sort(arr)}')
