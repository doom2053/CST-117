using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class question10
    {
        void motionPicture :: printArray()
        {
            //need to pass an int in array element variable
            int size = 0;
            size = sizeof(table) / sizeof(table[0][0]);
            double max = table[0][0]++;
            double min = table[0][0]++;


            cout << "Listed below is your totals within each Motion Picture Company" << endl;
            cout << "----------------------------------------------------------------" << endl;

            cout << "Name" << setw(10) << '|' << setw(5) << "Paramount" << setw(5) << '|' << setw(5) << "Cent Fox" << setw(6) << '|' << setw(5) <<
                "Warner" << setw(8) << '|' << setw(5) << "WaterFront" << setw(4) << '|' << setw(5) << "Total" << endl << endl;

            for (int i = 0; i < count; i++)
            {
                double total = 0;
                double average = 0;
                cout << string1[i] << setw(8) << '|';

                for (int j = 0; j < columns; j++)
                {

                    //cout <<string1[i]<<"\t";
                    cout << setw(7) << table[i][j] << setw(7) << '|' << setw(7);
                    //input total

                    total += table[i][j];
                    average = total / columns;
                    if (table[i][j] > min)
                        max = table[i][j];
                    else if (table[0][0] < min)
                        min = table[i][j];



                }//end j loop

                cout << setw(5) << total << "\n";
                cout << endl;
                cout << "Total: " << total << endl;
                cout << "Average: " << average << endl;
                cout << "Max: " << max << endl << endl;

            }//end i loop
        }//end print
    }
}
