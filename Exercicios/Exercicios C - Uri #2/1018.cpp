#include <iostream>

using namespace std;

int main() {
	int input, resto;
	scanf("%d",&input);
	
	printf("%d\n",input);
	if (input >= 100){
		resto = input / 100;
		input -= resto * 100;
		printf("%d nota(s) de R$ 100,00\n",resto);
	} else {
		printf("0 nota(s) de R$ 100,00\n");
	}
	if (input >= 50){
		resto = input / 50;
		input -= resto * 50;
		printf("%d nota(s) de R$ 50,00\n",resto);
	} else {
		printf("0 nota(s) de R$ 50,00\n");
	}
	if (input >= 20){
		resto = input / 20;
		input -= resto * 20;
		printf("%d nota(s) de R$ 20,00\n",resto);
	} else {
		printf("0 nota(s) de R$ 20,00\n");
	}
	if (input >= 10){
		resto = input / 10;
		input -= resto * 10;
		printf("%d nota(s) de R$ 10,00\n",resto);	
	} else {
		printf("0 nota(s) de R$ 10,00\n");
	}
	if (input >= 5){
		resto = input / 5;
		input -= resto * 5;
		printf("%d nota(s) de R$ 5,00\n",resto);
	} else {
		printf("0 nota(s) de R$ 5,00\n");
	}
	if (input >= 2){
		resto = input / 2;
		input -= resto * 2;
		printf("%d nota(s) de R$ 2,00\n",resto);	
	} else {
		printf("0 nota(s) de R$ 2,00\n");
	}
	if (input >= 1){
		resto = input / 1;
		input -= resto * 1;
		printf("%d nota(s) de R$ 1,00\n",resto);
	} else {
		printf("0 nota(s) de R$ 1,00\n");
	}
	return 0;
}
