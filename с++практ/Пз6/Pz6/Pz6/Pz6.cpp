// Pz6.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>

#include "stdio.h"
#include<locale>
#include<iomanip>
#include<cstdlib>


using namespace std;

int main()
{

	setlocale(LC_CTYPE, "Russian");


	// зад 5* с указателями

	const int real_size = 11;

	int mas[real_size] = { -42, -17, -76, -57, -65, -85, -64, 1, -3, -11, -15 };
	//int mas[100];
	int sum = 0;
	int kol = 0;
	int f = 0;
	int n, v;

	srand(time(nullptr));
	cout << "Рандомный массив :";
	cout << endl;

	/*for (int i = 0; i < real_size; i++)    //рандомный массив
	{
		n = (rand() % 100) - 90;
		mas[i] = n;
	}*/

	cout << "[ ";
	for (int i = 0; i < real_size; i++)
	{
		cout << mas[i] << "  ";
	}
	cout << " ]" << endl;



	cout << "Итоговый массив :";

	for (int i = 0; i < real_size - f; i++)
	{
		if (mas[i] < 0)
		{
			sum = 0;
			kol = 0;

			do {
				sum += abs(mas[i]);
				kol++;
				i++;
			} while (i < real_size - f && mas[i] < 0);
			sum = sum / kol;

			int kolich_udalen_iz_tek_posledovateln = 0;

			for (int j = i - kol; j < i - kolich_udalen_iz_tek_posledovateln; j++)
			{

				if (abs(mas[j]) > sum)
				{
					for (int r = j; r < real_size - f; ++r)

					{
						mas[r] = mas[r + 1];


					}

					kolich_udalen_iz_tek_posledovateln++;

					j = j - 1;

					f++;
				}

			}
			i = i - kolich_udalen_iz_tek_posledovateln;

		}
	}



	cout << endl << "[ ";
	for (int i = 0; i < (real_size - f); i++)
	{
		cout << mas[i] << "  ";
	}
	cout << "]" << endl;




	/*

	// зад 5.0 с указателями


	   	int   *ukaz_ind;
	int   *poz;
	int *size = new int;

	cout << "size = ";
	cin >> *size;

	int* mas = new int[*size];






	for (ukaz_ind = mas; ukaz_ind < mas + *size; ukaz_ind++)

		cin >> *ukaz_ind;

	poz = mas;

	for (ukaz_ind = mas + 1; ukaz_ind < mas + *size; ukaz_ind++) //?
	{
		if (*ukaz_ind < *poz)
		{
			poz = ukaz_ind;
		}
	}

	for (ukaz_ind = mas; ukaz_ind < mas + *size; ukaz_ind++)
	{
		cout << "  " << *ukaz_ind;
	}


	//int *temp = new int;

	//*temp = *mas;
	//*mas = *poz;
	//*poz = *temp;
	*mas = *mas^*poz;
	*poz = *poz^*mas;
	*mas = *mas^*poz;

	//delete temp;

	cout << endl;

	for (ukaz_ind = mas; ukaz_ind < mas + *size; ukaz_ind++)
	{
		cout << *ukaz_ind << " ";
	}
	delete[] mas;
	*/


	


	return 0;
}












	


// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
