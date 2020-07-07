def exponencial(x, y):
    if y == 0:
        return 1
    return x * exponencial(x, y - 1)

print(exponencial(5, 3))