#include <stdio.h>

int main(){
	int cont, n, quant = 0;
	
	for(cont = 1; cont <=5; cont++){
		scanf("%d",&n);
		if (n % 2 == 0){
			quant++;
		}
	}	
	
	printf("%d valores pares\n",quant);
	return 0;
}
