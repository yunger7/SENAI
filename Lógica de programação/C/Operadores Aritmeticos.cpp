#include <stdio.h>
#include <locale.h>

main(){
setlocale(LC_ALL,"Portuguese");
//Declaracao das vari�veis:
	int num1 = 20;
	int num2 = 50;
	float num3 = 13.17;

//C�digo:
	//Soma:
		printf("Soma entre o primeiro e o segundo: ");
		printf("%d\n", num1 + num2);
	
	//Subtra��o:
		printf("Subtra��o entre o primeiro e o segundo: ");
		printf("%d\n", num1 - num2);
		
	//Multiplica��o:
		printf("Multiplica��o entre o primeiro e o segundo: ");
		printf("%d\n", num1 * num2);
		
	//Divis�o:
		printf("Divis�o entre o terceiro e o segundo: ");
		printf("%.2f\n", num3 / num2);
		
	//Modulo da divis�o:
	printf("Resto da divis�o do segundo numero por 3: ");
		printf("%.2f\n", num2 % 3);
}
