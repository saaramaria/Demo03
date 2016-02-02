using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 30.1.2016
/// <summary>
/// Student-class
/// </summary>
namespace T5
{
    class Student
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentNo { get; set; }
        public int Credits { get; set; }
        public string Field { get; set; }
        public bool IsHavingABeer { get; set; }

        //default constructor
        public Student()
        {
            Name = "Matti Meikäläinen";
            IsHavingABeer = false;
        }

        //add course credits
        public void AddCredits()
        {
            Credits += 2;
        }

        //have a beer
        public void HaveABeer()
        {
            IsHavingABeer = true;
        }

        //print student information to console
        public void PrintData()
        {
            Console.WriteLine("Student:");
            Console.WriteLine("- Name and age: {0}, {1}", Name, Age);
            Console.WriteLine("- StudentNo: {0}", StudentNo);
            Console.WriteLine("- Credits: {0}", Credits);
            Console.WriteLine("- Field: {0}", Field);
            Console.WriteLine("- Is having a beer: {0}", IsHavingABeer);
        }
    }
}
