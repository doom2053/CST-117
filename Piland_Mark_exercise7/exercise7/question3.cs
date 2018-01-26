using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class question3
    {
        const int ROLLS = 51;
        static void Main(string[] args)
        {
            Random r = new Random();
            int sum = 0;
            int[] dice1 = new int[ROLLS];
            int[] dice2 = new int[ROLLS];

            for (int roll = 0; roll <= 2; roll++)
            {
                dice1[roll] = GenerateNum(r);
                dice2[roll] = GenerateNum(r);
                sum = dice1[roll] + dice2[roll];

                Console.WriteLine("ROLL{0}: {1} + {2} = {3}", roll + 1, dice1[roll], dice2[roll], sum);

            }
        }

        static int GenerateNum(Random r)
        {
            return r.Next(0, 999);
        }
    }

}
}
