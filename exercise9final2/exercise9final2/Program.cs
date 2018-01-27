using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
//Corrected by Mark Piland
namespace exercise9final2
{
        class Program
    {
        static void Main( string[] args )
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();
            //needed for the foreach
            var C = A.Union(B);
                
            

            //put some stuff in the sets
            Random r = new Random( );
            for(int i = 0;  i <10; i++)
            {
                //Needs a base of a 0 for minimum number
                //A.addElement( r.Next(  4 ) );
                //B.addElement( r.Next(  12 ) );
                A.addElement(r.Next(0,4));
                B.addElement(r.Next(0,12));
            }

            
            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            //Only repeats Set B
            //Console.WriteLine("A union B: " + C);
            Console.WriteLine("A union B: ");
            foreach (var n in C)
            {
                Console.WriteLine(n);
            }


            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
           
        }
    }

}

    