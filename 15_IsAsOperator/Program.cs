using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_IsAsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher tea = new Teacher();
            Car car = new Car();
            Console.WriteLine(tea is Human);  // 所有的老师都是人
            Console.WriteLine(tea is Animal);
            Console.WriteLine(car is Object);

            Human hu = new Human();
            Console.WriteLine(hu is Teacher);  // 不是所有人都是老师

            // as运算符
            object o = new Teacher();
            Teacher t = o as Teacher;
            if (t != null)
            {
                t.Teach();
            }

        }

        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        class Human : Animal
        {
            public void Run()
            {
                Console.WriteLine("Running...");
            }
        }

        class Teacher : Human
        {
            public void Teach()
            {
                Console.WriteLine("Teaching...");
            }
        }

        class Car
        {
            public void Drive()
            {
                Console.WriteLine("Driving...");
            }
        }
    }
}
