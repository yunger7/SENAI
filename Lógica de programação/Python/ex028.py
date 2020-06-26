def xmulti(lista1, lista2):
    resultado = []
    for i in lista1:
        for j in lista2:
            resultado.append(i * j)
    return resultado

print(xmulti([1,2],[3,4]))