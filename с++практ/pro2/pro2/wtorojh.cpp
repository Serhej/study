#include "pch.h"
#include "wtorojh.h"
#include <iostream>
using namespace std;

long double fact(double k)
{
	if (k < 0) // если пользователь ввел отрицательное число
		return 0; // возвращаем ноль
	if (k == 0) // если пользователь ввел ноль,
		return 1; // возвращаем факториал от нуля - не удивляетесь, но это 1 =)
	else // Во всех остальных случаях
		return k * fact(k - 1); // делаем рекурсию.
}

int wtorojh()
{
	double x;
	double e = 0.000001;
	cout << "Введите значение х: от 0 до 1: ";
	cin >> x;
	int k = 1;
	double sum = 0;
	double r = 1;
	while (abs(r) > e)
	{

		r = ((pow(-1, k)) / ((fact(k))*(fact(k + 1)))*(pow((x / 2), (2 * k + 1))));
		sum += r;

		++k;
		cout << r << endl;

	}
	cout << k << endl;

	cout << sum;

	return 0;
}