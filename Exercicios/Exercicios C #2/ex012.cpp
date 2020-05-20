#include <iostream>
using namespace std;

int main(){
	int cont;
	float soma, n;
	for (cont=0; cont<20; cont++){
		scanf("%f",&n);
		soma += n;
	}
	printf("\nA soma e: %f",soma);
	return 0;
}
