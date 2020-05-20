#include <iostream>

using namespace std;

int main() {
	float valor, resto;
	int quant;
	
	scanf("%f",&valor);
	//NOTAS:
	printf("NOTAS:\n");
	if (valor >= 100){
		quant=0;
		while (valor >= 100){
			quant++;
			valor -= 100;
		}
		printf("%d nota(s) de R$ 100.00\n",quant);
	} else {
		printf("0 nota(s) de R$ 100.00\n");
	}
	if (valor >= 50){
		quant=0;
		while (valor >= 50){
			quant++;
			valor -= 50;
		}
		printf("%d nota(s) de R$ 50.00\n",quant);
	} else {
		printf("0 nota(s) de R$ 50.00\n");
	}
	if (valor >= 20){
		quant=0;
		while (valor >= 20){
			quant++;
			valor -= 20;
		}
		printf("%d nota(s) de R$ 20.00\n",quant);
	} else {
		printf("0 nota(s) de R$ 20.00\n");
	}
	if (valor >= 10){
		quant=0;
		while (valor >= 10){
			quant++;
			valor -= 10;
		}
		printf("%d nota(s) de R$ 10.00\n",quant);
	} else {
		printf("0 nota(s) de R$ 10.00\n");
	}
	if (valor >= 5){
		quant=0;
		while (valor >= 5){
			quant++;
			valor -= 5;
		}
		printf("%d nota(s) de R$ 5.00\n",quant);
	} else {
		printf("0 nota(s) de R$ 5.00\n");
	}
	if (valor >= 2){
		quant=0;
		while (valor >= 2){
			quant++;
			valor -= 2;
		}
		printf("%d nota(s) de R$ 2.00\n",quant);
	} else {
		printf("0 nota(s) de R$ 2.00\n");
	}	
	//MOEDAS:
	printf("MOEDAS:\n");
	if (valor >= 1){
		quant=0;
		while (valor >= 1){
			quant++;
			valor -= 1;
		}
		printf("%d moeda(s) de R$ 1.00\n",quant);
	} else {
		printf("0 moeda(s) de R$ 1.00\n");
	}
	if (valor >= .5){
		quant=0;
		while (valor >= .5){
			quant++;
			valor -= .5;
		}
		printf("%d moeda(s) de R$ 0.50\n",quant);
	} else {
		printf("0 moeda(s) de R$ 0.50\n");
	}
	if (valor >= .25){
		quant=0;
		while (valor >= .25){
			quant++;
			valor -= .25;
		}
		printf("%d moeda(s) de R$ 0.25\n",quant);
	} else {
		printf("0 moeda(s) de R$ 0.25\n");
	}
	if (valor >= .1){
		quant=0;
		while (valor >= .1){
			quant++;
			valor -= .1;
		}
		printf("%d moeda(s) de R$ 0.10\n",quant);
	} else {
		printf("0 moeda(s) de R$ 0.10\n");
	}
	if (valor >= .05){
		quant=0;
		while (valor >= .05){
			quant++;
			valor -= .05;
		}
		printf("%d moeda(s) de R$ 0.05\n",quant);
	} else {
		printf("0 moeda(s) de R$ 0.05\n");
	}
	if (valor >= .01){
		quant=0;
		while (valor >= 0.01){
			quant++;
			valor -= 0.01;
		}
		printf("%d moeda(s) de R$ 0.01\n",quant);
	} else {
		printf("0 moeda(s) de R$ 0.01\n");
	}
	
	return 0;
}
