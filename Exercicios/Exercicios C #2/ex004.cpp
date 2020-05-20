#include <iostream>
#include <string.h>
using namespace std;

int main(){
	char nome[20];
	int i=0;
		
	printf("Digite um nome: \n");
	gets(nome);
	
	while (i < 4){
		printf("%c",nome[i]);
		i++;
	}
	
	return 0;
}
