#include <stdio.h>

int main(){
	int n;
	
	printf("Digite um numero do teclado: ");
	scanf("%d",&n);
	
		if (n % 10 == 0){
			printf("Divisivel por 10\n");
		}
		if (n % 5 == 0){
			printf("Divisivel por 5\n");
		}
		if (n % 2 == 0){
			printf("Divisivel por 2\n");
		}
		if (n % 10 != 0 && n % 5 != 0 && n % 2 != 0){
			printf("Nao e divisivel por 10, 5 ou 2");
		}
	
	return 0;
}
