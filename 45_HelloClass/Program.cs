using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_HelloClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(18, "Timonthy");
            student.Report();

            // 初识反射
            Console.WriteLine("--------------------");
            Type t = typeof(Student);
            Console.WriteLine(t.FullName);
            object o = Activator.CreateInstance(t, 18, "Jacky");
            Console.WriteLine(o.GetType().FullName);
            Console.WriteLine(o is Student);  // o是student
            Student student1 = o as Student;
            student1.Report();

            // dynamic编程
            dynamic stu = Activator.CreateInstance(t, 20, "Luccy");
            Console.WriteLine(stu.Name);

            Console.WriteLine(Student.Amount);  // 103
        }
    }

    class Student
    {
        // 静态属性
        public static int Amount { get; set; }

        // 静态构造函数
        static Student()
        {
            Amount = 100;
        }

        // 类的实例构造函数
        public Student(int age, string name)
        {
            Age = age;
            Name = name;

            Amount++;
        }

        // 类的析构函数
        ~Student()
        {
            Amount--;
            Console.WriteLine("Bye bye! Rekease the system resources...");
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"My Name is {Name}, my age is {Age}");
        }
    }
}
