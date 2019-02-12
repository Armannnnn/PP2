using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // create int which will be length of an array
            string[,] s = new string[n, n];  // assign a 2d array
            for (int i = 0; i < n; i++) // run through strings
            {
                for (int j = 0; j <= i; j++) // run through columns
                {
                    s[i, j] = "[*]"; // replace coordinates to symbol
                    Console.Write(s[i, j]); // print out symbols
                }
                Console.WriteLine();
            }    
            Console.ReadKey();
            
        }
    }
}
