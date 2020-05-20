#include <iostream>

int main() {
	float n;
	int pos;
	
	for (int c = 1; c <= 6; c++){
		scanf("%f",&n);
		if (n > 0){
			pos++;
		}
	}
	printf("%d valores positivos\n",pos);
	
	return 0;
}
