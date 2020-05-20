#include <iostream>

using namespace std;

int main() {
	float salario, imposto;
	scanf("%f",&salario);
	
	if (salario <= 2000) {
		printf("Isento\n");
	} else {
		if (salario <= 3000){
			salario -= 2000;
			imposto = salario * 0.08;
		} else if (salario <= 4500){
			salario -= 3000;
			imposto = salario * 0.18 + 80;
		} else {
			salario -= 4500;
			imposto = salario * 0.28 + 270 + 80;
		}	
		
		printf("R$ %.2f\n",imposto);
	}
	
	return 0;
}
