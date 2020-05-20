#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//. Ler dois números, se forem iguais apresenta a mensagem na tela igual, caso contrário, diferente.
main(){
	setlocale(LC_ALL,"Portuguese");
	
	int n1, n2;
	printf("Digite um número: ");
	scanf("%i", &n1);
	printf("Digite outro número: ");
	scanf("%i", &n2);
	
	if(n1 == n2){
		printf("Estes números são iguais!");
	}else{
		printf("Estes números são diferentes!");
	}
	
	
	return 0;
	
	
}
