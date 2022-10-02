#pragma once
#include<iostream>
#include<string>
using namespace std;
//Створюємо клас Longlong
class Longlong
{
public:
	//Задаємо змінні
	long  first_x;
	unsigned long first_y;
	long  second_x;
	unsigned long second_y;
	double result,x,y;
	string str;
	//Декларуємо конструктори
	Longlong();
	Longlong(long x1, unsigned long x2, long y1, unsigned long y2);
	Longlong(long x1, unsigned long x2, long y1, unsigned long y2, string str);
	//Декларуємо функції
	Longlong Init(long  first_x = 0, unsigned long first_y = 0, long  second_x = 0, unsigned long second_y = 0);
	Longlong read();
	void display();
	Longlong addition();
	Longlong addition(double x, double y);
	Longlong subtraction();
	Longlong subtraction(double x, double y);
	Longlong multiplication();
	Longlong multiplication(double x, double y);
	Longlong division();
	Longlong division(double x, double y);
	Longlong toString();
};

