nome = input('Qual o seu nome: ')
#está validando o nome que precisa ter mais de 3 caracteres
while len(nome) <=3:
    nome = input ('O nome deve ter mais do que 3 caracteres: ')

idade = int(input('Qual a sua idade: '))
#Validar a idade entre 0 e 150 anos
while idade < 0 or idade > 150:
    idade = int(input('A idade não pode ser negativa e nem maior do que 150 anos: '))

salario = float(input('Salário: '))
# o salario não pode ser negativo
while salario < 0:
    salario = float(input('O salario não pode ser negativo: '))

sexo = input("Sexo - 'F' feminino - 'M' masculino: ")
# sexo precisa ser F ou M
while sexo.upper() != 'F' and sexo.upper() !='M':
    sexo = input('Digite F(feminino) ou M(masculino): ')

civil = input('Estado civil: \n S-Solteiro \n C-Casado \n V-Viuvo, \n D-Divorciado \n :')
#precisa estar entre uma das opções
while civil.upper() != 'S' and  civil.upper() != 'C' and civil.upper() != 'V' and civil.upper() != 'D':
    civil = print('Entrada invalida\n Estado Civil: \n S-Solteiro \n C-Casado \nV-Viuvo \nD-D-Divorciado')