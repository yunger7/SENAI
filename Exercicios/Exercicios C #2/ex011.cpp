#include <iostream>
#include <locale.h>
using namespace std;

int main(){
	setlocale (LC_ALL,"Portuguese");
	float A, B;
    while(A!=0){
        scanf("%f",&A);
        if(A>B){
            B=A;
        }
    }
    printf("\n %f é maior\n",B);

	
	return 0;
}
