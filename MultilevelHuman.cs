using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class MultilevelHuman
    {
        public string name;
        public MultilevelHuman(string na)
        {
            name = na;
        }
        class Man : MultilevelHuman
        {
            public int age;
            public Man(int age, string name) : base(name)
            {
                this.age = age;
            }
            class Employee : Man
            {
                public int _id;
                public int _salary;
                public Employee(int id, int salary, int age, string name) : base(name, age)
                {
                    _id = id;
                    _salary = salary;
                }
                public void Print()
                {
                    Console.WriteLine($"{_id}");
                    Console.WriteLine($"{_salary}");
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{age}");
                }
            }

            public static void Main()
            {
                Employee e1 = new Employee(101,20000,"alamin",30);
                e1.Print();

            }
        }

    }
}
