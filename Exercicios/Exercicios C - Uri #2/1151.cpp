#include <iostream>

using namespace std;

int main() {
	int n, i=0, fib[46];
	fib[0] = 0;
	fib[1] = 1;
	fib[2] = 1;
	
	scanf("%d",&n);
	
	switch(n){
		case 0:
			return 0;
			break;
		case 1:
			printf("%d\n",fib[0]);
			break;
		case 2:
			printf("%d %d\n",fib[0],fib[1]);
			break;
		case 3:
			printf("%d %d %d\n",fib[0],fib[1],fib[2]);
			break;
		default:
			printf("%d %d %d",fib[0],fib[1],fib[2]);
			for (i=3; i<n; i++){
				fib[i] = fib[i-1] + fib[i-2];
				printf(" %d",fib[i]);
			}
			printf("\n");
	}
	
	
	
	return 0;
}
