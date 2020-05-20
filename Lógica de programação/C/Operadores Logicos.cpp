#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main(){
setlocale(LC_ALL,"Portuguese");
int num1, num2;
num1 = 12;
num2 = 13;

printf("Exemplos usando operadores logicos: \n");

//Operador AND (E)
	printf("Operador logico AND (E): \n");
	printf("%d\n", false && false);
	printf("%d\n", true && false);
	printf("%d\n", false && true);
	printf("%d\n", true && true);
	printf("\n");
	
//Operador OR (OU)
	printf("Operador logico OR (OR): \n");
	printf("%d\n", false || false);
	printf("%d\n", true ||false);
	printf("%d\n", false || true);
	printf("%d\n", true || true);
	printf("\n");
	
//Operador NOT (NAO)
	printf("Inverso de false: %d", !false);
	printf("\n");
	printf("Inverso de true %d", !true);
	printf("\n");
	
system("pause");


}

