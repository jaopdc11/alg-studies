def binary_search(arr, target):
    # Initialize left and right pointers
    left, right = 0, len(arr) - 1
    
    # Continue searching while left pointer is less than or equal to right pointer
    while left <= right:
        # Calculate the middle index
        middle = (left + right) // 2
        
        # Check if the middle element is the target
        if arr[middle] == target:
            return middle  # Return the index if found
        elif arr[middle] < target:
            left = middle + 1  # Move the left pointer to search in the right half
        else:
            right = middle - 1  # Move the right pointer to search in the left half
            
    return -1  # Return -1 if the target is not found

arr = [1, 2, 3, 4, 6, 7, 9, 12, 100, 291, 710]
target = 7
resultado = binary_search(arr, target)

# Check if the result is found
if resultado != -1:
    print(f'Element {target} found in the list at index "{resultado}".')
else:
    print('Element not found.')
