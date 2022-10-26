#include<iostream>
#include <cmath>
#include<exception>
using namespace std;
double dist() {
	int x1, y1, x2, y2;
	double result;
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
	try
	{
		if (x1 != x2 && y1 != y2)
		{
			result = sqrt(pow((x1 - x2), 2) + pow((y1 - y2), 2));
			cout << result;
		}
		else
		{
			throw exception("You entered same coordinates for both point! Try again!");
		}
	}
	catch (const overflow_error error) {
		cout << error.what() << endl;
	}
	catch (const runtime_error error) {
		cout << error.what() << endl;
	}
	catch (const exception error) {
		cout << error.what()<<endl;
	}
}
int main() {
	dist();
	return 0;
}