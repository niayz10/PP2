using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class  Student   // Created a class
    {
        public string name;
        public string ID;
        public int YearOFStudy;
        public Student(string name , string ID)// Constructor which will take two parametrs
        {
            this.name = name;
            this.ID = ID;
        }
        public string Getname()//The method which returns name of the Student
        {
            return name;
        }
        public string GetId()//The method which returns ID of the Student 
        {
            return ID;
        }
        public int GetYearOFStudy()//The method which increases  the year of the student ;
        {
            return ++YearOFStudy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student alpachino = new Student(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(alpachino.Getname());//Call the function Getname to access the name and Show it
            Console.WriteLine(alpachino.GetId()); //Call the function GetID to access to ID and show it 
            Console.WriteLine(alpachino.GetYearOFStudy());// Call the function GetYearOFStudy to increase the year of the study
            Console.ReadKey();

        }
    }
}
