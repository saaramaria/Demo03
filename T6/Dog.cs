using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 2.2.2016
/// <summary>
/// Dog-class
/// </summary>
namespace T6
{
    class Dog
    {
        //properties
        public string Name { get; set; }
        public double Age { get; set; }
        public string Breed { get; set; }
        public string Owner { get; set; }
        public string Color { get; set; }
        public int Toys { get; set; }

        //default constructor
        public Dog()
        {
            Name = "Musti";
            Owner = "Matti Meikäläinen";
        }

        //parametric constructor
        public Dog(string name, double age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        //add a toy
        public void AddToy()
        {
            Toys += 1;
        }

        //remove a toy
        public void RemoveToy()
        {
            Toys -= 1;
        }

        //print dog's information to console
        public void PrintData()
        {
            Console.WriteLine("Dog:");
            Console.WriteLine("- Name: {0}", Name);
            Console.WriteLine("- Age: {0}", Age);
            Console.WriteLine("- Breed: {0}", Breed);
            Console.WriteLine("- Color: {0}", Color);
            Console.WriteLine("- Toys: {0}", Toys);
            Console.WriteLine("- Owner: {0}", Owner);

        }
    }
}
