#include <iostream>

using namespace std;

int main() {
	int n, x=1;
	
	scanf("%d",&n);
	
	for (int c =1; c <= n; c++){
		printf("%d ",x);
		printf("%d ",x * x);
		printf("%d\n",x * x * x);
		printf("%d ",x);
		printf("%d ",x * x + 1);
		printf("%d\n",x * x * x + 1);
		x++;
	}
	
	
	return 0;
}
