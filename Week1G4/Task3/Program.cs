using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] clonsofarray(int[] arr)// Method that makes out of an array of integers another array of integers,where every element is repeated
        {
            int[] array = new int[arr.Length * 2]; // array with length of array which is sent
            int cnt = -1;
            for (int i = 0; i < arr.Length; i++)// cycle in which every element in array take value from the array which is sent twice
            {
                cnt++;
                array[cnt] = arr[i];
                cnt++;
                array[cnt] = arr[i];
            }
            return array;// return array  where every element is repeated
        }
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ar = s.Split();
            int[] array = new int[c]; // created array with c integers
            for (int i=0;i<c;i++)// Cycle in which every number in array takes every values from ar
            {
                array[i] = int.Parse(ar[i]);
            }
            int[] secarr = clonsofarray(array);// Write the resulting double array into new Array
            for (int i=0;i<secarr.Length;i++)
            {
                Console.Write(secarr[i] + " ");// Show The new double array 
            }
            Console.ReadKey();
        }
    }
}
