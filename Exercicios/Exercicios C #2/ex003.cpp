#include <iostream>
#include <locale.h>
using namespace std;

main(){
	setlocale (LC_ALL,"Portuguese");
	int n1;
	
	printf("Digite um numero: ");
	scanf("%i",&n1);
	
	if(n1>20){
		printf("\n%i � maior que 20\n",n1);
	}
	if(n1==20){
		printf("\n%i � igual a 20\n",n1);
	}
	if(n1<20){
		printf("\n%i � menor que 20\n",n1);
	}
	
	return 0;
}
