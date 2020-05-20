#include <iostream>

using namespace std;

int main() {
	int x,y;
	do {
		scanf("%d %d",&x, &y);
		if (x < y){
			printf("Crescente\n");
		} else if (x > y){
			printf("Decrescente\n");
		}
	}while (x != y);
	
	return 0;
}
