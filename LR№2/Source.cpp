#include<iostream>
#include<string>
#include"Longlong.h"
using namespace std;

//Розписуємо функцію Init для того щоб можно було звертатися до змінних в класі
Longlong Longlong::Init(long  first_x , unsigned long first_y, long  second_x , unsigned long second_y ) {
	Longlong tmp;
	tmp.first_x = first_x;
	tmp.first_y = first_y;
	tmp.second_x = second_x;
	tmp.second_y = second_y;
	return tmp;
}

//Розписуємо функцію read для введення початкових даних
Longlong Longlong::read() {
	Longlong tmp;
	cout << "Input first number" << endl;
	cout << "Input first half of the number" << endl;
	cin >> tmp.first_x;
	cout << "Input second half of the number" << endl;
	cin >> tmp.first_y;
	cout << "Input second number"<<endl;	
	cout << "Input first half of the number" << endl;
	cin >> tmp.second_x;
	cout << "Input second half of the number" << endl;
	cin >> tmp.second_y;
	return tmp;
}

//Розаисуємо функцію display яка буде виводити усі потрібні розрахунки з інших функцій
void Longlong::display() {
	addition();
	toString();
	cout << "Result of addition " << str << endl;
	subtraction();
	toString();
	cout << "Result of subtraction " << str << endl;
	multiplication();
	toString();
	cout << "Result of multiplication " << str << endl;
	division();
	toString();
	cout << "Result of division " << str << endl;
}

//Функція addition бере і додає введені нами дані
Longlong Longlong::addition() {
	Longlong tmp{};
	//Перенесосимо змінні first_y та first_y для зручності
	x = first_y;
	y = second_y;
	//Виконуємо пару циклів для того щоб в змінних x та y цілу частину перенести в дробову
	while (x >= 1)
	{
		x = x / 10.0;
	}
	while (y >= 1)
	{
		y = y / 10.0;
	}
	result = (first_x + x) + (second_x + y);
	return tmp;
}

//Функція subtraction бере і віднімає введені нами дані
Longlong Longlong::subtraction() {
	Longlong tmp{};
	//Перенесосимо змінні first_y та first_y для зручності
	x = first_y;
	y = second_y;
	//Виконуємо пару циклів для того щоб в змінних x та y цілу частину перенести в дробову
	while (x >= 1)
	{
		x = x / 10.0;
	}
	while (y >= 1)
	{
		y = y / 10.0;
	}
	result = (first_x + x) - (second_x + y);
	return tmp;
}

//Функція multiplication бере і множе введені нами дані
Longlong Longlong::multiplication() {
	Longlong tmp{};
	//Перенесосимо змінні first_y та first_y для зручності
	x = first_y;
	y = second_y;
	//Виконуємо пару циклів для того щоб в змінних x та y цілу частину перенести в дробову
	while (x >= 1)
	{
		x = x / 10.0;
	}
	while (y >= 1)
	{
		y = y / 10.0;
	}
	result = (first_x + x) * (second_x + y);
	return tmp;
}

//Функція division бере і діле введені нами дані
Longlong Longlong::division() {
	Longlong tmp{};
	//Перенесосимо змінні first_y та first_y для зручності
	x = first_y;
	y = second_y;
	//Виконуємо пару циклів для того щоб в змінних x та y цілу частину перенести в дробову
	while (x >= 1)
	{
		x = x / 10.0;
	}
	while (y >= 1)
	{
		y = y / 10.0;
	}
	result = (first_x + x) / (second_x + y);
	return tmp;
}

//Функція toString бере цисло із змінної result і переводе її у текст
Longlong Longlong::toString() {
	Longlong tmp{};
	str = to_string(result);
	return tmp;
}

//Задаємо роботу програми
int main(){
	Longlong case1;
	case1 = case1.Init();
	case1 = case1.read();
	case1.display();
	system("pause");
}