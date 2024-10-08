def quick_sort(arr):
    # Base case: if the list is empty or has one element, return it
    if len(arr) <= 1:
        return arr

    # Choose a pivot (the last element in this case)
    pivot = arr[-1]
    left = []  # List for elements less than the pivot
    right = []  # List for elements greater than the pivot

    # Iterate through the list (excluding the pivot)
    for i in range(len(arr) - 1):
        if arr[i] < pivot:
            left.append(arr[i])  # Append to the left list if less than pivot
        else:
            right.append(arr[i])  # Append to the right list if greater or equal to pivot

    # Recursively sort the left and right lists, and concatenate the results with the pivot
    return quick_sort(left) + [pivot] + quick_sort(right)

arr = [12, 4, 6, 7, 291, 710, 1, 3, 2, 100, 9]
sorted_list = quick_sort(arr)

# Print the sorted list
print(f'Sorted list: {sorted_list}')
