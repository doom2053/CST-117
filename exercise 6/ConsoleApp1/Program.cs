using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            RollingDice rd = new RollingDice();
            TimerCallback callBack = new TimerCallback(rd.CallBackFunction);
            System.Threading.Timer t = new System.Threading.Timer(callBack, autoEvent, 0, 100);
            autoEvent.WaitOne();
            t.Dispose();
            Console.WriteLine(" It Took: {0} Rolls to Get Snake Eyes. ", rd.rollingCount);
            Console.Write(rd.first);
            Console.Write(rd.second);
            
            Console.ReadKey();
        }


    }
    class RollingDice
    {
        public int first;
        public int second;
     
        public int rollingCount;
        Random r = new Random();

        public void CallBackFunction(Object stateInfo)
        {
            AutoResetEvent state = (AutoResetEvent)stateInfo;
            first = r.Next(1, 7);
            second = r.Next(1, 7);
            Console.Write("First Dice Roll is: " + first);
            Console.Write("   Second Dice Roll is:  " + second);
            
            Console.WriteLine();
            rollingCount++;
            if (CheckIfExistTwoNumberEqual())
            {
                state.Set();
            }

        }
        bool CheckIfExistTwoNumberEqual()
        {
            return (first == 1 && second == 1 );
        }
    }
}