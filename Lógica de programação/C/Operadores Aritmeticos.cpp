#include <stdio.h>
#include <locale.h>

main(){
setlocale(LC_ALL,"Portuguese");
//Declaracao das variáveis:
	int num1 = 20;
	int num2 = 50;
	float num3 = 13.17;

//Código:
	//Soma:
		printf("Soma entre o primeiro e o segundo: ");
		printf("%d\n", num1 + num2);
	
	//Subtração:
		printf("Subtração entre o primeiro e o segundo: ");
		printf("%d\n", num1 - num2);
		
	//Multiplicação:
		printf("Multiplicação entre o primeiro e o segundo: ");
		printf("%d\n", num1 * num2);
		
	//Divisão:
		printf("Divisão entre o terceiro e o segundo: ");
		printf("%.2f\n", num3 / num2);
		
	//Modulo da divisão:
	printf("Resto da divisão do segundo numero por 3: ");
		printf("%.2f\n", num2 % 3);
}
