#include <stdio.h>
#include <locale.h>

main(){
setlocale(LC_ALL,"Portuguese");
//Declaracao das vari�veis:
	int num1 = 20;
	int num2 = 50;
	float num3 = 13.17;

//C�digo:
	printf("Opera��es usando operadores relacionais: \n");
	printf("\n");
	//Maior que
		printf("Opera��o usando o maior que: \n");
		printf("%d � maior que %d ? %d \n",num1 , num2, num1 > num2 );
		printf("\n");
		
	//Maior ou igual
		printf("Opera��o usando o maior ou igual: \n");
		printf("%d � maior ou igual %d ? %d \n",num1 , num2, num1 >= num2 );
		printf("\n");
		
	//Menor que
		printf("Opera��o usando o menor que: \n");
		printf("%d � menor que %d ? %d \n",num1 , num2, num1 < num2 );
		printf("\n");
		
	//Menor ou igual
		printf("Opera��o usando o menor ou igual: \n");
		printf("%d � menor ou igual %d ? %d \n", 5, 10 , 5 <= 10 );
		printf("\n");
		
	//Igual a
		printf("Opera��o usando igual a: \n");
		printf("O resto da divis�o de %d por 5 � igual a 0 ? %d \n",num1, (num1 % 5) == 0);
		printf("\n");
		
	//Diferen�a
		printf("Opera��o usando diferente de: \n");
		printf("O resto da divis�o de %d por 5 � diferente a 0 ? %d",num1, (num1 % 5) != 0);
		
		
		
		
		
		
}
