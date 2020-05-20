#include <iostream>

using namespace std;

int main() {
	int n, cont, cont2=1;
	
	scanf("%d",&n);
	
	for(cont=1; cont <= n; cont++){
		for(int c=1; c <= 3; c++){
			printf("%d ",cont2);
			cont2++;
		}
		printf("PUM\n");
		cont2++;
	}
	
	
	return 0;
}
