#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//. Ler dois n�meros, se forem iguais apresenta a mensagem na tela igual, caso contr�rio, diferente.
main(){
	setlocale(LC_ALL,"Portuguese");
	
	int n1, n2;
	printf("Digite um n�mero: ");
	scanf("%i", &n1);
	printf("Digite outro n�mero: ");
	scanf("%i", &n2);
	
	if(n1 == n2){
		printf("Estes n�meros s�o iguais!");
	}else{
		printf("Estes n�meros s�o diferentes!");
	}
	
	
	return 0;
	
	
}
