using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //the size of array
            string s = Console.ReadLine(); //full fill the elements in array
            string[] k = s.Split(); //split previous string to array
            int[] a = new int[n]; //assign an array with the size n

            for (int i = 0; i < n; i++) // loop
            {
                a[i] = int.Parse(k[i]); //converting string to integer array
                for (int j = 0; j < 2; j++) //double each element
                {
                    Console.Write(a[i] + " "); //output all elments
                }
            }
        }
    }
}
