#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

//Ler 3 n�meros e fazer a soma deles
main(){
	setlocale(LC_ALL,"Portuguese");
	
	float n1, n2, n3, soma;
	
	printf("Digite o primeiro n�mero: ");
		scanf("%f", &n1);
	printf("Digite o segundo n�mero: ");
		scanf("%f", &n2);
	printf("Digite o terceiro n�mero: ");
		scanf("%f", &n3);
	printf("\n");
	
	soma = (n1 + n2 + n3);
	printf("A soma entre esses n�emros �: %.1f", soma);
	
	return 0;
	
}
