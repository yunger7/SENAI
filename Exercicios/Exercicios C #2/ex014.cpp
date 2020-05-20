#include <stdio.h>
#include <string.h>

int main(){
	char a = 'a', A = 'A', nome[20];
	int res;
	
	printf("Digite um nome: \n");
	gets(nome);

	for (int i=0; i < strlen(nome); i++)	{
		if (nome[i] == a || nome[i] == A){
			res++;
		}
	}

	printf("\nA letra A aparece %d vezes",res);
	return 0;
}
