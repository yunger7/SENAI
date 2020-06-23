# 5! = 5 * 4 * 3 * 2 * 1 = 120
# 4! = 4 * 3 * 2 * 1 = 24
# 3! = 3 * 2 * 1 = 6

# using callback function
def fatorial(n):
    if n <= 1:
        return 1
    return n*fatorial(n-1)

print(fatorial(5))

# primeira forma de resolucao
def fat(n):
    res = 1
    for i in range(2, n+1):
        res *= i
    return res


# segunda forma de resolucao
def fat2(n):
    resultado = 1
    for i in range(1, n+1):
        resultado *= i
    return resultado
