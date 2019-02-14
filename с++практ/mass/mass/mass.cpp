#include "stdafx.h"
#include <iostream>
#include <locale>
#include <cstdlib>

using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "rus");
	srand(time(0));




	int *size = new int;
	cout << "¬ведите колиество символов в массиве" << endl;
	cin >> *size;
	int *mass = new int[*size];

	for (int *i = mass; i < mass + *size; i++) // заполнение массива случайными числами
	{
		*i = (rand() % 20) - 10;
	}

	for (int *i = mass; i < mass + *size; i++) //вывод массива
	{
		cout << *i << "\t";
	}

	for (int *i = mass; i < mass + *size; i++)
	{
		if ((*i < 0) && (*(i + 1) < 0) && (i < mass + *size)) // выход  - проверка выхода из массива
		{
			int sum = 0, sred = 0, tmp = 0;

			for (int *j = i; (*j < 0) && (j < mass + *size); j++)  // выход  - проверка выхода из массива

			{
				sum += *j; // fabs //cmath.

				tmp++;
			}
			sred = fabs(sum / tmp);
			if (sred != 0)
			{
				for (int *q = i; (q < (i + tmp)) && (q < mass + *size); q++)
				{
					if (fabs (*q) > sred)
					{
						*q = 50;
					}
				}
			}
		}
	}
	cout << endl << endl;
	for (int *i = mass; i < mass + *size; i++) //вывод массива
	{
		cout << *i << "\t";
	}





	//const int SIZE = 15;
	//int mass[SIZE]; // = { 1, -2, -3, -4, 45, 54, 34, 45, 34, 3, 4, 5, -5, -2, -23 };

	//	for (int i = 0; i < SIZE; i++) // заполнение массива случайными числами
	//	{
	//		mass[i] = (rand() % 20) - 10;
	//	}

	//	for (int i = 0; i < SIZE; i++) //вывод массива
	//	{
	//		cout << mass[i] << "\t";
	//	}

	//	for (int i = 0; i < SIZE; i++)
	//	{
	//		if ((mass[i] < 0) && (mass[i + 1] < 0) && (i < SIZE)) // выход  - проверка выхода из массива
	//		{
	//			int sum = 0, sred = 0, tmp = 0;

	//			for (int j = i; (mass[j] < 0) && (j < SIZE); j++)  // выход  - проверка выхода из массива

	//			{
	//				sum += mass[j]; // fabs //cmath.

	//				tmp++;
	//			}
	//			sred = fabs(sum / tmp);
	//			if (sred != 0)
	//			{
	//				for (int q = i; (q < (i + tmp)) && (q < SIZE); q++)
	//				{
	//					if (fabs(mass[q]) > sred)
	//					{
	//						mass[q] = 50;
	//					}
	//				}
	//			}
	//		}
	//	}
	//	cout << endl << endl;
	//	for (int i = 0; i < SIZE; i++) //вывод массива
	//	{
	//		cout << mass[i] << "\t";
	//	}






	/*6.3 динамика
	srand(time(0));

	int *mass = new int[100];

	for (int *i = mass; i != mass + 100; i++) // заполнение массива случайными числами
	{
		*i = (rand() % 100) - 50;
	}
	   
	for (int *i = mass; i < mass + 100; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}
	*/


	/* 6.2
	int *size = new int;

	cout << "¬ведите количество символов в массиве: \n";
	cin >> *size;

	srand(time(0));

	int *mass = new int[*size];

	for (int *i = mass; i < mass + *size; i++)
	{
		*i = (rand()%40)-20; 
	}

	for (int *i = mass; i < mass + *size; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}
	cout << endl;
	for (int *i = mass; i != mass + *size; i++)  // сравнение одинаковых чисел и замена их на 0
	{
		for (int *j = mass+1; j < mass + *size; j++)
		{
			if (*i == -(*j))
			{
				*i = 0;
				*j = 0;
			}
		}
	}

	for (int *i = mass; i < mass + *size; i++) // нахождение чисел больше 8
	{
		if (*i > 8)
		{
			*i = -1;
		}
	}

	for (int *i = mass; i < mass + *size; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}
	*/


	/* 6.1
	int *size = new int;
	
	cout << "¬ведите количество символов в массиве: \n";
	cin >> *size;

	int *mass = new int[*size];

	cout << "¬ведите символы в массив: \n";
	for  (int *i = mass; i < mass + *size; i++)
	{
		cin >> *i; cout;
	}

	int *lsize = new int(0);
	int *msize = new int(0);
	
	for (int *i = mass; i < mass + *size; *i++)
	{
		if ((*i % 2) == 0)
			*lsize += 1;
		else
			*msize += 1;
	}

	int *l2 = new int[*lsize];
	int *m1 = new int[*msize];

	for (int *i = mass, *l = l2, *m = m1; i < mass + *size; *i++)
	{
		if ((*i % 2) == 0)
		{
			*l++ = *i;
		}
		else
		{
			*m++ = *i;
		}
			
	}

	for (int *i = mass; i < mass + *size; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}
	cout << endl;
	for (int *i = l2; i < l2 + *lsize; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}
	cout << endl;
	for (int *i = m1; i < m1 + *msize; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}

	delete size;
	delete[] mass;
	delete[] l2;
	delete[] m1;
	delete lsize;
	delete msize;
	*/

	/*  6.0 работает
	int size;

	cout << "¬ведите количество символов в массиве: \n";
	cin >> size;

	int *mass = new int[size];
	
	srand(time(0));
	
	for (int *p = mass; p  != mass + size; p++) // заполнение случайными числами
	{
		*p = rand() % 20;
	}

	for (int *i = mass; i != mass + size; i++) // вываод массива на экран
	{
		cout << *i << "\t";
	}
		
	int *min = mass;
	for (int *i = mass; i != mass + size; i++) // нахождение минимального значени€
	{
		if (*i < *min)
		{
			min = i; // *min = *i;
		}
	}
	cout << endl << *min << "\t" <<  min << endl;

	int tmp = *mass;
	*mass = *min;
	*min = tmp;
	//swap(mass, 0, )
	for (int i = 0; i < size; i++) // вываод массива на экран
	{
		cout << mass[i] << "\t";
	}
	
	delete[] mass;
	*/

	return 0;
}

