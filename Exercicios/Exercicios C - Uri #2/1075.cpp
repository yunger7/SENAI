#include <iostream>

using namespace std;

int main() {
	int n;
	scanf("%d",&n);
	
	for (int cont = 1; cont <= 10000; cont++){
		if (cont % n == 2){
			printf("%d\n",cont);
		}
		
	}
	
	return 0;
}
