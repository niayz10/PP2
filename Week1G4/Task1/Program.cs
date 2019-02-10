using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        static bool IsPrime(int number)// Created bool function which will return true or false
        {
            if (number == 1 || number == 0)// if the number equal 1 or 0 The function will return false
                return false;
            for(int i = 2; i < number; i++)// Cycle from 2 to number
            {
                if (number % i == 0)// Condition which returns false If the number when dividing by the remainder is zero
                    return false;
            }
            return true;// returns true if the previus conditions does not perform
        }
            static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine()); //Created a dimension of array 
            string s = Console.ReadLine(); //Created a string which is get meanning from console
            string[] ar = s.Split(); // Created an array of type string which get the symbols from string s and I use the method Split to make a space beyween symbols
            int[] array = new int[c];//Created an array of type int and I use method new which is created a memory for array
            for(int i = 0; i < c; i++)//cycle from zero to c
            {
                array[i] = int.Parse(ar[i]);//Using method Parse to translate string into int and I fill the array of type int 
            }
            int cnt = 0;//Created a counter 
            for (int i = 0; i < c; i++)//Cycle from 0 to c
            {
                if (IsPrime(array[i]) == true)//Condition that use the function IsPrime to verify numbers : It is prime or not prime
                {
                    cnt++;// If it is prime number I increase the counter
                }
            }
                Console.WriteLine(cnt);//I output counter
            
            for(int i=0;i<c;i++)//cycle from 0 to c
            {
                if (IsPrime(array[i]) == true) //Condition that use the function IsPrime to verify numbers : It is prime or not prime
                    Console.Write(array[i] + " ");// I output the numbers that are prime
            }
            Console.ReadKey();
        }
    }
}
