using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static bool Prime(int a) //function for checking prime numbers
        {
            bool ch = true;
            if (a == 1) ch = false; // one is not prime number 
            for (int i = 2; i < a; i++) //if number is prime, then we need to check whether number is divisible till itself
            {
                if (a % i == 0)
                {
                    ch = false;
                }
            }
            return ch;
        }
        static void Main(string[] args)
        {

            int n; //creating a variable
            n = int.Parse(Console.ReadLine()); //assign an array
            string s = Console.ReadLine();
            string[] arr = s.Split(); //creating new array and split elements of the array
            int cnt = 0; //variable for counting primes
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]); //converting elements of the array to integer
                if (Prime(c) == true) //checking the number
                {
                    cnt++; // if prime then we add 1 to counter
                }
            }
            Console.WriteLine(cnt); //display the counter

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]); //converting elements of the array to integer
                if (Prime(c) == true) // check whether number is prime or not
                {
                    Console.WriteLine(c + " "); //display all prime numbers
                }
            }
            Console.ReadKey();
        }
    }
}
