#include<iostream>
#include <stdlib.h> 
#include<string>
using namespace std;
class Triangle 
{
public:
	virtual double getThreeSides() = 0;
	virtual double getThreeVert() = 0;
};
class RightTriangle;
class ThreeVert : public Triangle 
{
private:
	double a1, a2, a3, b1, b2, b3,area;
public:
	ThreeVert(double x1, double y1, double x2, double y2, double x3, double y3) {
		this->a1 = x1;
		this->b1 = y1;
		this->a2 = x2;
		this->b2 = y2;
		this->a3 = x3;
		this->b3 = y3;
	}
	double getThreeVert() override
	{
		area = (static_cast<double>(1) / 2) * ((a1 * b2) - (b1 * a2) + (a2 * b3) - (b2 * a3) + (a3 * b1) - (b3 * a1));
		if (a2 > a1) {
			area = abs(area);
		}
		return area;
	}
	double getThreeSides() override
	{
		return 0;
	}
};
class ThreeSides : public Triangle
{
public:
	double a, b, c, aver, mA, mB, mC, sA, sB, sC;
	string choice;
	ThreeSides() {

	}
	ThreeSides(double x, double y, double z) {
		this->a = x;
		this->b = y;
		this->c = z;
	}
	double getThreeSides() override
	{
		aver = (a + b + c) / 2;
		return sqrt(aver * (aver - a) * (aver - b) * (aver - c));
	}
	double getThreeVert() override
	{
		return 0;
	}
	double getMediana(string choice) {
		if (choice == "a")
		{
			mA = (sqrt(2 * (b * b) + 2 * (c * c) - (a * a))) / 2;
			return mA;
		}
		else if (choice == "b") {
			mB = (sqrt(2 * (a * a) + 2 * (c * c) - (b * b))) / 2;
			return mB;
		}
		else if (choice == "c") {
			mC = (sqrt(2 * (a * a) + 2 * (b * b) - (c * c))) / 2;
			return mC;
		}
		else {
			return 1;
		}
	}
	double getSerLine(string choice) {
		if (choice == "a")
		{
			sA = a / 2;
			return sA;
		}
		else if (choice == "b") {
			sB = b / 2;
			return sB;
		}
		else if (choice == "c") {
			sC = c / 2;
			return sC;
		}
		else {
			return 1;
		}
	}
	friend class RightTriangle;
};
class RightTriangle : public ThreeSides
{
public:
	double r;
	RightTriangle() {
		r = 0;
	}
	double getRadiusOutCircle() {
		if ((a * a + b * b) == (c * c)) {
			r = c / 2;
			return r;
		}
		else {
			cout << "It is not right triangle!";
		}
	}
	double getRadiusInCircle() {
		if ((a * a + b * b) == (c * c)) {
			r = (a + b - c) * 2;
			return r;
		}
		else {
			cout << "It is not right triangle!";
		}
	}
};
int main() {
	ThreeSides t1(6,4,8);
	ThreeVert t2(4, 5, 8, 9, 6, 3);
	RightTriangle t3;
	cout<<"Area from 3 sides: " << t1.getThreeSides() << "\n";
	cout<<"Area from 3 vert: " << t2.getThreeVert() << "\n";
	cout<<"Mediana to a side: " << t1.getMediana("a") << "\n";
	cout<<"Ser linia to b side: " << t1.getSerLine("b") << "\n";
	return 0;
}