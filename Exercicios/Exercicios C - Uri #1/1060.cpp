#include <stdio.h>

int main (){
	double n, soma = 0, media;
	int quant = 0, cont;
	
	for (cont = 1; cont <=6; cont++){
		scanf("%lf",&n);
		if (n>0){
			quant++;
			soma += n;
		}
	}
	media = soma / quant;
	printf("%d valores positivos\n",quant);
	printf("%.1lf\n",media);
	
	return 0;
}
