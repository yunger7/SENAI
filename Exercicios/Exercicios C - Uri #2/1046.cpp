#include <iostream>

using namespace std;

int main() {
	int inicio, fim;
	scanf("%d %d",&inicio, &fim);
	
	if (inicio > fim){	
		printf("O JOGO DUROU %d HORA(S)\n", 24-inicio+fim);
	} else if (inicio == fim){
		printf("O JOGO DUROU 24 HORA(S)\n");
	} else {
		printf("O JOGO DUROU %d HORA(S)\n", fim-inicio);
	}
	return 0;
}
