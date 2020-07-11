def fatorial(n):
    if n == 0 or n == 1:
        return 1
    else:
        fat = 1
        while n > 0:
            fat *= n
            n -= 1
        return fat

print(fatorial(4))