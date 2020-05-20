#include <iostream>

using namespace std;

int main() {
	int cod, quant;
	float total;
	
	scanf("%i %i",&cod, &quant);
	//scanf("%i",&quant);
	
	if (cod == 1){
		total = quant * 4;
	}
	if (cod == 2){
		total = quant * 4.5;
	}
	if (cod == 3){
		total = quant * 5;
	}
	if (cod == 4){
		total = quant * 2;
	}
	if (cod == 5){
		total = quant * 1.5;
	}
	
	printf("Total: R$ %.2f\n",total);
	return 0;
}
