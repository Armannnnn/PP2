using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine(); // firstly we need to give name to the file 
            string sourcePath = @"C:\Users\ленова\Desktop\PP2\Week2\Task4"; // directory where we creare the original file
            string targetPath = @"C:\Users\ленова\Desktop\PP2\Week2\Task3"; // directory where will be located copied file
            string sourceFile = Path.Combine(sourcePath, filename);
            string destFile = Path.Combine(targetPath, filename);
            File.Create(sourcePath + @"\" + filename).Dispose(); // creating a file
            Console.WriteLine("Press SPACE to copy the file"); // some guides
            ConsoleKeyInfo pressedKey = Console.ReadKey(); 
            if (pressedKey.Key == ConsoleKey.Spacebar) // if we press SPACE then our file copies to the targetPath
            {
                File.Copy(sourceFile, destFile);
            }
            Console.WriteLine("Press Backspace to copy the file"); // some guides
            ConsoleKeyInfo pressedKey2 = Console.ReadKey();
            if (pressedKey2.Key == ConsoleKey.Backspace)
            {
                File.Delete(sourcePath + @"\" + filename); // if we press BACKSPACE then our file deletes from the sourcePath
            }
        }
    }
}
