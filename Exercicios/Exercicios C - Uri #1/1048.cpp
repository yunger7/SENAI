#include <iostream>

using namespace std;

int main() {
	float salario, novo_salario, reajuste;
	
	scanf("%f",&salario);
	
	if(salario >= 0 && salario <= 400.00){
		novo_salario = salario + 0.15 * salario;
		reajuste = novo_salario - salario;
		printf("Novo salario: %.2f\n",novo_salario);
		printf("Reajuste ganho: %.2f\n",reajuste);
		printf("Em percentual : 15 %%\n");
		
	}else if(salario >= 400.01 && salario <= 800.00){
		novo_salario = salario + 0.12 * salario;
		reajuste = novo_salario - salario;
		printf("Novo salario: %.2f\n",novo_salario);
		printf("Reajuste ganho: %.2f\n",reajuste);
		printf("Em percentual : 12 %%\n");
		
	}else if(salario >= 800.01 && salario <= 1200.00){
		novo_salario = salario + 0.10 * salario;
		reajuste = novo_salario - salario;
		printf("Novo salario: %.2f\n",novo_salario);
		printf("Reajuste ganho: %.2f\n",reajuste);
		printf("Em percentual : 10 %%\n");
		
	}else if(salario >= 1200.01 && salario <= 2000.00){
		novo_salario = salario + 0.07 * salario;
		reajuste = novo_salario - salario;
		printf("Novo salario: %.2f\n",novo_salario);
		printf("Reajuste ganho: %.2f\n",reajuste);
		printf("Em percentual : 7 %%\n");
		
	}else if(salario > 2000.00){
		novo_salario = salario + 0.07 * salario;
		reajuste = novo_salario - salario;
		printf("Novo salario: %.2f\n",novo_salario);
		printf("Reajuste ganho: %.2f\n",reajuste);
		printf("Em percentual : 4 %%\n");
	}
	
	return 0;
}
