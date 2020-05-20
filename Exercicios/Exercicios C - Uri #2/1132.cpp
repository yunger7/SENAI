#include <iostream>

using namespace std;

int main() {
	int x, y, soma;
	scanf("%d %d",&x, &y);
	
	if (x > y){
		while (y <= x){
			if (y % 13 == 0){
				y++;
			} else {
				soma += y;
				y++;
			}
			
		}
	} else if (y > x){
		while (x <= y){
			if (x % 13 == 0){
				x++;
			} else {
				soma += x;
				x++;
			}
			
		}
	}
	
	printf("%d\n",soma);
	
	return 0;
}
