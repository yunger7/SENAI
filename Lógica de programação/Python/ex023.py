def aritmetica(lista):
    passo = lista[1] - lista[0]
    for i in range(1, len(lista)-1):
        if lista[i+1] - lista[i] != passo:
            return False
    return True

print(aritmetica([3, 6, 8, 12, 15, 18]))
print(aritmetica([3,6,9,11,15]))
