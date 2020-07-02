def org(lista):
    for i in range(0, len(lista)-1, 1):
        for j in range(len(lista)-1):
            if lista[j] > lista[j+1]:
                lista[j], lista[j+1] = lista[j+1], lista[j]
    return lista

print(org([10, 7, 2, 9, -3, -1, 20]))