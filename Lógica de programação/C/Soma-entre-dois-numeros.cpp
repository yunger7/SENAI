#include <stdio.h>

main (){
	double n1=0, n2=0, soma=0;
	
	printf("Digite dois numeros: ");
	scanf("%lf %lf",&n1, &n2);
	
	soma = n1 + n2;
	if (soma > 10){
		printf("Soma dos numeros informados: %lf",soma);
	}
}
