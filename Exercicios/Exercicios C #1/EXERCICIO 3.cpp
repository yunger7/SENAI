#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler 3 números e fazer a soma deles
main(){
	setlocale(LC_ALL,"Portuguese");
	
	float n1, n2, n3, soma;
	
	printf("Digite o primeiro número: ");
		scanf("%f", &n1);
	printf("Digite o segundo número: ");
		scanf("%f", &n2);
	printf("Digite o terceiro número: ");
		scanf("%f", &n3);
	printf("\n");
	
	soma = (n1 + n2 + n3);
	printf("A soma entre esses núemros é: %.1f", soma);
	
	return 0;
	
}
