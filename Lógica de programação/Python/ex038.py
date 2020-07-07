def div(m, n):
    if m < n:
        return 0
    else:
        return 1 + div(m-n, n)

print(div(7,2))