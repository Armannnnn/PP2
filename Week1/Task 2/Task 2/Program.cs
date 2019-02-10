using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public int ID;
        public string yearofstudy;

        public Student(string name, int ID, string yearofstudy)
        {
            this.name = name;
            this.ID = ID;
            this.yearofstudy = yearofstudy;
        }

        public Student()
        {
            name = Console.ReadLine();
            ID = Convert.ToInt32(Console.ReadLine());
            yearofstudy = Console.ReadLine();
        }

        public void PrintInfo()
        {

            Console.WriteLine(name);
            Console.WriteLine(ID);
            Console.WriteLine(yearofstudy);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student();
            x.PrintInfo();
        }
    }
}