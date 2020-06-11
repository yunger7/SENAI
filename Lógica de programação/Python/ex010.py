# a)
idade = int(input('Digite a idade: '))
if idade > 62:
    print('Voce pode obter beneficios de pensao')

# b)
jogadores = ['Musial','Aaraon','Williame','Gehrig']
nome = input('Digite o nome: ')
if nome in jogadores:
    print('Um dos maiores jogadores de beisibol de todos os tempos!')

# c)
golpes = int(input('Numero de golpes: '))
defesa = int(input('Numero de defesas: '))
if golpes > 10 and defesa == 0:
    print('Voce esta morto...')

# d)
cardeal = input('Digite a direcao: ')
if cardeal in ['norte','sul','leste','oeste']:
    print('Posso escapar.')