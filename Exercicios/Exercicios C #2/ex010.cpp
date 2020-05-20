#include <iostream>

using namespace std;

int main(){
	float n;
	
	printf("Digite um numero entre 1 e 4: \n");
	scanf("%f",&n);
	
	while(n<1 || n>4){
		printf("Entrada invalida. Digite novamente: \n");
		scanf("%f",&n);		
	}
	printf("Numero digitado: %f\n",n);	
	return 0;
}
