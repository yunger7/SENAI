#include <iostream>
using namespace std;

main(){
	int n1, n2, soma;
	
	printf("Digite um numero: ");
	cin >> n1;
	printf("\nDigite outro numero: ");
	cin >> n2;
	
	soma = n1 + n2;
	
	if(soma>35){
		printf("\nSOMA: %i\n",soma);
	}
	return 0;
}
