

#include "pch.h"
#include <iostream>
#include <locale>
#include "perwyj.h"
#include "wtorojh.h"
#include <math.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	
	int b;
	
	cout << "Введит кокое действие вы хотите посмотреть: \n";
	cin >> b;

	switch (b)
	{
	case 1: perwyj(); break;
	case 2: wtorojh() ; break;
	default:;
	}


	return 0;
}
