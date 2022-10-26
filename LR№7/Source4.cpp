#include<iostream>
#include <cmath>
#include<exception>
using namespace std;
class destination1 {
	public:
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
				cout<<"Result: " << result << endl;
			}
			else
			{
				throw ("You entered same coordinates for both point! Try again!\n");
			}
		}
		catch (const char* error) {
			cout << error << endl;
		}
	}
};
class destination2 {
public:
	int x1, x2, y1, y2;
	double dist(int x1, int x2, int y1, int y2){
		double result;
		try
		{
			if (x1 != x2 && y1 != y2)
			{
				result = sqrt(pow((x1 - x2), 2) + pow((y1 - y2), 2));
				cout << "Result: " << result <<endl;
			}
			else
			{
				throw ("You entered same coordinates for both point! Try again!\n");
			}
		}
		catch (const char* error) {
			cout << error << endl;
		}
	}
};
int main() {
	destination1 dist1;
	dist1.dist();
	destination2 dist2;
	dist2.dist(5,5,5,5);
	return 0;
}