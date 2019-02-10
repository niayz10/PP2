using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task03
{
    class Program
    {
        public static void Spaces(int level)// The function that show Spaces
        {
            for(int k = 0; k < level; k++)// Cycle for showing
            {
                Console.Write("      ");// Show Spaces
            }
        }
        public static void Work(DirectoryInfo Dir,int level)
        {
            foreach(FileInfo f in Dir.GetFiles())// Cycle for Files
            {
                Spaces(level + 1);// Call the function "Spaces" with level + 1 To separate by space our files
                Console.WriteLine(f.Name);// Show the Name of each file from the given directory
            }
            foreach(DirectoryInfo d in Dir.GetDirectories()) // Cycle for Directories
            {
                Spaces(level + 1);// Call the function "Spaces" with level + 1 To Separate by space out folders
                Console.WriteLine(d.Name); // Show the name of the Folders
                Work(d, level + 2); // Recuria(Recall the ofigin function with another directory and level)
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo Dir = new DirectoryInfo(@"C:\Users\123\Desktop\PP2");// Write the path to the directory With which we works
            Console.WriteLine(Dir.Name);// Show the name Of our folder
            Work(Dir, 0);//Call the function with dir and 0(the number of spaces)
            Console.ReadKey();
        }
    }
}
