#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler um número e imprimir: se é maior que 20, igual a 20 ou menor que 20.
main(){
	setlocale(LC_ALL,"Portuguese");
	
	float n1;
	
	printf("Digite um número: ");
	scanf("%f", &n1);
	
	if (n1>20){
		printf("Esse número é maior do que 20");
	}
	if (n1==20){
		printf("Esse número é igual a 20");
	}
	if (n1<20){
		printf("Esse número é menor que 20");
	}
	
return 0;	
}
