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
        static void Do()
        {
            StreamReader an = new StreamReader(@"C:\Users\123\Desktop\PP2\input.txt.txt");
            string s = an.ReadToEnd();// Create string to Write Down the word from the beginning to the end  from the "input.txt" file into s
            bool check = true; // Create bool for cheching 
            for (int i=0;i<s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])// Condition which comes into if i-th element of the word is not equal s.Length - 1-i
                    check = false;
            }
            if (check == true) // Condition Which Shows Yes if Chech is equal true in the end
                Console.Write("Yes");
            else
            {
                Console.Write("No");// Show NO if Check is equal false
            }
            an.Close(); // Do not forget to close the project

        }   
        static void Main(string[] args)
        {
            Do();// Call the function to check for palindrom
            Console.ReadKey();
        }
    }
}
