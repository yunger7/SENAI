#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler um n�mero e imprimir: se � maior que 20, igual a 20 ou menor que 20.
main(){
	setlocale(LC_ALL,"Portuguese");
	
	float n1;
	
	printf("Digite um n�mero: ");
	scanf("%f", &n1);
	
	if (n1>20){
		printf("Esse n�mero � maior do que 20");
	}
	if (n1==20){
		printf("Esse n�mero � igual a 20");
	}
	if (n1<20){
		printf("Esse n�mero � menor que 20");
	}
	
return 0;	
}
