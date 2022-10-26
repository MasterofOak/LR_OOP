#include<iostream>
#include <cmath>
using namespace std;
double dist() {
	int x1, y1, x2, y2;
	cout << "Enter the coordinates of the first point\n";
	cout << "x1: ";
	cin >> x1;
	cout << "y1: ";
	cin >> y1;
	cout << "\n";
	cout << "Enter the coordinates of second point\n";
	cout << "x2: ";
	cin >> x2;
	cout << "y2: ";
	cin >> y2;
	if (x1 != x2 && y1 != y2)
	{
		return sqrt(pow((x1 - x2), 2) + pow((y1 - y2), 2));
	}
	else
	{
		cout<<"Error!It is the same point try again!\n";
	}
}
int main() {
	double result = dist();
	cout <<"Result: " << result;
	return 0;
}