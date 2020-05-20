#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler dois números e apresentar o maior na tela

main(){
	setlocale(LC_ALL,"Portuguese");
	
	int n1, n2;
	printf("Digite um número: ");
	scanf ("%i", &n1);
	printf("Digite outro número: ");
	scanf("%i", &n2);
	
	if(n1 > n2){
		printf("O maior número é: %i",n1);
	}else{
		printf("O maior número é: %i",n2);
	}
	
	return 0;
}
