#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL,"Portuguese");
	int n;
	
	printf("Digite um número: ");
	scanf("%d",&n);
	
	if(n > 20 && n < 80){
		printf("parabéns");
		
	} else {
		printf("errooouu");
	}
	
	return 0;
}
