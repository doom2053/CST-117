using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class question4
    {
        int check(string str)
        {
            // Compute sum of digits
            int n = str.length();
            int digitSum = 0;
            for (int i = 0; i < n; i++)
                digitSum += (str[i] - '0');

            // Check if sum of digits is divisible by 3.
            return (digitSum % 3 == 0);
        }

        // Driver code
        int main()
        {
            string str = "333";
            check(str) ? cout << "Yes" : cout << "No ";
            return 0;
        }
    }
}
