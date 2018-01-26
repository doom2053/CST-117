using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class question5
    {
        int main()
        {
            vector<string> words = { "a", "ab", "abc" };
            string shor = shortestString(words);
            cout << shor;
        }
        string shortestString(vector<string> v)
        {
            string shortest;
            int shortss = 0;
            int i = 0;
            for (string s : v)
            {
                if (i == 0)
                {
                    shortss = s.length();
                    shortest = s;
                    i++;
                }
                else if (s.length() < shortss)
                {
                    shortss = s.length();
                    shortest = s;
                }
            }
            return shortest;
        }
    }
}
