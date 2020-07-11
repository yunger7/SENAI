def contagemRegressiva(n):
    if n == 0:
        return 0
    else:
        print(n)
        return contagemRegressiva(n - 1)

print(contagemRegressiva(10))