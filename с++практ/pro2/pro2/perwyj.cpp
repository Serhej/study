#include "pch.h"
#include "perwyj.h"
#include <iostream>




void perwyj()
{
	
	int a = 0;
	using namespace std;

	cout << "Введите четырехчначное число: \n";
	cin >> a;

	if (a == 1111 || a == 2222 || a == 3333 || a == 4444 || a == 5555 || a == 6666 || a == 7777 || a == 8888 || a == 9999)
	{
		cout << "Вы ввели повторяющиеся цифры";
	}
	else
	{
		cout << "Вы ввели число без повторений";
	}
	
}