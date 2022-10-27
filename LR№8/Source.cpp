#include<iostream>
#include"Long.h"
#include"Pair.h"
using namespace std;
Pair Pair::operator+(Pair add) {
	Pair temp;
	temp.x = x + add.x;
	temp.y = y + add.y;
	return temp;
}
Long Long::substraction(Pair p1,Pair p2) {
	Long temp;
	temp.high = p1.x - p2.x;
	temp.low = p1.y - p2.y;
	return temp;
}
Long Long::multiplcation(Pair p1, Pair p2) {
	Long temp;
	temp.high = (p1.x * p2.x) - (p1.y * p2.y);
	temp.low = (p1.x * p2.y) + (p1.y * p2.x);
	return temp;
}
int main() {
	Pair p1(3,5), p2(5,4);
	Pair p3;
	Long sub,mult;
	p1.show();
	p2.show();
	p3 = p1 + p2;
	cout << endl << "After adding two points";
	p3.show();
	sub = sub.substraction(p1, p2);
	cout << endl << "After substraction two points" << endl;
	sub.show();
	mult = mult.multiplcation(p1, p2);
	cout << endl << "After multiplcation of two points" << endl;
	mult.show();


}