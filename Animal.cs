using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Animal //base class
    {
        public string Name;
        public void Display()
        {
            Console.WriteLine("i am an animal");
        }
        public class Dog : Animal   //derived class
        {
            public void Getname()
            {
                Console.WriteLine("my name is "+Name);
            }

        }
        static void Main()
        {
            Dog d = new Dog();

            d.Name="alamin";
            d.Display();

            d.Getname();

            Console.ReadKey();

        }
    }
}
