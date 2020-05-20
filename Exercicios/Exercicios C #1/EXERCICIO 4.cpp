#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler um número e se for maior que 50 imprimir a metade desse número.
main(){
	setlocale(LC_ALL, "Portuguese");
	
	float n1;
	printf("Digite um número: ");
	scanf("%f", &n1);
	
	if( n1 > 50 ){
		printf("A metade desse número é: %.2f", n1 / 2);
	}
	
	return 0;
}
