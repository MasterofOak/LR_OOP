#pragma once
#include<iostream>
#include<string>
using namespace std;
//Створюємо клас Longlong
class Longlong
{
	//Задаємо змінні
	long  first_x;
	unsigned long first_y;
	long  second_x;
	unsigned long second_y;
	double result, x, y;
	string str;
	public:
	//Декларуємо функції
	Longlong Init(long  first_x = 0, unsigned long first_y = 0, long  second_x = 0, unsigned long second_y = 0);
	Longlong read();
	void display();
	Longlong addition();
	Longlong subtraction();
	Longlong multiplication();
	Longlong division();
	Longlong toString();
};

