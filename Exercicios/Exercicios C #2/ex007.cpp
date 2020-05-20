#include <stdio.h>

int main(){
	float n1, n2;
	
	printf("Digite um valor: ");
	scanf("%f",&n1);
	printf("Digite outro valor: ");
	scanf("%f",&n2);
	
	if (n1 + n2 > 10){
		printf("Soma: %f", n1+n2);
	}
	
	return 0;
}
