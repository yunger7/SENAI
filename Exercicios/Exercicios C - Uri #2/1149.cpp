#include <iostream>

using namespace std;

int main() {
	int a, n, soma=0;
	
	scanf("%d",&a);
	
	do {
		scanf("%d",&n);
	} while(n <= 0);
	for (int i=0; i <= n - 1; i++){
		soma += a + i;
	}
	printf("%d\n",soma);
	
	return 0;
}
