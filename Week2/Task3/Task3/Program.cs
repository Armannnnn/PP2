using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {   
        static void level (int lvl) //function to add spaces
        {
            for (int i = 0; i < lvl; i++)
                Console.Write("   ");
        }
        public static void directories (DirectoryInfo dir, int lvl) //fuction to output list of directories and files
        {
            foreach(DirectoryInfo y in dir.GetDirectories())
            {
                level(lvl); //use the level func
                Console.WriteLine(y.Name); //output names of folders
                directories(y, lvl + 1); //using recursion repeat while the directories ends
            }
            foreach(FileInfo x in dir.GetFiles())
            {
                level(lvl); //adds spaces to file
                Console.WriteLine(x.Name); // outputs names of files
            }
        }
        static void Main(string[] args)
        {
            int cnt = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ленова\Desktop\PP2"); //path of folder
            directories(dir, cnt); //use the function
        }
    }
}
