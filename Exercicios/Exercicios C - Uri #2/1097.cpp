#include <iostream>

using namespace std;

int main() {
	int i=1, j=7;
	while (i <= 9){
		for (int c=1; c <= 3; c++){
			printf("I=%d ",i);
			printf("J=%d\n",j);
			j -= 1;
		}
		i += 2;
		j += 5;
	}
	return 0;
}
