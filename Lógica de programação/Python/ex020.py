def meuIMC(peso, altura):
    imc = peso / altura**2
    if imc < 18.5 :
        print('Abaixo do peso')
    elif imc < 25 :
        print('Normal')
    else :
        print('Acima do peso')

meuIMC(86 , 1.90)