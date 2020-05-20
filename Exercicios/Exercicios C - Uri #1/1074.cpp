#include <stdio.h>

int main(){
	int n, x, cont;
	
	scanf("%d",&n);
	
	for(cont=1; cont <= n; cont++) {
		scanf("%d",&x);
			if(x % 2 != 0){ //impar
				if (x > 0){ //impar positivo
					printf("ODD POSITIVE\n");
				} else if (x < 0){ // impar negativo
					printf("ODD NEGATIVE\n");
				}
				
			} else { //par
				if (x > 0){ //par positivo
				printf("EVEN POSITIVE\n");
			} else if (x < 0){ //par negativo
				printf ("EVEN NEGATIVE\n");
			} else { //zero
				printf("NULL\n");
			}
	}
}
	
	
	return 0;
}
