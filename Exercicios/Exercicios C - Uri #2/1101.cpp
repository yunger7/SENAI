#include <iostream>

using namespace std;

int main() {
	int m, n;
	
	do {
	scanf("%d %d",&m, &n);
	int soma=0;
	if (m <= 0 || n <= 0){
		return 0;
	}
	else if (m > n){
		while (n <= m){
			printf("%d ",n);
			soma += n;
			n++;
		}
		printf("Sum=%d\n",soma);
	} else if (m < n){
		while (m <= n){
			printf("%d ",m);
			soma += m;
			m++;
		}
		printf("Sum=%d\n",soma);
	}
	
} while (m > 0 || n > 0);
	return 0;
}
