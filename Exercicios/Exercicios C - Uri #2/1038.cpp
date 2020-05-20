#include <iostream>

using namespace std;

int main(){
	float quant;
	int codigo;
	scanf("%d%f",&codigo, &quant);
	
	switch(codigo){
		case 1:	
			printf("Total: R$ %.2f\n",quant*4);
			break;
		case 2:
			printf("Total: R$ %.2f\n",quant*4.5);
			break;	
		case 3:
			printf("Total: R$ %.2f\n",quant*5);
			break;
		case 4:
			printf("Total: R$ %.2f\n",quant*2);
			break;
		case 5:
			printf("Total: R$ %.2f\n",quant*1.5);
	}
	return 0;
}
