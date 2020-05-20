#include <iostream>

int main() {
	double media=0, n=0;
	int pos=0;
	
	for (int c = 1; c <= 6; c++){
		scanf("%lf",&n);
		if (n > 0){
			pos++;
			media += n;
		}
	}
	media /= pos;
	printf("%d valores positivos\n",pos);
	printf("%.1lf\n",media);
	
	return 0;
}
