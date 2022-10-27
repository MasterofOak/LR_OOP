#pragma once
#include<iostream>
using namespace std;
class Pair {
public:
	double x, y;
	Pair(){
		x = y = 0.0;
	}
	Pair(double a, double b) {
		this->x = a;
		this->y = b;
	}
	void show() {
		cout << endl << "X:" << x << "  Y:" << y<<endl;
	}
	Pair operator+(Pair add);
	
};