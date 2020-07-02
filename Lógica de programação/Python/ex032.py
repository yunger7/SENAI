def pares(n1, n2):
    cont = 0
    n1 += 1
    while n1 < n2:
        if n1 % 2 == 0:
            cont += 1
        n1 += 1
    return cont

print(pares(2, 10))