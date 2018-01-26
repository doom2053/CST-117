using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class question8
    {
        bool isEqual(string foo, string fool)
{
	int length, lengthTwo;

	length = foo.length();
	lengthTwo = fool.length();
	
	if (length == lengthTwo)
	{
		for (int i = 0; i < length && i < lengthTwo; i++)
		{
			if (foo [i] != fool [i])
			{
				return false;
			}

		}
		return true;
	}
        return false;

}

int main()
{
	cout << "Enter Two Strings:" << endl;
	string foo, fool;

	cin >> foo >> fool;

	isEqual(foo, fool);

	if (isEqual(foo, fool) == true)
		cout << "Equal!";
	if (isEqual(foo, fool) != true)
		cout << "Not Equal!";

	cin.get();
	cin.ignore();

}
    }
}
