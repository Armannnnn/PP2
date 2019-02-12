using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Palindrome()
        {
            StreamReader ss = new StreamReader(@"C:\Users\ленова\Desktop\PP2\Week2\Task1\input.txt.txt"); // choose a file where we will read numbers
            string s = ss.ReadLine(); // create a string and read elements from txt
            int cnt = 0; // create a counter 
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != s[s.Length - 1 - i]) // if first half of the number is not equal to another part
                    cnt++; // we need to add it to the counter
            }

            if (cnt >= 1) // if counter is equal or more than 1 
                Console.WriteLine("No"); // then print no
            else Console.WriteLine("Yes"); // else yes
            ss.Close(); // after the checking close txt

        }
        static void Main(string[] args) {
            Palindrome(); // launch a function 
            Console.ReadKey();
        }
    }
}
