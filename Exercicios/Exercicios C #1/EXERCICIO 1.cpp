#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler dois n�meros e apresentar o maior na tela

main(){
	setlocale(LC_ALL,"Portuguese");
	
	int n1, n2;
	printf("Digite um n�mero: ");
	scanf ("%i", &n1);
	printf("Digite outro n�mero: ");
	scanf("%i", &n2);
	
	if(n1 > n2){
		printf("O maior n�mero �: %i",n1);
	}else{
		printf("O maior n�mero �: %i",n2);
	}
	
	return 0;
}
