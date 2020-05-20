#include <iostream>

using namespace std;

int main() {
	int numero, horas;
	float sal_p_hora, salario;
	
	scanf("%i",&numero);
	scanf("%i",&horas);
	scanf("%f",&sal_p_hora);
	
	salario = sal_p_hora * horas;
	
	printf("NUMBER = %i\n",numero);
	printf("SALARY = U$ %.2f\n",salario);
	
	return 0;
}
