#pragma once
#include"Pair.h"
class Long : public Pair
{
public:
	double high, low;
	Long() {
		high = low = 0.0;
	}
	Long(double a, double b) {
		this->high = a;
		this->low = b;
	}
	void show() {
		cout << endl << "X:" << high << "  Y:" << low << endl;
	}
	Long substraction(Pair p1, Pair p2);
	Long multiplcation(Pair p1, Pair p2);

};
	