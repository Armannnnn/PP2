using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool Prime(int a) //function for checking prime numbers
        {
            bool ch = true;
            if (a == 1) ch = false; // one is not prime number 
            for (int i = 2; i < a; i++) //if number is prime, then we need to check whether number is divisible till itself
            {
                if (a % i == 0) // if it divides to numbers in interval between 1 and itself, then it is not prime
                {
                    ch = false;
                }
            }
            return ch;
        }
        static void Prime()
        {
            StreamReader sr = new StreamReader(@"C:\Users\ленова\Desktop\PP2\Week2\Task2\Task2\input.txt"); // choose a file where we will read numbers
            string[] arr = sr.ReadLine().Split(); // assign array of chars 
            StreamWriter sw = new StreamWriter(@"C:\Users\ленова\Desktop\PP2\Week2\Task2\Task2\output.txt"); // choose a file where we will write prime numbers
            int[] arr2 = new int[1000]; // assign new integer array
            for (int i = 0; i < arr.Length; i++) // run through the loop
            {
                if (Prime(int.Parse(arr[i])) == true) // if number is prime, then we need to write it to output.txt
                {
                    sw.Write(int.Parse(arr[i]) + " "); 
                }
            }
            sr.Close(); // closing txt
            sw.Close(); // closing txt
        }
        static void Main(string[] args)
        {
            Prime(); // launch a function
            Console.ReadKey();
        }
    }
}
