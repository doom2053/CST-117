using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercise10
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            string inFileName = null;

            Console.WriteLine("Enter the name of the file to process:");
            inFileName = Console.ReadLine();
            Console.WriteLine(inFileName);
           
            StreamReader sr = new StreamReader(inFileName);
           
            


            
            string[] Words = null;
            string line = null;
            string delim = " ,.";

            while (!sr.EndOfStream)
            {
                Console.WriteLine();
                line = sr.ReadLine();
                line.Trim();
                Words = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                
            }
            
            for (int i = 0; i < Words.Length; i++)
                {
                    if ((Words[i] != "") && ((Words[i][Words[i].Length - 1] == 't') || (Words[i][Words[i].Length - 1] == 'T') || (Words[i][Words[i].Length - 1] == 'e') || (Words[i][Words[i].Length - 1] == 'E')))
                        count++;
                }
            sr.Close();
                Console.WriteLine("The amount of t and e in the text is: " + count);

            File.AppendAllText("test.txt", "The amount of t and e in the text is: " + count + Environment.NewLine);


        }
    }
}
   

   
                
