#include<iostream>
using namespace std;

//Створюємо структуру в якій будуть зберігатися потрібні нам змінні та функції
struct multiply {
	int firstNumber;
	double secondNumber;
	int result;
	multiply Init(int x = 0, double y = 0);
	multiply read();
	multiply mult();
	void display();
};
//Розписуємо функцію "INIT" щоб вона контролювали наші вхідні змінні
multiply multiply::Init(int x , double y ) {
	multiply m1;
	m1.firstNumber = x;
	m1.secondNumber = y;
	return m1;
}
//Розписуємо функцію "READ" яка буде просити нас ввести наші дані
multiply multiply::read() {
	multiply m1;
	cout<<"Input first number:" << endl;
	cin >> m1.firstNumber ;
	cout<<"Input second number" << endl;
	cin >> m1.secondNumber;
	return m1;
}
//Розписуємо функцію "MULT" яка поверне нам результат добутку 2-ох чисел
multiply multiply::mult() {
	multiply m1{};
	result = firstNumber * secondNumber;
	return m1;
}
//Розписуємо функцію "DISPLAY" яка виведе данні які ми отримали
void multiply::display() {
	mult();
	cout<<"Your first number: "<<firstNumber<<endl;
	cout<<"Your second number: "<<secondNumber<<endl;
	cout<<"Result of multiplication: "<<result<<endl;
}
//Об'єднуємо усе та сподіваємося що все працює
int main() {
	multiply m2;
	m2 = m2.Init();
	m2 = m2.read();
	m2.display();
	system("PAUSE");
}
