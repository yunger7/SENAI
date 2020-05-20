#include <iostream>

using namespace std;

int main() {
	int x=0;
	
	scanf("%d",&x);
	
	if (x % 2 == 0){
		x++;
		for (int c = 1; c <= 6; c++){
			printf("%d\n",x);
			x += 2;
		}
	} else {
		for (int c = 1; c <= 6; c++){
		printf("%d\n",x);
		x += 2;
		}
	}

	return 0;
}
