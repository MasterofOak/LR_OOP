#include<iostream>
#include<string>
#include"Longlong.h"
using namespace std;

//Розписуємо функцію Init для того щоб можно було звертатися до змінних в класі
Longlong Longlong::Init(long  first_x, unsigned long first_y, long  second_x, unsigned long second_y) {
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
	cout << "Input second number" << endl;
	cout << "Input first half of the number" << endl;
	cin >> tmp.second_x;
	cout << "Input second half of the number" << endl;
	cin >> tmp.second_y;
	return tmp;
}

//Розаисуємо функцію display яка буде виводити усі потрібні розрахунки з інших функцій
void Longlong::display() {
	addition();
	subtraction();
	multiplication();
	division();
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
	cout << "Result of addition: ";
	toString();
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
	cout << "Result of substraction: ";
	toString();
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
	cout << "Result of multiplcation: ";
	toString();
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
	cout << "Result of division: ";
	toString();
	return tmp;
}

//Функція toString бере цисло із змінної result і переводе її у текст
Longlong Longlong::toString() {
	Longlong tmp{};
	str = to_string(result);
	cout <<result << endl;
	return tmp;
}

//Перший конструктор який просто виводе текст на екран коли визивается клас
Longlong::Longlong() {
	cout << endl << "-----You called class Longlong-----" << endl;
}

//Другий конструктор який заміняє функції read та Init
Longlong::Longlong(long x1, unsigned long x2, long y1, unsigned long y2) {
		first_x = x1;
		first_y = x2;
		second_x = y1;
		second_y = y2;
		cout << "Information about the first number:" << endl;
		cout << "Your first half of the number: " << first_x << endl;
		cout << "Your second half of the number: " << first_y << endl;
		cout << "Information about second number:" << endl;
		cout << "Your first half of the number: " << second_x << endl;
		cout << "Your second half of the number: " << second_y << endl;
}

//Третій конструктор який дає змогу вибрати ариф.операцію на вибір
Longlong::Longlong(long x1, unsigned long x2, long y1, unsigned long y2,string str) {
	first_x = x1;
	first_y = x2;
	second_x = y1;
	second_y = y2;
	if (str == "addition")
	{
		addition();
	}
	if (str == "subtraction")
	{
		subtraction();
	}
	if (str == "multiplication")
	{
		multiplication();
	}
	if (str == "division")
	{
		division();
	}
}

//Задаємо роботу програми
int main() {
	Longlong test1(2323, 677, 232, 6565);
	test1.display();
	Longlong test2(76895, 27, 3412, 584,"division");
	system("pause");
	return 0;
}