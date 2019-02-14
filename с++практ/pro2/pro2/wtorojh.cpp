#include "pch.h"
#include "wtorojh.h"
#include <iostream>
using namespace std;

long double fact(double k)
{
	if (k < 0) // ���� ������������ ���� ������������� �����
		return 0; // ���������� ����
	if (k == 0) // ���� ������������ ���� ����,
		return 1; // ���������� ��������� �� ���� - �� �����������, �� ��� 1 =)
	else // �� ���� ��������� �������
		return k * fact(k - 1); // ������ ��������.
}

int wtorojh()
{
	double x;
	double e = 0.000001;
	cout << "������� �������� �: �� 0 �� 1: ";
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