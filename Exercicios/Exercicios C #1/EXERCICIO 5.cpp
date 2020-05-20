#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler 2 números inteiros e soma-los. Se a soma for maior que 35, mostrar o resultado da soma
main(){
	setlocale(LC_ALL,"Portuguese");
	
	int n1, n2, soma;
	
	printf("Digite um número: ");
	scanf("%i", &n1);
	printf("Digite outro número: ");
	scanf("%i", &n2);
	
	if( n1 + n2 > 35){
		soma = n1 + n2;
		printf("A soma entre esses números é: %i", soma);
	}
return 0;
}
