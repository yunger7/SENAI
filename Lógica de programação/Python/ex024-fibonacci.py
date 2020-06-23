print("\nSEQUENCIA DE FIBONACCI\n")
n = int(input('Imprimar quantos numeros da sequencia? '))

f1 = 0
f2 = 1
c = 3

if 0 < n < 3:
    print(f1, end='')
    if n == 2:
        print(' - {}'.format(f2), end='')
elif n >= 3:
    print('{} - {}'.format(f1,f2), end='')
    while c <= n:
        f3 = f1 + f2
        print(' - {}'.format(f3), end='')
        f1 = f2
        f2 = f3
        c += 1
    print(' - FIM')