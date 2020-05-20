#include <iostream>

using namespace std;

int main() {
	int x, y, n=1, l=0;
	
	scanf("%d %d",&x, &y);
	
	for(int c=1; c <= y; c++){
		l++;
		if (l==x){
			l = 0;
			printf("%d",c);
			printf("\n");
		} else {
			printf("%d ",c);
		}
	}
	
	return 0;
}
