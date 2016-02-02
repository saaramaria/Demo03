using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 2.2.2016
/// <summary>
/// Using Dog-class
/// </summary>
namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[3];

            //save dogs in array
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i] = new Dog();
            }

            //change the information of the dog in the first index
            dogs[0].Name = "Tuutikki";
            dogs[0].Age = 1.5;
            dogs[0].Breed = "Japanese Spitz";
            dogs[0].Color = "White";
            dogs[0].Toys = 7;
            dogs[0].Owner = "Saara Virtanen";

            //print dogs
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].PrintData();
            }

            Dog dog2 = new Dog("Tessu", 3, "Samoyed"); //parametric constructor
            dog2.AddToy();
            dog2.Color = "White";
            dog2.Owner = "Kirsi Kernel";
            dog2.PrintData();
        }
    }
}
