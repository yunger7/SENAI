#include <iostream>

using namespace std;

int main() {
	int input=0, alcool=0, gasolina=0, diesel=0;
	
	do {
		scanf("%d",&input);
		while (input < 1 || input > 4){
			scanf("%d",&input);
		}
		if (input == 1){
			alcool++;
		} else if (input == 2){
			gasolina++;
		} else if (input == 3){
			diesel++;
		}
	}while (input != 4);
	
	printf("MUITO OBRIGADO\nAlcool: %d\nGasolina: %d\nDiesel: %d\n",alcool, gasolina, diesel);
	
	
	return 0;
}
