#include "pch.h"
#include <iostream>
#include <locale>
#include <cstdlib>
#include <stdio.h>
#include <string.h>

#include <ctype.h>


using namespace std;


int main()
{

	setlocale(LC_ALL, "ru");

	unsigned char predlog[] = "Wsem Priwet, №№26б привет!!!!";
	char mas2[30] = {"a"};
	int j = 0;
	for (int i = 0; predlog[i] != '\0'; i++)
	{
		if ((isalpha(predlog[i])) || (predlog[i] == ' '))
		{
			mas2[j++] = predlog[i];
		}
		
	}
	mas2[j] = '\0';

	for (int i = 0; mas2[i] != '\0'; ++i)  // замена на прописную букву
	{
		if (mas2[i] >= 'A' && mas2[i] <= 'Z')
			mas2[i] = mas2[i] + 'a' - 'A';
	}

	cout << endl;

	for (int i = 0; mas2[i] != '\0'; i++)  // выыод на экран
	{
		cout << mas2[i];
	}

	cout << endl;

	return 0;

}
