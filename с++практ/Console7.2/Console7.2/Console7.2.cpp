#include "pch.h"
#include <iostream>
#include <cstring>



int main()
{
	char s[] = "This is string";
	char s1[] = "IZ";
	const int i = 4;
	char str[40];
	
	strncpy_s(str, s, i);  

	std::cout << str << std::endl;   

	strncat_s(str, s1, strlen(s1));

	std::cout << str << std::endl;

	strncat_s(str, s + 5, 20);


	std::cout << str << std::endl;

	return 0;
}
