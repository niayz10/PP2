using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task4
{
    class Program
    {
        public static void Show()
        {
            StreamWriter sr = new StreamWriter(@"C:\Users\123\Desktop\PP2\WWW.txt");//  Creat the file int the folder below 2 files from the initial path
            sr.Write("PP2 the best!");//Fill in the file
            sr.Close();// Close File
            string path1 = @"C:\Users\123\Desktop\PP2\WWW.txt";         
            string path2 = @"C:\Users\123\Desktop\WWW.txt";
            //Copy File From the Initial path to another path
            File.Copy(path1, path2);
            // Deleted original file 
            File.Delete(path1);
        }
        static void Main(string[] args)
        {
            Show();// Call the function 
        }
    }
}
