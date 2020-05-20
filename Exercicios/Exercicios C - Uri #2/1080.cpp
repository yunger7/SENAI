#include <iostream>

using namespace std;

int main() {
	int x, aux=0, marc;
	for (int c=1; c<= 100; c++){
		scanf("%d",&x);
		if (x > aux){
			aux = x;
			marc = c;
		}
	}
	printf("%d\n",aux);
	printf("%d\n",marc);
	
	return 0;
}
