#include <iostream>

using namespace std;

int main() {
	int x, y, casos;
	
	scanf("%d",&casos);
	
	for (int a=1; a <= casos; a++){
		scanf("%d",&x);
		scanf("%d",&y);
		int soma=0;
		if (x > y){
			y++;
			while (y < x){
				if (y % 2 != 0){
					soma += y;
				}
				y++;
			}
		} else if (x < y){
			x++;
			while (x < y){
				if (x % 2 != 0){
					soma += x;
				}
				x++;
			}
		} 
		printf("%d\n",soma);
	}
	
	return 0;
}
