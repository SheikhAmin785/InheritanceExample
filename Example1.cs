using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Example1
    {
        string name;
        public void Display()
        {
            Console.WriteLine("my name is alamin");
        }

        class Alamin : Example1
        {
            int id;
            public void Get()
            {
                Console.WriteLine("my id number is:"+id);
                Console.WriteLine("my name"+name);
            }
        }
        static void Main()
        {
            Alamin a1 = new Alamin();
            a1.Get = 1;
            a1.Display = "alamin";


        }
    }
}
