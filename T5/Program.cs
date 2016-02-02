using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 30.1.2016
/// <summary>
/// Using Student-class
/// </summary>
namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            Student[] students = new Student[4];

            //save students in array
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            //change the information of the student in the first index
            students[0].Name = "Saara Virtanen";
            students[0].Credits = 35;
            students[0].AddCredits();
            students[0].Age = 21;
            students[0].StudentNo = "K1698";
            students[0].Field = "ICT";
            students[0].HaveABeer();

            //print students
            for (int i = 0; i < students.Length; i++)
            {
                students[i].PrintData();
            }

            //parametric constructor
            Student student2 = new Student("Pena", 19, "K1111", true);
            student2.PrintData();
        }
    }
}
