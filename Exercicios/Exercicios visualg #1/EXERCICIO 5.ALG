Algoritmo "Exercicio 5"
// Disciplina  : Linguagem e Lógica de Programação
// Professor   : Kleber Petry
// Descrição   : Le 2 números inteiros e os soma. Se a soma for maior que 35, mostra o resultado da soma.
// Autor(a)    : Luís Galete Faldão
// Data atual  : 10/04/2020
Var
// Seção de Declarações das variáveis 
n1, n2, soma: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreva ("Digite um numero: ")
leia (n1)
escreva ("Digite outro numero: ")
leia (n2)
soma <- n1 + n2
se soma > 35 entao
 escreva ("A soma entre esses numeros é: ", soma)
fimse

Fimalgoritmo