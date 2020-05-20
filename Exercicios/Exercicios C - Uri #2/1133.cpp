#include <iostream>

using namespace std;

int main(){
	int x,y,aux;
	scanf("%d %d",&x, &y);
	
	if (x > y){
		y++;
		while(y < x){
			if (y % 5 == 2 || y % 5 == 3){
				printf("%d\n",y);
				y++;
			} else {
				y++;
			}
		}
	} else if (y > x){
		x++;
		while(x < y){
			if (x % 5 == 2 || x % 5 == 3){
				printf("%d\n",x);
				x++;
			} else {
				x++;
			}
		}
	}
	
	return 0;
}
