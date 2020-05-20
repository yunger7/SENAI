#include <iostream>
#include <string.h>
using namespace std;

int main(){
	char nome[50];
	
	printf("Digite um nome: \n");
	gets(nome);
	printf("Tem %ld caracteres",strlen(nome));
	
	return 0;
}
