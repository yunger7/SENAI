#include <stdlib.h>
#include <stdio.h>
#include <time.h>

int main() {
	srand(time(NULL));
	int num = rand() % 100 + 1;
	int chute;
	printf("QUE COMECEM OS JOGOS\n");
	while(chute != num){
		printf("Chute: ");
		scanf("%d",&chute);
		
		if(chute > num){
			printf("Muito alto!\n");
		} else if (chute < num){
			printf("Muito baixo!\n");
		} else {
			printf("VOCE ACERTOU!\n");
		}
	}
	printf("FIM DE JOGO!\n");
	return 0;
}
