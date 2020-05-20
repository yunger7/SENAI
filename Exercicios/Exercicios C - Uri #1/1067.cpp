#include <stdio.h>

int main(){
	int x=1, stop;
	
	scanf("%d",&stop);
	
	do {
		if(x % 2 != 0) {
			printf("%d\n",x);
			x++;
		} else {
			x++;
		}
	
	} while(x != stop);
	if(x % 2 != 0){
	printf("%d\n",x);
	}
	
	return 0;
}
