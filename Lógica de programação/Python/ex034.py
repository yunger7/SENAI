import random
def aleatorio(n):
    cont = 1
    soma = 0
    while cont <= n:
        rand = random.randint(1, 10)
        soma += rand
        cont += 1
    return soma

print(aleatorio(5))