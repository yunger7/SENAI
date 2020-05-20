#include <stdio.h>

int main(){
	float num[6];
	int i, aux;
	
	printf("Digite seis numeros: \n");
	for (int i = 0; i < 6; i++){
		scanf("%f",&num[i]);
	}
	for (int i=0; i<6; i++){
		for(int j=i+1; j<6; j++){
			if (num[i] > num[j]){
				aux = num[i];
				num[i] = num[j];
				num[j] = aux;
			}
		}
		
	}
	printf("\nOs numeros em ordem crescente sao: \n");
	for (int i = 0; i < 6; i++){
		printf("%g\n",num[i]);
	}
	
	return 0;
}
