# Script Aula 12
# Aluno: Luis Galete Faldao - TDS04

# Execicio 1
n = int(input('Digite um inteiro positivo: '))
for i in range(0, 4):
    print(n * i)

# Execicio 2
s = '9876543210'
print(s[5:-2])
print(s[1:3])
print(s[:-2])
print(s[-4:-1])
print(s[:3])

# Exercicio 3
def rol(lista):
    print('=' * 45)
    print('Ultimo    Primeiro    Classe     Nota Media')
    print('=' * 45)
    for aluno in lista:
        print('{:10} {:10} {:10} {:8.2f}'.format(aluno[0], aluno[1], aluno[2], aluno[3]))

estudantes = []
estudantes.append(['DeMoines', 'Jim', 'Pleno', 3.45])
estudantes.append(['Pierre', 'Sophie', 'Pleno', 4.0])
estudantes.append(['Columbus', 'Maria', 'Sênior', 2.5])
estudantes.append(['Phoenix', 'River', 'Júnior', 2.45])
estudantes.append(['Olympis', 'Edgar', 'Júnior', 3.99])
rol(estudantes)

# Exercicio 4
def trocaPU(lista):
    aux = lista[-1]
    lista[-1] = lista[0]
    lista[0] = aux
    

lista = ['a', 'b', 'c', 'd']
trocaPU(lista)
print(lista)

# Exercicio 5
def divisores(n):
    res = []
    for i in range(1,n+1):
        if n % i == 0:
            res.append(i)
    return res

print(divisores(6))  

# Exercicio 6
def xmulti(lista1, lista2):
    resultado = []
    for i in lista1:
        for j in lista2:
            resultado.append(i * j)
    return resultado

print(xmulti([2,3],[1,5]))

# Exercicio 7
def soma2D(x, y):
    res = []
    for i in range(len(x)):
        res.append([])
        for j in range(len(x[0])):
            soma = x[i][j] + y[i][j]
            res[i].append(soma)
    return res

t = [[4, 7, 2, 5], [5, 1, 9, 2], [8, 3, 6, 6]]
s = [[0, 1, 2, 0], [0, 1, 1, 1], [0, 1, 0, 0]]

print(soma2D(t,s))

# Exercicio 8
def juros(taxa):
    x = 100
    anos = 0
    while x < 200:
        anos += 1
        x += x*taxa
    return anos

print(juros(0.07))

# Exercicio 9
def reverse(i):
    if i < 10:
        print(i)
    else:
        print(i % 10)
        return reverse(i//10)
    
print(reverse(1234))

# Exercicio 10
notas = [9, 7, 7, 10, 3, 9, 6, 6, 2]

# a)
print(notas.count(7))
# b)
notas[-1] = 4
print(notas)
# c)
print(max(notas))
# d)
notas.sort()
print(notas)
# e)
media = sum(notas) / len(notas)
print(media)
