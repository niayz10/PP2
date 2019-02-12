using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine()); // Created the variable b and ask user write it.
            string[,] twoarray = new string[b, b]; // Created 2Darray with dimensions b*b
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i >= j)  // Condition which works if i more or equal j.
                    {
                        twoarray[i, j] = "[*]"; // Write [*] into 2Darray                    
                    }
                }
            }
                for (int h = 0; h < b; h++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(twoarray[h, j]); // Show the elements of the 2Darray
                    }
                    Console.Write("\n"); // use to begin the drow from the new line
                }
                Console.ReadKey();// use to show the result until the window did not close
            
        }
    }
}
