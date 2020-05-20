#include <iostream>
#include <string.h>

using namespace std;

char a1[256],a2[256],a3[256];
void animal(char a1[], char a2[], char a3[]){
	if(strcmp(a1,"vertebrado")==0){
		if(strcmp(a2,"ave")==0){
			if(strcmp(a3,"carnivoro")==0){
				printf("aguia\n");
			} else {
				printf("pomba\n");
			}
		} else {
			if(strcmp(a3,"onivoro")==0){
				printf("homem\n");
			} else {
				printf("vaca\n");
			}
		}
	} else {
		if(strcmp(a2,"inseto")==0){
			if(strcmp(a3,"hematofago")==0){
				printf("pulga\n");
			} else {
				printf("lagarta\n");
			}
		} else {
			if(strcmp(a3,"hematofago")==0){
				printf("sanguessuga\n");
			} else {
				printf("minhoca\n");
			}
		}
	}
}

int main() {
	scanf("%s",a1);
	scanf("%s",a2);
	scanf("%s",a3);
	animal(a1, a2, a3);
	
	return 0;
}
