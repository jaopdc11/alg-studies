def linear_search(lista, target):
    # Iterate through each element in the list
    for i in range(0, len(lista)):
        # Check if the current element matches the target
        if lista[i] == target:
            return i  # Return the index if found
    return -1  # Return -1 if the target is not found

lista = [1, 2, 3, 4, 6, 7, 9, 12, 100, 291, 710]
target = 7
resultado = linear_search(lista, target)

# Check if the result is found
if resultado != -1:
    print(f'Element "{target}" found at index [{resultado}].')
else:
    print('Element not found.')
