#include <stdio.h>

int main() {
	float salario=0, novo_salario=0, reajuste_ganho=0;
	char ch='%';
	int reajuste_percentual=0;
	
	scanf("%f",&salario);
	if(salario >= 0 && salario <= 400.00){
		reajuste_ganho = salario * 0.15;
		novo_salario = salario * 1.15;
		reajuste_percentual = 15;
		
	}else if(salario >= 400.01 && salario <= 800.00){
		reajuste_ganho = salario * 0.12;
		novo_salario = salario * 1.12;
		reajuste_percentual = 12;
		
	}else if(salario >= 800.01 && salario <= 1200.00){
		reajuste_ganho = salario * 0.1;
		novo_salario = salario * 1.1;
		reajuste_percentual = 10;
		
	}else if(salario >= 1200.01 && salario <= 2000.00){
		reajuste_ganho = salario * 0.07;
		novo_salario = salario * 1.07;
		reajuste_percentual = 7;
		
	}else if(salario > 2000.00){
		reajuste_ganho = salario * 0.04;
		novo_salario = salario * 1.04;
		reajuste_percentual = 4;
	}
	
	printf("Novo salario: %.2f\n",novo_salario);
	printf("Reajuste ganho: %2.f\n",reajuste_ganho);
	printf("Em percentual: %d %c\n",reajuste_percentual,ch);
	
	return 0;
}
