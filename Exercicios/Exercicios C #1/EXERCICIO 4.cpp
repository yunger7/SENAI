#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler um n�mero e se for maior que 50 imprimir a metade desse n�mero.
main(){
	setlocale(LC_ALL, "Portuguese");
	
	float n1;
	printf("Digite um n�mero: ");
	scanf("%f", &n1);
	
	if( n1 > 50 ){
		printf("A metade desse n�mero �: %.2f", n1 / 2);
	}
	
	return 0;
}
