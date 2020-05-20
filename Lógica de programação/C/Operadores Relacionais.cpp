#include <stdio.h>
#include <locale.h>

main(){
setlocale(LC_ALL,"Portuguese");
//Declaracao das variáveis:
	int num1 = 20;
	int num2 = 50;
	float num3 = 13.17;

//Código:
	printf("Operações usando operadores relacionais: \n");
	printf("\n");
	//Maior que
		printf("Operação usando o maior que: \n");
		printf("%d é maior que %d ? %d \n",num1 , num2, num1 > num2 );
		printf("\n");
		
	//Maior ou igual
		printf("Operação usando o maior ou igual: \n");
		printf("%d é maior ou igual %d ? %d \n",num1 , num2, num1 >= num2 );
		printf("\n");
		
	//Menor que
		printf("Operação usando o menor que: \n");
		printf("%d é menor que %d ? %d \n",num1 , num2, num1 < num2 );
		printf("\n");
		
	//Menor ou igual
		printf("Operação usando o menor ou igual: \n");
		printf("%d é menor ou igual %d ? %d \n", 5, 10 , 5 <= 10 );
		printf("\n");
		
	//Igual a
		printf("Operação usando igual a: \n");
		printf("O resto da divisão de %d por 5 é igual a 0 ? %d \n",num1, (num1 % 5) == 0);
		printf("\n");
		
	//Diferença
		printf("Operação usando diferente de: \n");
		printf("O resto da divisão de %d por 5 é diferente a 0 ? %d",num1, (num1 % 5) != 0);
		
		
		
		
		
		
}
