#include <iostream>

using namespace std;

int main() {
	int inicio, fim, duracao;
	
	scanf("%i %i", &inicio, &fim);
	
	if(inicio > fim){
	duracao = (24 - inicio) + fim;
	}
	if (inicio == fim){
	duracao = 24;				
	}
	if (inicio < fim){
	duracao = fim - inicio;
	}
	
	printf("O JOGO DUROU %i HORA(S)\n",duracao);
	
	return 0;
}
