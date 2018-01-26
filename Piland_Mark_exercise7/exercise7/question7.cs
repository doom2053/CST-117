using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class question7
    {
        int main()
        {
            srand(time(0));
            int array[50];
            bool used[101] = { false };
            for (int i = 0; i < 50; ++i)
            {
                do
                {
                    array[i] = rand() % 100 + 1;
                } while (used[array[i]);
                used[array[i]] = true;
            }
        }
    }
}
