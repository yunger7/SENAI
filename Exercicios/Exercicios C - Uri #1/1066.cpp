#include <stdio.h>

int main() {
	int n, cont=0, par=0, impar=0, pos=0, neg=0;
	
	for (cont = 1; cont <= 5; cont++){
		scanf("%d",&n);
		if (n > 0){
			pos++;
		} else if (n < 0){
			neg++;
		}
		if (n % 2 == 0){
			par++;
		} else if (n % 2 != 0){
			impar++;
		}
	}
	printf("%d valor(es) par(es)\n",par);
	printf("%d valor(es) impar(es)\n",impar);
	printf("%d valor(es) positivo(s)\n",pos);
	printf("%d valor(es) negativo(s)\n",neg);

	return 0;
}
