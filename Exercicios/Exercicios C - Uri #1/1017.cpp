#include <iostream>

using namespace std;

int main() {
	int tempo, velocidade;
	float distancia, litros;
	
	scanf("%i",&tempo);
	scanf("%i",&velocidade);
	
	distancia = velocidade * tempo;
	litros = distancia / 12;
	
	printf("%.3f\n",litros);	
	
	return 0;
}
